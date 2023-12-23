using ApplicationManagementSystem.Core.Dto.Response;
using ApplicationManagementSystem.Core.ViewModels.ApplicationVM;

namespace ApplicationManagementSystem.Business.Abstract;

public interface IApplicationAppService
{
    Task<ListResult<GetAllApplicationInfo>> GetApplicationList();
    Task CreateApplication(CreateApplicationInput input);
    Task UpdateApplication(UpdateApplicationInput  input);
}
