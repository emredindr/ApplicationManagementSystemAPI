namespace ApplicationManagementSystem.Core.Entities.Audit;

public interface ISoftDelete
{
    bool IsDeleted { get; set; }
}
