
using EasyManage.Enums;


namespace EasyManage.Models;

public class Employee : People
{
    public DateTime OnboardingDate { get; set; } = DateTime.Today;
    public DateTime OffboardingDate { get; set; }
    public double Salary { get; set; }
    public EEmployeeLevel EEmployeeLevel { get; set; }
}