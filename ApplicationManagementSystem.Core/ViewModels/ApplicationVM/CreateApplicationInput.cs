using ApplicationManagementSystem.Core.ViewModels.DocumentVM;
using System.Text.Json.Serialization;

namespace ApplicationManagementSystem.Core.ViewModels.ApplicationVM;

public class CreateApplicationInput
{
    [JsonIgnore]
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime Birthday { get; set; }
    public string IdentityNumber { get; set; }
    public string Reason { get; set; }
    public string Address { get; set; }
    public List<GetAllDocumentInfo>Documents { get; set; }
}
