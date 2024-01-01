using ApplicationManagementSystem.Business.Abstract;
using ApplicationManagementSystem.Core.DbModels;
using ApplicationManagementSystem.Core.Repositories;

namespace ApplicationManagementSystem.Business.Concreate;

public class DocumentAppService : BaseAppService, IDocumentAppService
{
    private readonly IRepository<Document, int> _documentrepository;
    public DocumentAppService(IRepository<Document, int> documentrepository)
    {
        _documentrepository = documentrepository;
    }

    public async Task<int> CreateAndGetDocumentId(string fileName, string contentType, string url)
    {
        var documentId = await _documentrepository.InsertAndGetIdAsync(new Document()
        {
            Name = fileName,
            ContentType = contentType,
            Url = url
        });
        return documentId;
    }
}
