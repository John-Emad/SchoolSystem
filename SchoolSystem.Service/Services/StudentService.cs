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
        public async Task<Student?> AddStudentAsync(Student student)
        {
            // Implement Logic
            return await _studentRepository.AddAsync(student);
        }
        public async Task<List<Student>> GetAllStudentsAsync()
        {
            // Implement Logic
            return await _studentRepository.GetAllAsync();
        }
        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await _studentRepository.GetByIdAsync(id);
        }
        #endregion

    }
}
