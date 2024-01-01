using ApplicationManagementSystem.Core.Entities;

namespace ApplicationManagementSystem.Core.DbModels;
public class Document : Entity<int>
{
    public string Name { get; set; }
    public string ContentType { get; set; }
    public string Url { get; set; }
}
