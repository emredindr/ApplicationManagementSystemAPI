using ApplicationManagementSystem.Business.Abstract;
using ApplicationManagementSystem.Core.ViewModels.UserVM;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationManagementSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{

    private readonly IUserAppService _userAppService;
    public AuthController(IUserAppService userAppService)
    {
        _userAppService = userAppService;
    }

    [HttpPost("Login")]
    public async Task<UserLoginOutput> Login(UserLoginInput input)
    {
        return await _userAppService.Login(input);
    }
}
