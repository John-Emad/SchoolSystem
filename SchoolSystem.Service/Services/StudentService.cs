using SchoolSystem.Domain;
using SchoolSystem.Infrastructure.Interfaces;
using SchoolSystem.Service.Interfaces;

namespace SchoolSystem.Service.Services
{
    public class StudentService : IStudentService
    {
        #region Fields
        private readonly IStudentRepository _studentRepository;
        #endregion

        #region Constructors
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        #endregion

        #region Methods
        public async Task<List<Student>> GetAllStudentsAsynch()
        {
            // Implement Logic
            return await _studentRepository.GetAllStudentsAsynch();
        }

        public async Task<Student?> AddStudentAsynch(Student student)
        {
            // Implement Logic
            return await _studentRepository.AddStudentAsynch(student);
        }
        #endregion

    }
}
