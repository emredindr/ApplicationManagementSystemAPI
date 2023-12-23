using ApplicationManagementSystem.Business.Abstract;
using ApplicationManagementSystem.Core.DbModels;
using ApplicationManagementSystem.Core.Extensions.ResponseAndExceptionMiddleware;
using ApplicationManagementSystem.Core.Repositories;
using ApplicationManagementSystem.Core.ViewModels.ApplicationDocumentVM;

namespace ApplicationManagementSystem.Business.Concreate;

public class ApplicationDocumentAppService : BaseAppService, IApplicationDocumentAppService
{
    private readonly IRepository<Document, int> _documentRepository;
    private readonly IRepository<Application, Guid> _applicationRepository;
    private readonly IRepository<ApplicationDocument, int> _applicationDocumentRepository;

    public ApplicationDocumentAppService(IRepository<ApplicationDocument, int> applicationDocumentRepository, IRepository<Document, int> documentRepository, IRepository<Application, Guid> applicationRepository)
    {
        _applicationDocumentRepository = applicationDocumentRepository;
        _documentRepository = documentRepository;
        _applicationRepository = applicationRepository;
    }

    public async Task CreateActivityDocument(CreateApplicationDocumentInput input)
    {
        var application = await _applicationRepository.FirstOrDefaultAsync(x => x.Id == input.ApplicationId);
        if (application == null) throw new ApiException("Application was not found.");

        foreach(var documentId in input.DocumentIds)
        {
            var document =await _documentRepository.FirstOrDefaultAsync(x => x.Id == documentId);

            if (document == null) throw new ApiException("Document was not found.");

            await _applicationDocumentRepository.InsertAsync(new ApplicationDocument
            {
                ApplicationId = input.ApplicationId,
                DocumentId = document.Id,
            });
        }

    }
}
