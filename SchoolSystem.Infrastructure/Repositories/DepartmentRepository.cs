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
    public class DepartmentRepository : IDepartmentRepository
    {
        #region Fields
        private readonly SchoolSystemDbContext _schoolSystemDbContext;
        #endregion

        #region Constructors
        public DepartmentRepository(SchoolSystemDbContext schoolSystemDbContext)
        {
            _schoolSystemDbContext = schoolSystemDbContext;
        }
        #endregion

        #region Methods
        public async Task<Department?> AddDepartmentAsynch(Department department)
        {
            var result = await  _schoolSystemDbContext.Departments.AddAsync(department);
            await _schoolSystemDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<List<Department>> GetAllDepartmentsAsynch()
        {
            return await _schoolSystemDbContext.Departments.Include(d => d.Students).ToListAsync();
        }

        public Task<Department?> GetDepartmentByID(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
