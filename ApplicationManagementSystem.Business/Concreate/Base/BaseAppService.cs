using ApplicationManagementSystem.Business.Mappings.AutoMapper;
using ApplicationManagementSystem.Business.Abstract;
using AutoMapper;

namespace ApplicationManagementSystem.Business.Concreate;

public abstract class BaseAppService : IBaseAppService
{
    public IMapper Mapper
    {
        get
        {
            return ObjectMapper.Mapper;
        }
    }
}