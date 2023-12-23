using ApplicationManagementSystem.Core.Entities;

namespace ApplicationManagementSystem.Core.DbModels;

public class ApplicationDocument : Entity<int>
{
    public Guid ApplicationId { get; set; }
    public int DocumentId { get; set; }

}
