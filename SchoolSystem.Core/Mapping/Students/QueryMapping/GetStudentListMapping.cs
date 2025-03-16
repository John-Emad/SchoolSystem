using SchoolSystem.Domain.DTOs;
using SchoolSystem.Domain;

namespace SchoolSystem.Core.Mapping.Students
{
    public partial class StudentProfileMapping
    {
        public void GetStudentListMapping()
        {
            // Source -> Destination
            CreateMap<Student, StudentReadDto>()
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department.DName));
        }
    }
}
