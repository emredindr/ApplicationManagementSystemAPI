namespace ApplicationManagementSystem.Core.ViewModels.ApplicationVM;

public class CreateApplicationInput
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime Birthday { get; set; }
    public string IdentityNumber { get; set; }
    public string Reason { get; set; }
    public string Address { get; set; }
}
