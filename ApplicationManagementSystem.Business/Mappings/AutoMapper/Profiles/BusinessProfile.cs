using ApplicationManagementSystem.Core.DbModels;
using ApplicationManagementSystem.Core.ViewModels.ApplicationDocumentVM;
using ApplicationManagementSystem.Core.ViewModels.ApplicationVM;
using ApplicationManagementSystem.Core.ViewModels.DocumentVM;
using ApplicationManagementSystem.Core.ViewModels.UserVM;
using AutoMapper;

namespace ApplicationManagementSystem.Business.Mappings.AutoMapper.Profiles
{
    public class BusinessProfile : Profile
    {
        public BusinessProfile()
        {
            //ReverseMap çift yonlüdönüşümü sağlar.
            //Veritabanına ismen karsılık gelmeyen member için custom ayar yapıldı.
            //CreateMap<User, GetAllUserInfo>().ForMember(k => k.SurnSdame, opt => opt.MapFrom(a => a.Surname)).ReverseMap();

            //User
            CreateMap<User, UserLoginOutput>().ReverseMap();

            //ApplicationDocument
            CreateMap<ApplicationDocument, CreateApplicationDocumentInput>().ReverseMap();

            //Application
            CreateMap<Application, CreateApplicationInput>().ReverseMap();
            CreateMap<Application, UpdateApplicationInput>().ReverseMap();
            CreateMap<Application, GetAllApplicationInfo>().ReverseMap();
            CreateMap<Application, UpdateApplicationStatusInput>().ReverseMap();

            // Document
            CreateMap<Document, GetAllDocumentInfo>().ReverseMap();


        }
    }
}
