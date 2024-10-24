namespace SystemSales.Entities;

public class Employee
{
    public int Id { get; set; }
    public string FistName { get; set; }
    public string LastName { get; set; }
    public DateOnly BirthDate { get; set; }
    public DateTime OnboardingDate { get; set; }
    public DateTime OffboardingDate { get; set; }
    public DateTime LastLogin { get; set; }
    public DateTime LastSale{ get; set; }
    public double TotalInSales { get; set; }
    public float Rate { get; set; }
}