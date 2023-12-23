using ApplicationManagementSystem.Business.Abstract;
using ApplicationManagementSystem.Core.Extensions.ResponseAndExceptionMiddleware;
using ApplicationManagementSystem.Core.ViewModels.DocumentVM;
using Firebase.Storage;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationManagementSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DocumentController : ControllerBase
{

    private readonly IDocumentAppService _documentAppService;
    public DocumentController(IDocumentAppService documentAppService)
    {
        _documentAppService = documentAppService;
    }

    [HttpPost("UploadDocuments")]
    public async Task<IActionResult> UploadDocuments()
    {
        Random random = new();
        var asd = random.Next(101, 1000);
        try
        {
            var files = Request.Form.Files;

            if (files == null || !files.Any())
            {
                return BadRequest();
            }

            var uploadedDocumentList = new List<UploadedDocumentInfo>();

            foreach (var file in files)
            {
                string fileExtension = Path.GetExtension(file.FileName);

                string result = file.FileName.Substring(0, file.FileName.Length - fileExtension.Length);

                string fileName = result + "-" + asd.ToString();


                string newFileName = string.Join(string.Empty, fileName, fileExtension);

                var stream = file.OpenReadStream();

                var task = new FirebaseStorage("archive-ed.appspot.com", new FirebaseStorageOptions
                {
                    ThrowOnCancel = true
                }).Child("application-documents").Child(newFileName).PutAsync(stream);

                string url = await task;

                var recordDocumentId = await _documentAppService.CreateAndGetDocumentId(newFileName, file.ContentType, url);

                uploadedDocumentList.Add(new UploadedDocumentInfo
                {
                    
                    Id = recordDocumentId,
                    Url = url
                });
            }

            return Ok(uploadedDocumentList);
        }
        catch (Exception ex)
        {
            throw new ApiException(ex);
        }
    }
}

