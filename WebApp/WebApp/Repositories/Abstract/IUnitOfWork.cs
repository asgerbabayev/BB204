namespace WebApp.Repositories.Abstract;

public interface IUnitOfWork
{
    IProductRepository ProductRepository { get; }
    Task SaveChangesAsync();
}
