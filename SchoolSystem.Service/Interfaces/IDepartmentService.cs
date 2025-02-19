using SchoolSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Service.Interfaces
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetAllDepartmentsAsynch();
        Task<Department?> GetDepartmentByID(int id);
        Task<Department?> AddDepartmentAsynch(Department department);
    }
}
