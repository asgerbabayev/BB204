using HRManagementSystem.DataAccess.Repositories.Concrete;

namespace WebApp.Repositories.Concrete;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    private IDepartmentRepository _departmentRepository;
    private IEmployeeRepository _employeeRepository;
    private IProfessionRepository _professionRepository;
    public IDepartmentRepository DepartmentRepository => _departmentRepository ??= new DepartmentRepository(_context);
    public IEmployeeRepository EmployeeRepository => _employeeRepository ??= new EmployeeRepository(_context);
    public IProfessionRepository ProffessionRepository => _professionRepository ??= new ProffessionRepository(_context);
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
