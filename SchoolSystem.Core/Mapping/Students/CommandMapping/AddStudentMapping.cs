using AutoMapper;
using SchoolSystem.Domain.DTOs;
using SchoolSystem.Domain;

namespace SchoolSystem.Core.Mapping.Students
{
    public partial class StudentProfileMapping
    {
        public void AddStudentMapping()
        {
            // Source -> Destination
            CreateMap<StudentWriteDto, Student>();
        }
    }
}
