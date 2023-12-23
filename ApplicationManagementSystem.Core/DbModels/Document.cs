using ApplicationManagementSystem.Core.Entities;

namespace ApplicationManagementSystem.Core.DbModels;
public class Document : Entity<int>
{
    public string Url { get; set; }
}
