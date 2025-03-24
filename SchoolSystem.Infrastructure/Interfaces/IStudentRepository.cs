using SchoolSystem.Domain;
using SchoolSystem.Infrastructure.Generics;

namespace SchoolSystem.Infrastructure.Interfaces
{
    public interface IStudentRepository : IGenericRepositoryAsync<Student>
    {
        public new Task<List<Student>> GetAllAsync();
    }
}
