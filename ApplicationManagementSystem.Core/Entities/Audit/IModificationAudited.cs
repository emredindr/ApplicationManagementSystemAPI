namespace ApplicationManagementSystem.Core.Entities.Audit
{
    public interface IModificationAudited
    {
        int? LastModifierUserId { get; set; }
        DateTime? LastModificationTime { get; set; }
    }
}
