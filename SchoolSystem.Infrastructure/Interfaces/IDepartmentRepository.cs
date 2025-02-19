using SchoolSystem.Domain;

namespace SchoolSystem.Infrastructure.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetAllDepartmentsAsynch();
        Task<Department?> GetDepartmentByID(int id);
        Task<Department?> AddDepartmentAsynch(Department department);
    }
}
