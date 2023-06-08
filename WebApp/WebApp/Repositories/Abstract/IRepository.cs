using JwtExample.Data.Entities.Common;
using System.Linq.Expressions;

namespace WebApp.Repositories.Abstract;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression = null, params string[] includes);
    Task<List<TEntity>> GetAllPaginatedAsync(int pageIndex, int pageSize, Expression<Func<TEntity, bool>> expression = null, params string[] includes);
    Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression = null, params string[] includes);
    Task<bool> IsExist(Expression<Func<TEntity, bool>> expression);
    Task Create(TEntity entity);
    void Update(TEntity entity);
    void Remove(TEntity entity);
    Task SaveChangesAsync(CancellationToken cancellationToken);
}
