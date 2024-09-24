using AutoMapper;
using HelloEFCoreApp.Data;
using HelloEFCoreApp.RepositoryContracts;
using HelloEFCoreApp.ServiceContracts;

namespace HelloEFCoreApp.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IStudentService> _studentService;
    private readonly Lazy<ICourсeService> _courceService;

    public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _studentService = new Lazy<IStudentService>(() => new StudentService(repositoryManager, mapper));

        _courceService = new Lazy<ICourсeService>(() => new CourceService(repositoryManager, mapper));
    }

    public IStudentService StudentService => _studentService.Value;
    public ICourсeService CourсeService => _courceService.Value;
}
