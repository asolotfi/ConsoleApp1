using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Configuration;


public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder
        .HasKey(s => s.SupplierID);
        builder.Property(e => e.CompanyName)
                  .IsRequired()
                  .HasMaxLength(40);
        builder.Property(e => e.ContactName)
                  .HasMaxLength(30);

        builder.Property(e => e.Address)
                  .HasMaxLength(60);

    }
}