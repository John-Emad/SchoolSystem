using AutoMapper;

namespace SchoolSystem.Core.Mapping.Departments
{
    public partial class DepartmentProfileMapping : Profile
    {
        public DepartmentProfileMapping()
        {
            GetDepartmentListMapping();
            AddDepartmentMapping();
        }
    }
}
