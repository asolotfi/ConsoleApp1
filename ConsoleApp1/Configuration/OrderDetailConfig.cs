using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Configuration
{

    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(e => new { e.OrderID, e.ProductID });

            builder.Property(e => e.UnitPrice)
                  .HasColumnType("decimal(18, 2)");

            builder.HasOne(od => od.Order)
                  .WithMany(o => o.OrderDetails)
                  .HasForeignKey(od => od.OrderID)
                  .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(od => od.Product)
                  .WithMany(p => p.OrderDetails)
                  .HasForeignKey(od => od.ProductID)
                  .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
