using Microsoft.EntityFrameworkCore;
using MyFirstAPI.Model;

namespace MyFirstAPI.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlServer("Server=localhost;Database=Teste;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");
    }
}
