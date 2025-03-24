using SchoolSystem.Domain;

namespace SchoolSystem.Service.Interfaces
{
    public interface IDepartmentService
    {
        Task<Department> AddDepartmentAsync(Department department);
        Task<List<Department>> GetAllDepartmentsAsync();
        Task<Department> GetDepartmentByIdAsync(int id);
    }
}
