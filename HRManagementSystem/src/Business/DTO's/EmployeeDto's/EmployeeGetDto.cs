using HRManagementSystem.Data.Entities;

namespace HRManagementSystem.Business.DTO_s.EmployeeDto_s;

public class EmployeeGetDto
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public double Salary { get; set; }
    public Profession Profession { get; set; } = null!;
    public Department Department { get; set; } = null!;
}
