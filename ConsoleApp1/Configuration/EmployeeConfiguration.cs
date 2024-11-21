using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmployeeID);

            builder.Property(e => e.LastName)
                  .IsRequired()
                  .HasMaxLength(20);

            builder.Property(e => e.FirstName)
                  .IsRequired()
                  .HasMaxLength(10);

            builder.Property(e => e.Title)
                  .HasMaxLength(30);
        }
    }
}
