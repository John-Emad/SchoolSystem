
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SchoolSystem.Infrastructure.Data;

namespace SchoolSystem.Infrastructure.Generics
{
    public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : class
    {
        #region Fields
        protected readonly SchoolSystemDbContext _schoolSystemDbContext;
        #endregion

        #region Constructors
        public GenericRepositoryAsync(SchoolSystemDbContext dbContext)
        {
            _schoolSystemDbContext = dbContext;
        }
        #endregion

        #region Methods

        #endregion

        #region Actions
        public virtual async Task<T> AddAsync(T entity)
        {
            await _schoolSystemDbContext.Set<T>().AddAsync(entity);
            await _schoolSystemDbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task AddRangeAsync(ICollection<T> entities)
        {
            await _schoolSystemDbContext.Set<T>().AddRangeAsync(entities);
            await _schoolSystemDbContext.SaveChangesAsync();
        }

        public virtual async Task<T> GetByIdAsync(object id)
        {
            return await _schoolSystemDbContext.Set<T>().FindAsync(id);
        }
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _schoolSystemDbContext.Set<T>().ToListAsync();
        }

        public virtual async Task UpdateAsync(T entity)
        {
            _schoolSystemDbContext.Set<T>().Update(entity);
            await _schoolSystemDbContext.SaveChangesAsync();
        }

        public async Task UpdateRangeAsync(ICollection<T> entities)
        {
            _schoolSystemDbContext.Set<T>().UpdateRange(entities);
            await _schoolSystemDbContext.SaveChangesAsync();
        }
        
        public virtual async Task DeleteAsync(T entity)
        {
            _schoolSystemDbContext.Set<T>().Remove(entity);
            await _schoolSystemDbContext.SaveChangesAsync();
        }

        public virtual async Task DeleteRangeAsync(ICollection<T> entities)
        {
            foreach (var entity in entities)
            {
                _schoolSystemDbContext.Entry(entity).State = EntityState.Deleted;
            }
            await _schoolSystemDbContext.SaveChangesAsync();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return _schoolSystemDbContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _schoolSystemDbContext.Database.CommitTransaction();
        }

        public void RollBack()
        {
            _schoolSystemDbContext.Database.RollbackTransaction();
        }

        public IQueryable<T> GetTableAsTracking()
        {
            return _schoolSystemDbContext.Set<T>().AsTracking().AsQueryable();
        }

        public IQueryable<T> GetTableNoTracking()
        {
            return _schoolSystemDbContext.Set<T>().AsNoTracking().AsQueryable();
        }

        public async Task SaveChangesAsync()
        {
            await _schoolSystemDbContext.SaveChangesAsync();
        }

        #endregion
    }
}
