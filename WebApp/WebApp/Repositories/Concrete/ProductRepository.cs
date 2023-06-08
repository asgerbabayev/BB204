using JwtExample.Data.DataAccess;
using JwtExample.Data.Entities;
using WebApp.Repositories.Abstract;

namespace WebApp.Repositories.Concrete;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context) { }
}
