namespace WebApp.Repositories.Abstract;

public interface IUnitOfWork
{
    public IProfessionRepository ProffessionRepository { get; }
    public IDepartmentRepository DepartmentRepository { get; }
    public IEmployeeRepository EmployeeRepository { get; }
    Task SaveChangesAsync();
}
