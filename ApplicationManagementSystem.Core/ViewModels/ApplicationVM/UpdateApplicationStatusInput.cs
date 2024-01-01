using ApplicationManagementSystem.Core.Enums;

namespace ApplicationManagementSystem.Core.ViewModels.ApplicationVM;

public class UpdateApplicationStatusInput
{
    public Guid Id { get; set; }
    public ApplicationStatus Status { get; set; }

    public string Response { get; set; }
}
