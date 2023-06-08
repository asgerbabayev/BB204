using JwtExample.Data.DataAccess;
using WebApp.Repositories.Abstract;

namespace WebApp.Repositories.Concrete;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    private IProductRepository _productRepository;
    public IProductRepository ProductRepository => _productRepository ??= new ProductRepository(_context);
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
