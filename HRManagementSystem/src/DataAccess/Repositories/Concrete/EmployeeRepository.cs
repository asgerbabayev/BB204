namespace HRManagementSystem.DataAccess.Repositories.Concrete;

public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(AppDbContext context) : base(context)
    {
    }
}
