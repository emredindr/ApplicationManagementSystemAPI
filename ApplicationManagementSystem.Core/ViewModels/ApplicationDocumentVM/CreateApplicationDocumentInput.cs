namespace ApplicationManagementSystem.Core.ViewModels.ApplicationDocumentVM;

public class CreateApplicationDocumentInput
{
    public Guid ApplicationId { get; set; }
    public List<int> DocumentIds { get; set; }
}
