using ApplicationManagementSystem.Business.Abstract;
using ApplicationManagementSystem.Core.Dto.Response;
using ApplicationManagementSystem.Core.ViewModels.ApplicationVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationManagementSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class ApplicationController : ControllerBase
{
    private readonly IApplicationAppService _applicationAppService;

    public ApplicationController(IApplicationAppService applicationAppService)
    {
        _applicationAppService = applicationAppService;
    }

    [HttpGet("GetApplicationList")]
    public async Task<ListResult<GetAllApplicationInfo>> GetApplicationList()
    {
        return await _applicationAppService.GetApplicationList();
    }

    [HttpPost("CreateApplication")]
    [AllowAnonymous]
    public async Task CreateApplication(CreateApplicationInput input)
    {
        await _applicationAppService.CreateAndGetApplicationId(input);
    }

    [HttpPost("UpdateApplication")]
    public async Task UpdateApplication(UpdateApplicationInput input)
    {
        await _applicationAppService.UpdateApplication(input);
    }


    [HttpDelete("DeleteApplication")]
    public async Task DeleteApplication(Guid applicationId)
    {
        await _applicationAppService.DeleteApplication(applicationId);
    }


}