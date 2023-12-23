using ApplicationManagementSystem.Core.ViewModels.UserVM;

namespace ApplicationManagementSystem.Business.Abstract
{
    public interface IUserAppService
    {
        Task<UserLoginOutput> Login(UserLoginInput input);
    }
}
