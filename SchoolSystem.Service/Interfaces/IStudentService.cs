using SchoolSystem.Domain;

namespace SchoolSystem.Service.Interfaces
{
    public interface IStudentService
    {
        public Task<Student?> AddStudentAsync(Student student);
        public Task<Student> GetStudentByIdAsync(int id);
        public Task<IEnumerable<Student>> GetAllStudentsAsync();
    }
}
