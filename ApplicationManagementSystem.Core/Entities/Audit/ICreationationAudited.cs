namespace ApplicationManagementSystem.Core.Entities.Audit;

public interface ICreationationAudited
{
    int? CreatorUserId { get; set; }
    DateTime CreationTime { get; set; }
}
