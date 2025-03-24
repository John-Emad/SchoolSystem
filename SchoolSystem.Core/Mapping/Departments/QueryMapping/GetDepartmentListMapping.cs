using SchoolSystem.Domain;
using SchoolSystem.Domain.DTOs;

namespace SchoolSystem.Core.Mapping.Departments
{
    public partial class DepartmentProfileMapping
    {
        public void GetDepartmentListMapping()
        {
            // Source -> Destination
            CreateMap<Department, DepartmentReadDto>();
        }
    }
}
