using ApplicationManagementSystem.Business.Abstract;
using ApplicationManagementSystem.Core.Dto.Response;
using ApplicationManagementSystem.Core.ViewModels.ApplicationVM;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
    }
}
