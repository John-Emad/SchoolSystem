using SchoolSystem.Domain;

namespace SchoolSystem.Infrastructure.Interfaces
{
    public interface IStudentRepository
    {
        public Task<List<Student>> GetAllStudentsAsynch();
        public Task<Student?> GetStudentByID(int id);
        public Task<Student?> AddStudentAsynch(Student student);
    }
}
