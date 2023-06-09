using HRManagementSystem.Data.Entities.Common;

namespace HRManagementSystem.Data.Entities;

public class Department : BaseEntity
{
    public string Name { get; set; } = null!;
    public ICollection<Employee> Employees { get; set; }
    public int? SupDepartmentId { get; set; }
    public Department? SupDepartment { get; set; }
    public ICollection<Department>? SubDepartments { get; set; }
    public Department()
    {
        Employees = new HashSet<Employee>();
        SubDepartments = new HashSet<Department>();
    }
}
