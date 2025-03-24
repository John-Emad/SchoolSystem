using Microsoft.EntityFrameworkCore;
using SchoolSystem.Domain;
using SchoolSystem.Infrastructure.Data;
using SchoolSystem.Infrastructure.Generics;
using SchoolSystem.Infrastructure.Interfaces;

namespace SchoolSystem.Infrastructure.Repositories
{
    public class StudentRepository : GenericRepositoryAsync<Student>, IStudentRepository
    {
        #region Fields
        private readonly DbSet<Student> _studentsDbSet;
        #endregion

        #region Constructors
        public StudentRepository(SchoolSystemDbContext schoolSystemDbContext) : base(schoolSystemDbContext)
        {
            _studentsDbSet = schoolSystemDbContext.Set<Student>();
        }
        #endregion

        #region Methods
        override public async Task<List<Student>> GetAllAsync()
        {
            return await _studentsDbSet.Include(s => s.Department).ToListAsync();
        }

        #endregion

    }
}
