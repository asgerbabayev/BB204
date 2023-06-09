using HRManagementSystem.Data.Entities.Common;

namespace HRManagementSystem.Data.Entities;

public class Profession : BaseEntity
{
    public string Name { get; set; } = null!;
    public ICollection<Employee> Employees { get; set; }
    public Profession()
    {
        Employees = new HashSet<Employee>();
    }
}
