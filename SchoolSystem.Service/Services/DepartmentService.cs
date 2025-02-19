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

        public async Task<Department?> AddDepartmentAsynch(Department department)
        {
            // Implement Logic
            return await _departmentRepository.AddDepartmentAsynch(department);
        }

        public async Task<List<Department>> GetAllDepartmentsAsynch()
        {
            // Implement Logic
            return await _departmentRepository.GetAllDepartmentsAsynch();
        }

        public Task<Department?> GetDepartmentByID(int id)
        {
            // Implement Logic
            throw new NotImplementedException();
        }
        #endregion
    }
}
