using Blog.Core.Entities.Abstraction;
using System.Linq.Expressions;

namespace Blog.Data.Repositories.Abstractions
{
    public interface IRepository<T> where T : class, IEntityBase, new()
    {
        Task AddAsync(T entity);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties); // birden fazla T değeri dönecek
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties); // tek bir T değeri dönecek
        Task<T> GetByGuidAsync(Guid id);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity); // veriler silinmeyecek false değeri true olarak değişecek
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
    }

}
