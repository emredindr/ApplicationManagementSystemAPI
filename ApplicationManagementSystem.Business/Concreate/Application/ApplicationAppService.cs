using ApplicationManagementSystem.Business.Abstract;
using ApplicationManagementSystem.Core.DbModels;
using ApplicationManagementSystem.Core.Dto.Response;
using ApplicationManagementSystem.Core.Extensions.ResponseAndExceptionMiddleware;
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

    public async Task<Guid> CreateAndGetApplicationId(CreateApplicationInput input)
    {
        var newApplication = Mapper.Map<Application>(input);

        return await _applicationRepository.InsertAndGetIdAsync(newApplication);
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

    public async Task UpdateApplication(UpdateApplicationInput input)
    {
        var applicationToUpdate = await _applicationRepository.FirstOrDefaultAsync(x => x.Id == input.Id);
        if (applicationToUpdate == null)
        {
            throw new ApiException("Application was not found !");
        }

        var mappedApplication = Mapper.Map<Application>(input);
        await _applicationRepository.UpdateAsync(mappedApplication);

    }
    public async Task DeleteApplication(Guid applicationId)
    {
        var application = await _applicationRepository.GetAsync(applicationId);
        if (application == null)
        {
            throw new ApiException("Application was not found !");
        }

        await _applicationRepository.DeleteAsync(applicationId);
    }

}
