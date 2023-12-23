using ApplicationManagementSystem.Core.DbModels;

namespace ApplicationManagementSystem.Core.Utilities.Security.JWT
{
    public interface IJwtAuthenticationManager
    {
        //AccessToken CreateToken(User user, List<Permission> operationClaims);
        AccessToken CreateToken(User user);
    }
}
