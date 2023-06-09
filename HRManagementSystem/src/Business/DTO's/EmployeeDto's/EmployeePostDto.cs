namespace HRManagementSystem.Business.DTO_s.EmployeeDto_s;

public class EmployeePostDto
{
    public string FullName { get; set; } = null!;
    public double Salary { get; set; }
    public int ProfessionId { get; set; }
    public int DepartmentId { get; set; }
}
