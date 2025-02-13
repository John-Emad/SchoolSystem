using SchoolSystem.Domain;

namespace SchoolSystem.Service.Interfaces
{
    public interface IStudentService
    {
        public Task<List<Student>> GetAllStudentsAsynch();
    }
}
