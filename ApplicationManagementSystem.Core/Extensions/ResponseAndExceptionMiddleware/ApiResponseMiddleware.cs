﻿using ApplicationManagementSystem.Core.Dto.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Diagnostics;
using System.Net;

namespace ApplicationManagementSystem.Core.Extensions.ResponseAndExceptionMiddleware;

public class ApiResponseMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ApiResponseOptions _options;
    private readonly ILogger<ApiResponseMiddleware> _logger;
    public ApiResponseMiddleware(RequestDelegate next, ApiResponseOptions options, ILogger<ApiResponseMiddleware> logger)
    {
        _next = next;
        _options = options;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {

        if (IsSwagger(context))
            await _next(context);
        else
        {
            var stopWatch = Stopwatch.StartNew();

            //var request = await FormatRequest(context.Request);

            var originalBodyStream = context.Response.Body;

            using var bodyStream = new MemoryStream();
            try
            {
                context.Response.Body = bodyStream;

                await _next.Invoke(context);

                context.Response.Body = originalBodyStream;
                if (context.Response.StatusCode == (int)HttpStatusCode.OK)
                {
                    var bodyAsText = await FormatResponse(bodyStream);
                    await HandleSuccessRequestAsync(context, bodyAsText, context.Response.StatusCode);
                }
                else
                {
                    await HandleNotSuccessRequestAsync(context, context.Response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
                bodyStream.Seek(0, SeekOrigin.Begin);
                await bodyStream.CopyToAsync(originalBodyStream);
            }
            finally
            {
                stopWatch.Stop();
                _logger.Log(LogLevel.Information,
                            $@"Request: /*request*/ Responded with [{context.Response.StatusCode}] in {stopWatch.ElapsedMilliseconds}ms");
            }
        }
    }

    private async Task<string> FormatResponse(Stream bodyStream)
    {
        bodyStream.Seek(0, SeekOrigin.Begin);
        var plainBodyText = await new StreamReader(bodyStream).ReadToEndAsync();
        bodyStream.Seek(0, SeekOrigin.Begin);

        return plainBodyText;
    }

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        ApiError apiError = null;
        int code = 0;

        if (exception is ApiException)
        {
            var ex = exception as ApiException;
            if (ex.IsModelValidatonError)
            {
                apiError = new ApiError(ResponseMessageEnum.ValidationError.GetDescription(), ex.Errors)
                {
                    ReferenceErrorCode = ex.ReferenceErrorCode,
                    ReferenceDocumentLink = ex.ReferenceDocumentLink,
                };

                _logger.Log(LogLevel.Warning, exception, $"[{ex.StatusCode}]: {ResponseMessageEnum.ValidationError.GetDescription()}");
            }
            else
            {
                apiError = new ApiError(ex.Message)
                {
                    ReferenceErrorCode = ex.ReferenceErrorCode,
                    ReferenceDocumentLink = ex.ReferenceDocumentLink,
                };

                _logger.Log(LogLevel.Warning, exception, $"[{ex.StatusCode}]: {ResponseMessageEnum.Exception.GetDescription()}");
            }

            code = ex.StatusCode;
            context.Response.StatusCode = code;

        }
        else if (exception is UnauthorizedAccessException)
        {
            apiError = new ApiError(ResponseMessageEnum.UnAuthorized.GetDescription());
            code = (int)HttpStatusCode.Unauthorized;
            context.Response.StatusCode = code;

            _logger.Log(LogLevel.Warning, exception, $"[{code}]: {ResponseMessageEnum.UnAuthorized.GetDescription()}");
        }
        else
        {

            var exceptionMessage = ResponseMessageEnum.Unhandled.GetDescription();
#if !DEBUG
            var message = exceptionMessage;
            string stackTrace = null;
#else
            var message = $"{exceptionMessage} {exception.GetBaseException().Message}";
            string stackTrace = exception.StackTrace;
#endif

            apiError = new ApiError(message) { Details = stackTrace };
            code = (int)HttpStatusCode.InternalServerError;
            context.Response.StatusCode = code;

            _logger.Log(LogLevel.Error, exception, $"[{code}]: {exceptionMessage}");
        }

        var jsonString = ConvertToJSONString(GetErrorResponse(code, apiError));

        context.Response.ContentType = "application/json";
        return context.Response.WriteAsync(jsonString);
    }

    private Task HandleNotSuccessRequestAsync(HttpContext context, int code)
    {
        ApiError apiError;
        if (code == (int)HttpStatusCode.NotFound)
            apiError = new ApiError(ResponseMessageEnum.NotFound.GetDescription());
        else if (code == (int)HttpStatusCode.NoContent)
            apiError = new ApiError(ResponseMessageEnum.NotContent.GetDescription());
        else if (code == (int)HttpStatusCode.MethodNotAllowed)
            apiError = new ApiError(ResponseMessageEnum.MethodNotAllowed.GetDescription());
        else
            apiError = new ApiError(ResponseMessageEnum.Unknown.GetDescription());

        context.Response.StatusCode = code;

        var jsonString = ConvertToJSONString(GetErrorResponse(code, apiError));

        context.Response.ContentType = "application/json";
        return context.Response.WriteAsync(jsonString);
    }

    private Task HandleSuccessRequestAsync(HttpContext context, object body, int code)
    {
        string jsonString;

        var bodyText = !body.ToString().IsValidJson() ? ConvertToJSONString(body) : body.ToString();

        dynamic bodyContent = JsonConvert.DeserializeObject<dynamic>(bodyText);
        Type type = bodyContent?.GetType();

        if (type.Equals(typeof(JObject)))
        {
            ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(bodyText, new ApiResponseConverter());
            if (apiResponse.StatusCode != code || apiResponse.Result != null ||
                apiResponse.StatusCode == code && apiResponse.Result == null)
                jsonString = ConvertToJSONString(GetSucessResponse(apiResponse));
            else
                jsonString = ConvertToJSONString(code, bodyContent);
        }
        else
        {
            jsonString = ConvertToJSONString(code, bodyContent);
        }

        context.Response.ContentType = "application/json";
        return context.Response.WriteAsync(jsonString);
    }

    private string ConvertToJSONString(int code, object content)
    {
        return JsonConvert.SerializeObject(new ApiResponse(ResponseMessageEnum.Success.GetDescription(), content, code, GetApiVersion()), JSONSettings());
    }
    private string ConvertToJSONString(ApiResponse apiResponse)
    {
        return JsonConvert.SerializeObject(apiResponse, JSONSettings());
    }
    private string ConvertToJSONString(ListResult<object> listResultResponse)
    {
        return JsonConvert.SerializeObject(listResultResponse, JSONSettings());
    }
    private string ConvertToJSONString(object rawJSON)
    {
        return JsonConvert.SerializeObject(rawJSON, JSONSettings());
    }
    private bool IsSwagger(HttpContext context)
    {
        return context.Request.Path.StartsWithSegments("/swagger");
    }

    private JsonSerializerSettings JSONSettings()
    {
        return new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Converters = new List<JsonConverter> { new StringEnumConverter() }
        };
    }

    private ApiResponse GetErrorResponse(int code, ApiError apiError)
    {
        return new ApiResponse(code, apiError) { Version = GetApiVersion() };
    }

    private ApiResponse GetSucessResponse(ApiResponse apiResponse)
    {
        if (apiResponse.Version.Equals("1.0.0.0"))
            apiResponse.Version = GetApiVersion();

        return apiResponse;
    }

    private string GetApiVersion()
    {
        return string.IsNullOrEmpty(_options.ApiVersion) ? "1.0.0.0" : _options.ApiVersion;
    }
}
