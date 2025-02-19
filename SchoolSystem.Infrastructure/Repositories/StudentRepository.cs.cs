using Microsoft.EntityFrameworkCore;
using SchoolSystem.Domain;
using SchoolSystem.Infrastructure.Data;
using SchoolSystem.Infrastructure.Interfaces;

namespace SchoolSystem.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        #region Fields
        private readonly SchoolSystemDbContext _schoolSystemDbContext;
        #endregion

        #region Constructors
        public StudentRepository(SchoolSystemDbContext schoolSystemDbContext)
        {
            _schoolSystemDbContext = schoolSystemDbContext;
        }
        #endregion

        #region Methods
        public async Task<List<Student>> GetAllStudentsAsynch()
        {
            return await _schoolSystemDbContext.Students.Include(s => s.Department).ToListAsync();
        }

        public async Task<Student?> GetStudentByID(int id)
        {
            return await _schoolSystemDbContext.Students.FirstOrDefaultAsync(s => s.StudID == id);
        }

        public async Task<Student?> AddStudentAsynch(Student student)
        {
            var result = await _schoolSystemDbContext.Students.AddAsync(student);
            await _schoolSystemDbContext.SaveChangesAsync();
            return result.Entity;
        }
        #endregion

    }
}
