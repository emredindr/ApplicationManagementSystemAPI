using ApplicationManagementSystem.Core.Enums;
using ApplicationManagementSystem.Core.ViewModels.DocumentVM;

namespace ApplicationManagementSystem.Core.ViewModels.ApplicationVM;

public class GetAllApplicationInfo
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime Birthday { get; set; }
    public string IdentityNumber { get; set; }
    public string Reason { get; set; }
    public string Address { get; set; }
    public ApplicationStatus Status { get; set; }
    public string Response { get; set; }
    public DateTime CreationTime { get; set; }

    public List<GetAllDocumentInfo> Documents { get; set; }
}
