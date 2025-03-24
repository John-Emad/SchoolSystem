using Microsoft.EntityFrameworkCore;
using SchoolSystem.Domain;
using SchoolSystem.Infrastructure.Data;
using SchoolSystem.Infrastructure.Generics;
using SchoolSystem.Infrastructure.Interfaces;

namespace SchoolSystem.Infrastructure.Repositories
{
    public class DepartmentRepository : GenericRepositoryAsync<Department>, IDepartmentRepository
    {
        #region Fields
        private readonly DbSet<Department> _departmentDbSet;
        #endregion

        #region Constructors
        public DepartmentRepository(SchoolSystemDbContext schoolSystemDbContext):base(schoolSystemDbContext)
        {
            _departmentDbSet = schoolSystemDbContext.Set<Department>();
        }
        #endregion

        #region Methods

        override public async Task<List<Department>> GetAllAsync()
        {
            return await _departmentDbSet.Include(d => d.Students).ToListAsync();
        }

        #endregion
    }
}
