using AutoMapper;

namespace ApplicationManagementSystem.Business.Abstract;

public interface IBaseAppService
{
    IMapper Mapper { get; }
}