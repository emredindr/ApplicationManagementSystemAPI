using ApplicationManagementSystem.Core.Dto.Response;
using ApplicationManagementSystem.Core.ViewModels.ApplicationVM;

namespace ApplicationManagementSystem.Business.Abstract;

public interface IApplicationAppService
{
    Task<ListResult<GetAllApplicationInfo>> GetApplicationList(GetAllApplicationInput input);
    Task<GetAllApplicationInfo> GetApplicationById(Guid applicationId);
    Task<GetApplicationStatusRatio> GetApplicationStatusRatio();
    Task<ApplicationCreateOutput> CreateAndGetApplicationId(CreateApplicationInput input);
    Task UpdateApplicationStatus(UpdateApplicationStatusInput input);
    Task DeleteApplication(DeleteApplicationInput input);
}
