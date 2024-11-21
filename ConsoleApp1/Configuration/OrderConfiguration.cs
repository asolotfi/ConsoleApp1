using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(e => e.OrderID);

            builder.Property(e => e.OrderDate)
                  .HasColumnType("datetime");

            builder.HasOne(o => o.Customer)
                  .WithMany(c => c.orders)
                  .HasForeignKey(o => o.CustomerID)
                  .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(o => o.Employee)
                  .WithMany(e => e.orders)
                  .HasForeignKey(d => d.EmployeeID)
                  .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(o => o.Shipper)
                  .WithMany(s => s.orders)
                  .HasForeignKey(o => o.ShipVia)
                  .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
