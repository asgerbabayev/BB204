using HRManagementSystem.Data.Entities.Common;

namespace HRManagementSystem.Data.Entities;

public class Employee : BaseEntity
{
    public string FullName { get; set; } = null!;
    public double Salary { get; set; }
    public Profession Profession { get; set; } = null!;
    public int ProfessionId { get; set; }
    public Department Department { get; set; } = null!;
    public int DepartmentId { get; set; }
}
