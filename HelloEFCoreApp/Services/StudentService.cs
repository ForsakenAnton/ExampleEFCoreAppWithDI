using AutoMapper;
using HelloEFCoreApp.Data;
using HelloEFCoreApp.Data.Entities;
using HelloEFCoreApp.Dto;
using HelloEFCoreApp.RepositoryContracts;
using HelloEFCoreApp.ServiceContracts;
using Microsoft.EntityFrameworkCore;

namespace HelloEFCoreApp.Services;

public class StudentService : IStudentService
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;

    public StudentService(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }

    public async Task<IEnumerable<StudentDto>> GetAllStudentsAsync(bool trackChanges)
    {
        var students = await _repositoryManager.StudentRepository
            .GetAllStudentsAsync(trackChanges);

        var studentDtos = _mapper.Map<IEnumerable<StudentDto>>(students);

        return studentDtos;
    }

    public async Task<IEnumerable<StudentDto>> GetAllStudentsByConditionAsync(bool trackChanges, string search)
    {
        var students = await _repositoryManager.StudentRepository
            .GetAllStudentsByConditionAsync(trackChanges, search);

        var studentDtos = _mapper.Map<IEnumerable<StudentDto>>(students);

        return studentDtos;
    }
}
