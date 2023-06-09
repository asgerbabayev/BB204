namespace WebApp.Repositories.Concrete;

public class Repository<TEntity> : IRepository<TEntity>
    where TEntity : BaseEntity
{
    private readonly AppDbContext _context;
    public Repository(AppDbContext context)
    {
        _context = context;
    }
    public async Task Create(TEntity product)
    {
        await _context.Set<TEntity>().AddAsync(product);
    }

    public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression = null, params string[] includes)
    {
        IQueryable<TEntity> query = GetQuery();
        return expression is null
            ? await query.ToListAsync()
            : await query.Where(expression).ToListAsync();
    }

    public async Task<List<TEntity>> GetAllPaginatedAsync(int pageIndex, int pageSize, Expression<Func<TEntity, bool>> expression = null, params string[] includes)
    {
        IQueryable<TEntity> query = GetQuery();
        return expression is null
            ? await query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync()
            : await query.Where(expression).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
    }

    public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> expression = null, params string[] includes)
    {
        IQueryable<TEntity> query = GetQuery();
        return expression is null
            ? await query.FirstOrDefaultAsync()
            : await query.FirstOrDefaultAsync(expression);
    }

    public async Task<bool> IsExist(Expression<Func<TEntity, bool>> expression)
    {
        return await _context.Set<TEntity>().AnyAsync(expression);
    }

    public void Remove(TEntity product)
    {
        _context.Set<TEntity>().Remove(product);
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }

    public void Update(TEntity product)
    {
        _context.Set<TEntity>().Update(product);
    }

    private IQueryable<TEntity> GetQuery(params string[] includes)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>();
        if (includes != null)
            includes.Select(include => query.Include(include));
        return query;
    }
}
