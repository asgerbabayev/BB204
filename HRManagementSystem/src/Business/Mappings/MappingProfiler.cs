using AutoMapper;
using HRManagementSystem.Business.DTO_s.EmployeeDto_s;
using HRManagementSystem.Data.Entities;

namespace HRManagementSystem.Business.Mappings;

public class MappingProfiler : Profile
{
    public MappingProfiler()
    {
        CreateMap<EmployeePostDto, Employee>();
        CreateMap<Employee, EmployeeGetDto>();
    }
}
