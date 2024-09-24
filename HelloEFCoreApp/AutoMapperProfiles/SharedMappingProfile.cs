using AutoMapper;
using HelloEFCoreApp.Data.Entities;
using HelloEFCoreApp.Dto;

namespace HelloEFCoreApp.AutoMapperProfiles;

public class SharedMappingProfile : Profile
{
    public SharedMappingProfile()
    {
        CreateMap<Student, StudentDto>().ReverseMap();
    }
}
