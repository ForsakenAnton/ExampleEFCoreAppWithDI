using AutoMapper;
using HelloEFCoreApp.Data;
using HelloEFCoreApp.RepositoryContracts;
using HelloEFCoreApp.ServiceContracts;

namespace HelloEFCoreApp.Services;

public class CourceService : ICourсeService
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;

    public CourceService(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }
}
