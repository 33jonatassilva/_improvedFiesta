using EasyManage.Enums;

namespace EasyManage.Entities;

public class Employee
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime OnboardingDate { get; set; } = DateTime.Today;
    public DateTime OffboardingDate { get; set; }
    public DateTime BirthDate { get; set; }
    public double Salary { get; set; }
    public EmployeeLevel EmployeeLevel { get; set; }
}