using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Configuration
{
    public class CustomerConfig : IEntityTypeConfiguration<Customerr>
    {
        public void Configure(EntityTypeBuilder<Customerr> builder)
        {
            builder.HasMany(P => P.orders)
                .WithOne(O => O.Customer)
                .HasForeignKey(O => O.CustomerID)
                .OnDelete(DeleteBehavior.NoAction);
                
        }
    }
}
