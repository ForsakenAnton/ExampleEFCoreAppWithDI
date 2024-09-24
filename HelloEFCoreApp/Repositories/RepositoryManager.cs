using HelloEFCoreApp.Data;
using HelloEFCoreApp.RepositoryContracts;

namespace HelloEFCoreApp.Repositories;

public class RepositoryManager : IRepositoryManager
{
    private readonly ApplicationDbContext _context;
    private readonly Lazy<IStudentRepository> _studentRepository;
    private readonly Lazy<ICourceRepository> _courceRepository;

    public RepositoryManager(ApplicationDbContext context)
    {
        _context = context;

        _studentRepository = new Lazy<IStudentRepository>(() =>
            new StudentRepository(_context));

        _courceRepository = new Lazy<ICourceRepository>(() =>
            new CourceRepository(_context));
    }

    public IStudentRepository StudentRepository => _studentRepository.Value;
    public ICourceRepository CourceRepository => _courceRepository.Value;

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}
