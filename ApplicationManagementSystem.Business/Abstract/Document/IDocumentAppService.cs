namespace ApplicationManagementSystem.Business.Abstract;

public interface IDocumentAppService
{
    Task<int> CreateAndGetDocumentId(string fileName, string contentType, string url);
}
