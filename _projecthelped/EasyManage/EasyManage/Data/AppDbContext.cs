using EasyManage.Models;
using EasyManage.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EasyManage.Data;

public class AppDbContext : DbContext, IAppDbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleItems> SaleItems { get; set; }

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
         => optionsBuilder.UseSqlServer("Server=localhost;Database=EasyManage;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");
        
    
    
}