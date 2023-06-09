namespace HRManagementSystem.DataAccess.Repositories.Concrete;

public class DepartmentRepository : Repository<Department>, IDepartmentRepository
{
    public DepartmentRepository(AppDbContext context) : base(context)
    {
    }
}
