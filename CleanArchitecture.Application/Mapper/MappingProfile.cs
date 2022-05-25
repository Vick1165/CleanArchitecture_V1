using AutoMapper;
using CleanArchitecture.Application.DTO;
using CleanArchitecture.Core.Entities;

namespace CleanArchitecture.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeResponseModel>()
                .ForMember(
                    a =>a.Id,
                    b =>b.MapFrom(c => c.EmployeeId))
                .ReverseMap();


            CreateMap<Employee, EmployeeRequestModel>().ForMember(
                   a => a.DepartmentId,
                   b => b.MapFrom(c => c.DepartmentId))
               .ReverseMap();

        }
    }
}