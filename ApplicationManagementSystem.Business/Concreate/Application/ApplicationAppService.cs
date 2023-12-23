using ApplicationManagementSystem.Business.Abstract;
using ApplicationManagementSystem.Core.DbModels;
using ApplicationManagementSystem.Core.Dto.Response;
using ApplicationManagementSystem.Core.Repositories;
using ApplicationManagementSystem.Core.ViewModels.ApplicationVM;
using ApplicationManagementSystem.Core.ViewModels.DocumentVM;
using Microsoft.EntityFrameworkCore;

namespace ApplicationManagementSystem.Business.Concreate;

public class ApplicationAppService : BaseAppService, IApplicationAppService
{
    private readonly IRepository<Application, Guid> _applicationRepository;
    private readonly IRepository<ApplicationDocument, int> _applicationDocumentRepository;
    private readonly IRepository<Document, int> _documentRepository;

    public ApplicationAppService(IRepository<Application, Guid> applicationRepository, IRepository<ApplicationDocument, int> applicationDocumentRepository, IRepository<Document, int> documentRepository)
    {
        _applicationRepository = applicationRepository;
        _applicationDocumentRepository = applicationDocumentRepository;
        _documentRepository = documentRepository;
    }

    public async Task CreateApplication(CreateApplicationInput input)
    {
        var newApplication = Mapper.Map<Application>(input);

        await _applicationRepository.InsertAsync(newApplication);

    }

    public async Task<ListResult<GetAllApplicationInfo>> GetApplicationList()
    {
        var query = from application in _applicationRepository.GetAll()
                    select new GetAllApplicationInfo
                    {
                        Id = application.Id,
                        FirstName = application.FirstName,
                        LastName = application.LastName,
                        Email = application.Email,
                        Birthday = application.Birthday,
                        IdentityNumber = application.IdentityNumber,
                        Reason = application.Reason,
                        Address = application.Address,
                        Status = application.Status,
                        Response = application.Response,
                        Documents = (from applicationDocument in _applicationDocumentRepository.GetAll()
                                     join document in _documentRepository.GetAll() on applicationDocument.DocumentId equals document.Id
                                     where applicationDocument.ApplicationId == application.Id
                                     select new GetAllDocumentInfo
                                     {
                                         Id = document.Id,
                                         Url = document.Url
                                     }).ToList()

                    };
        var applications = await query.ToListAsync();

        var mappedActivities = Mapper.Map<ListResult<GetAllApplicationInfo>>(applications);
        return mappedActivities;
    }

    public Task UpdateApplication(UpdateApplicationInput input)
    {
        throw new NotImplementedException();
    }
}
