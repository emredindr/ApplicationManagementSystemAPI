using ApplicationManagementSystem.Business.Abstract;
using ApplicationManagementSystem.Core.Dto.Response;
using ApplicationManagementSystem.Core.ViewModels.ApplicationVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationManagementSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
//[Authorize]
// Authorize attribute is commented out because of the swagger.
// Authorization is removed For Fimple Final Case
public class ApplicationController : ControllerBase
{
    private readonly IApplicationAppService _applicationAppService;

    public ApplicationController(IApplicationAppService applicationAppService)
    {
        _applicationAppService = applicationAppService;
    }

    //[HttpGet("GetApplicationListByPage")]
    //public async Task<PagedResult<GetAllApplicationInfo>> GetAllApplicationByPage([FromQuery] GetAllApplicationInput input)
    //{
    //    return await _applicationAppService.GetAllApplicationByPage(input);
    //}

    [HttpGet("GetApplicationList")]
    public async Task<ListResult<GetAllApplicationInfo>> GetApplicationList([FromQuery] GetAllApplicationInput input)
    {
        return await _applicationAppService.GetApplicationList(input);
    }

    //[HttpGet("GetApplicationById")]
    [HttpGet("{applicationId}")]
    [AllowAnonymous]
    public async Task<GetAllApplicationInfo> GetApplicationById(Guid applicationId)
    {
        return await _applicationAppService.GetApplicationById(applicationId);
    }

    [HttpGet("GetApplicationStatusRatio")]
    public async Task<GetApplicationStatusRatio> GetApplicationStatusRatio()
    {
        return await _applicationAppService.GetApplicationStatusRatio();
    }

    [HttpPost("CreateApplication")]
    [AllowAnonymous]
    public async Task<ApplicationCreateOutput> CreateApplication(CreateApplicationInput input)
    {
        return await _applicationAppService.CreateAndGetApplicationId(input);
    }

    [HttpPost("UpdateApplicationStatus")]
    public async Task UpdateApplicationStatus(UpdateApplicationStatusInput input)
    {
        await _applicationAppService.UpdateApplicationStatus(input);
    }


    [HttpDelete("DeleteApplication")]
    public async Task DeleteApplication(DeleteApplicationInput input)
    {
        await _applicationAppService.DeleteApplication(input);
    }


}