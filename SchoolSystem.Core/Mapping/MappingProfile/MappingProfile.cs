using AutoMapper;
using SchoolSystem.Domain;
using SchoolSystem.Domain.DTOs;

namespace SchoolSystem.Core.Mapping.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Source -> Destination
            #region Student Maps
            CreateMap<Student, StudentReadDto>()
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department.DName));

            CreateMap<StudentWriteDto, Student>();
            #endregion

            #region Department Maps
            CreateMap<Department, DepartmentReadDto>();
            CreateMap<DepartmentWriteDto, Department>();
            #endregion
        }
    }
}
