using ApplicationManagementSystem.Business.Abstract;
using ApplicationManagementSystem.Core.DbModels;
using ApplicationManagementSystem.Core.Dto.Response;
using ApplicationManagementSystem.Core.Enums;
using ApplicationManagementSystem.Core.Extensions.Linq;
using ApplicationManagementSystem.Core.Extensions.ResponseAndExceptionMiddleware;
using ApplicationManagementSystem.Core.Repositories;
using ApplicationManagementSystem.Core.ViewModels.ApplicationVM;
using ApplicationManagementSystem.Core.ViewModels.DocumentVM;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using Application = ApplicationManagementSystem.Core.DbModels.Application;

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

    public async Task<ListResult<GetAllApplicationInfo>> GetApplicationList()
    {
        var query = from application in _applicationRepository.GetAll()
                    where !application.IsDeleted && application.Status == ApplicationStatus.Pending
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
                        CreationTime = application.CreationTime,
                        Documents = (from applicationDocument in _applicationDocumentRepository.GetAll()
                                     join document in _documentRepository.GetAll() on applicationDocument.DocumentId equals document.Id
                                     where applicationDocument.ApplicationId == application.Id
                                     select new GetAllDocumentInfo
                                     {
                                         Id = document.Id,
                                         Name=document.Name,
                                         ContentType=document.ContentType,
                                         Url = document.Url
                                     }).ToList()

                    };
        var applications = await query.ToListAsync();

        var mappedActivities = Mapper.Map<ListResult<GetAllApplicationInfo>>(applications);
        return mappedActivities;
    }

    public async Task<GetAllApplicationInfo> GetApplicationById(Guid applicationId)
    {
        var query = from application in _applicationRepository.GetAll()
                    where application.Id == applicationId && !application.IsDeleted
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
                        CreationTime = application.CreationTime,
                        Documents = (from applicationDocument in _applicationDocumentRepository.GetAll()
                                     join document in _documentRepository.GetAll() on applicationDocument.DocumentId equals document.Id
                                     where applicationDocument.ApplicationId == application.Id
                                     select new GetAllDocumentInfo
                                     {
                                         Id = document.Id,
                                         Name=document.Name,
                                         ContentType=document.ContentType,
                                         Url = document.Url
                                     }).ToList()

                    };

        var applicationInfo = await query.FirstOrDefaultAsync();

        if (applicationInfo == null)
        {
            throw new ApiException("Application was not found !");
        }
        return applicationInfo;
    }
    public async Task<GetApplicationStatusRatio> GetApplicationStatusRatio()
    {
        var query = _applicationRepository.GetAll().Where(application => !application.IsDeleted);

        var pendingCount = query.Where(application => application.Status ==ApplicationStatus.Pending).Count();
        var acceptedCount = query.Where(application => application.Status ==ApplicationStatus.Accepted).Count();
        var rejectedCount = query.Where(application => application.Status ==ApplicationStatus.Rejected).Count();

        var result = new GetApplicationStatusRatio
        {
            Pending = pendingCount,
            Accepted = acceptedCount,
            Rejected = rejectedCount

        };
        return result;

    }

    public async Task<ApplicationCreateOutput> CreateAndGetApplicationId(CreateApplicationInput input)
    {
        var newApplication = Mapper.Map<Application>(input);

        var createdApplicationId = await _applicationRepository.InsertAndGetIdAsync(newApplication);

        var newdocuments = Mapper.Map<List<Document>>(input.Documents);

        foreach (var newDocument in newdocuments)
        {
            await _applicationDocumentRepository.InsertAsync(new ApplicationDocument
            {

                ApplicationId = newApplication.Id,
                DocumentId = newDocument.Id,
            });

        }

        return new ApplicationCreateOutput { Id = createdApplicationId };

    }

    public async Task UpdateApplicationStatus(UpdateApplicationStatusInput input)
    {
        Application applicationToUpdate = await _applicationRepository.FirstOrDefaultAsync(x => x.Id == input.Id) ?? throw new ApiException("Application was not found !");

        applicationToUpdate.Status = input.Status;
        applicationToUpdate.Response = input.Response;

        await _applicationRepository.UpdateAsync(applicationToUpdate);
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
