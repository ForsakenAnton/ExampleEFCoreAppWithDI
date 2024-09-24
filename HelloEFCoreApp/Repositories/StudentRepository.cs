using HelloEFCoreApp.Data;
using HelloEFCoreApp.Data.Entities;
using HelloEFCoreApp.RepositoryContracts;
using Microsoft.EntityFrameworkCore;

namespace HelloEFCoreApp.Repositories;

public class StudentRepository : RepositoryBase<Student>, IStudentRepository
{

    public StudentRepository(ApplicationDbContext context) : base(context)
    {
        
    }

    public async Task<IEnumerable<Student>> GetAllStudentsAsync(bool trackChanges)
    {
        //var students = await Context.Students.ToListAsync();
        var students = base.FindAll(trackChanges); 

        return await students.ToListAsync();
    }

    public async Task<IEnumerable<Student>> GetAllStudentsByConditionAsync(bool trackChanges, string search)
    {
        var students = base.FindByCondition(x => EF.Functions.Like(x.Name, $"%{search}%"), trackChanges);

        return await students.ToListAsync();
    }
}
