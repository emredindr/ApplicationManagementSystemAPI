using ApplicationManagementSystem.Core.Entities.Audit;
using ApplicationManagementSystem.Core.Enums;

namespace ApplicationManagementSystem.Core.DbModels;

public class Application : FullAudited<Guid>, ISoftDelete
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime Birthday { get; set; }
    public string IdentityNumber { get; set; }
    public string Reason { get; set; }
    public string Address { get; set; }
    public ApplicationStatus Status { get; set; } = ApplicationStatus.Pending;
    public string Response { get; set; } = string.Empty;
}
