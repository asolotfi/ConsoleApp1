using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Configuration;


public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(e => e.ProductID);

        builder.Property(e => e.ProductName)
              .IsRequired()
              .HasMaxLength(40);

        builder.Property(e => e.UnitPrice)
              .HasColumnType("decimal(18, 2)");

        builder.HasOne(p => p.Supplier)
              .WithMany(s => s.Products)
              .HasForeignKey(p => p.SupplierID)
              .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(p => p.Category)
              .WithMany(c => c.Products)
              .HasForeignKey(p => p.CategoryID)
              .OnDelete(DeleteBehavior.SetNull);
    }
}


