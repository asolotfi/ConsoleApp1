using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Configuration
{
    public class TerritoryConfig : IEntityTypeConfiguration<Territory>
    {
        public void Configure(EntityTypeBuilder<Territory> builder)
        {
            builder.HasMany(T => T.employees)
                .WithMany(E => E.territories);          
        }
    }
}
