
using EasyManage.Enums;


namespace EasyManage.Models;

public class Employee : People
{
    public DateTime OnboardingDate { get; set; } = DateTime.Today;
    public DateTime OffboardingDate { get; set; }
    public double Salary { get; set; }
    public EEmployeeLevel EEmployeeLevel { get; set; }


    public override string ToString()
    {
        return $"\n\nName: {FirstName} {LastName}\n" +
               $"CPF: {Cpf}\n" +
               $"Birth Date: {BirthDate}\n" +
               $"Salary: R${Salary},00\n" +
               $"Onboarding Date: {OnboardingDate}\n" +
               $"Offboarding Date {OffboardingDate}\n";

    }
}