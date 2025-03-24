using AutoMapper;

namespace SchoolSystem.Core.Mapping.Students
{
    public partial class StudentProfileMapping : Profile
    {
        public StudentProfileMapping()
        {
            GetStudentListMapping();
            AddStudentMapping();
        }
    }
}
