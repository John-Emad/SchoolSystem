using SchoolSystem.Domain;
using SchoolSystem.Infrastructure.Generics;

namespace SchoolSystem.Infrastructure.Interfaces
{
    public interface IDepartmentRepository : IGenericRepositoryAsync<Department>
    {
        public new Task<List<Department>> GetAllAsync();
    }
}
