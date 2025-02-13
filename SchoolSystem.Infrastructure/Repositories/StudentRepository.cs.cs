using Microsoft.EntityFrameworkCore;
using SchoolSystem.Domain;
using SchoolSystem.Infrastructure.Data;
using SchoolSystem.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return await _schoolSystemDbContext.Students.ToListAsync();
            }

            public async Task<Student?> GetStudentByID(int id)
            {
                return await _schoolSystemDbContext.Students.FirstOrDefaultAsync(s => s.StudID == id);
            }
        #endregion

    }
}
