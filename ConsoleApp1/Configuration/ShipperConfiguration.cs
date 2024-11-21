using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Configuration;


public class ShipperConfiguration : IEntityTypeConfiguration<Shipper>
{
    public void Configure(EntityTypeBuilder<Shipper> builder)
    {

        builder.HasKey(e => e.ShipperID);

        builder.Property(e => e.CompanyName)
                  .IsRequired()
                  .HasMaxLength(40);
    }
}

