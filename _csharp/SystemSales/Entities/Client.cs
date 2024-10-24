namespace SystemSales.Entities;

public class Client
{
    public Guid Id = Guid.NewGuid();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly BirthDate { get; set; }
    public DateTime LastLogin { get; set; }
    public float Rate { get; set; }
    
    public string Email { get; set; }
    
    public string Phone { get; set; }
    
    public string Address { get; set; }
    
    public string City { get; set; }
    
    public string State { get; set; }
    
    


    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}, BirthDate: {BirthDate}, LastLogin: {LastLogin}, Rate: {Rate}";
    }
}