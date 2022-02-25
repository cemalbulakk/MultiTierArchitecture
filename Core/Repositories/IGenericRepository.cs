using System.Linq.Expressions;

namespace Core.Repositories;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetByIdAsync(string id);
    IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
    IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate);
    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
    Task AddAsync(T entity);
    Task AddRangeAsync(IEnumerable<T> entities);
    void Update(T entity);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entity);
}