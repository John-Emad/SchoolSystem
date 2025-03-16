using SchoolSystem.Domain.DTOs;
using SchoolSystem.Domain;

namespace SchoolSystem.Core.Mapping.Departments
{
    public partial class DepartmentProfileMapping
    {
        public void AddDepartmentMapping()
        {
            // Source -> Destination
            CreateMap<DepartmentWriteDto, Department>();
        }
    }
}
