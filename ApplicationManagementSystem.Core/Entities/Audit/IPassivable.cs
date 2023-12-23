namespace ApplicationManagementSystem.Core.Entities.Audit
{
    public interface IPassivable
    {
        bool IsActive { get; set; }
    }
}
