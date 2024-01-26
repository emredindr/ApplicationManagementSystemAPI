using ApplicationManagementSystem.Core.Enums;

namespace ApplicationManagementSystem.Core.ViewModels.ApplicationVM;

public class GetAllApplicationInput
{
    public Guid? ApplicationId { get; set; }
    public ApplicationStatus? Status { get; set; }=ApplicationStatus.Pending;
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
