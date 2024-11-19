using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Configuration
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = ASO\\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True; TrustServerCertificate = True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
