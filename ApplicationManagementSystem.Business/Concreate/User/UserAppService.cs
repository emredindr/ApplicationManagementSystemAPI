using ApplicationManagementSystem.Business.Abstract;
using ApplicationManagementSystem.Core.DbModels;
using ApplicationManagementSystem.Core.Extensions.ResponseAndExceptionMiddleware;
using ApplicationManagementSystem.Core.Repositories;
using ApplicationManagementSystem.Core.Utilities.Security.JWT;
using ApplicationManagementSystem.Core.ViewModels.UserVM;

namespace ApplicationManagementSystem.Business.Concreate;

public class UserAppService : BaseAppService, IUserAppService
{
    private readonly IJwtAuthenticationManager _jwtAuthenticationManager;
    private readonly IRepository<User, int> _userRepository;

    public UserAppService(IRepository<User, int> userRepository, IJwtAuthenticationManager jwtAuthenticationManager)
    {
        _userRepository = userRepository;
        _jwtAuthenticationManager = jwtAuthenticationManager;
    }

    public async Task<UserLoginOutput> Login(UserLoginInput input)
    {
        var userCheck = await _userRepository.GetAsync(x => x.Username == input.Username) ?? throw new ApiException($"{input.Username} was not found !");
        if (userCheck.Password != input.Password)
            throw new ApiException("Password is wrong !");


        var accessToken = _jwtAuthenticationManager.CreateToken(userCheck);

        var mappedItem = Mapper.Map<UserLoginOutput>(userCheck);
        mappedItem.Token = accessToken.Token;
        return mappedItem;
    }
}
