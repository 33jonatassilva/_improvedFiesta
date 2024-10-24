using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.Data;

public class AppDbContext : DbContext
{
    public DbSet<TodoModel> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost;Database=Test;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");
}