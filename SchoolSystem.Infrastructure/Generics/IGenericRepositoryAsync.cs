
using Microsoft.EntityFrameworkCore.Storage;

namespace SchoolSystem.Infrastructure.Generics
{
    public interface IGenericRepositoryAsync<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(ICollection<T> entities);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(ICollection<T> entities);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(object id);
        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(ICollection<T> entities);
        Task SaveChangesAsync();
        IDbContextTransaction BeginTransaction();
        void Commit();
        void RollBack();
        IQueryable<T> GetTableNoTracking();
        IQueryable<T> GetTableAsTracking();
    }
}
