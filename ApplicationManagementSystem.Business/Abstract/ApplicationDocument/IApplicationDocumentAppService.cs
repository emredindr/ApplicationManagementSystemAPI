using ApplicationManagementSystem.Core.ViewModels.ApplicationDocumentVM;

namespace ApplicationManagementSystem.Business.Abstract;

public interface IApplicationDocumentAppService
{
    Task CreateActivityDocument(CreateApplicationDocumentInput input);
}
