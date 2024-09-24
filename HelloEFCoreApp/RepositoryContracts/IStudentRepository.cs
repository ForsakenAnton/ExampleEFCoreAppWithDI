using HelloEFCoreApp.Data.Entities;

namespace HelloEFCoreApp.RepositoryContracts;

public interface IStudentRepository
{
    Task<IEnumerable<Student>> GetAllStudentsAsync(bool trackChanges);
    Task<IEnumerable<Student>> GetAllStudentsByConditionAsync(bool trackChanges, string search);
}
