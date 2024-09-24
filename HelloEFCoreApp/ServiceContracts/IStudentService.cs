using HelloEFCoreApp.Data.Entities;
using HelloEFCoreApp.Dto;

namespace HelloEFCoreApp.ServiceContracts;

public interface IStudentService
{
    Task<IEnumerable<StudentDto>> GetAllStudentsAsync(bool trackChanges);
    Task<IEnumerable<StudentDto>> GetAllStudentsByConditionAsync(bool trackChanges, string search);
}
