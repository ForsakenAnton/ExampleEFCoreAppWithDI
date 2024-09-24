using HelloEFCoreApp.Data;
using HelloEFCoreApp.Data.Entities;
using HelloEFCoreApp.RepositoryContracts;

namespace HelloEFCoreApp.Repositories;

public class CourceRepository : RepositoryBase<Course>, ICourceRepository
{

    public CourceRepository(ApplicationDbContext context) : base(context)
    {
    }
}
