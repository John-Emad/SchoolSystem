using SchoolSystem.Domain;
using SchoolSystem.Infrastructure.Interfaces;
using SchoolSystem.Service.Interfaces;

namespace SchoolSystem.Service.Services
{
    public class DepartmentService : IDepartmentService
    {
        #region Fields
        private readonly IDepartmentRepository _departmentRepository;
        #endregion

        #region Constructors
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        #endregion

        #region Methods
        public async Task<Department> AddDepartmentAsync(Department department)
        {
            return await _departmentRepository.AddAsync(department);
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            // Implement Logic
            return await _departmentRepository.GetAllAsync();
        }

        public Task<Department> GetDepartmentByIdAsync(int id)
        {
            return _departmentRepository.GetByIdAsync(id);
        }

        #endregion
    }
}
