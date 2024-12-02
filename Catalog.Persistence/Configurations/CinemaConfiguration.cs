using Cinema.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persistence.Configurations
{
    public class CinemaConfiguration : IEntityTypeConfiguration<CinemaEnityty>
    {
        public void Configure(EntityTypeBuilder<CinemaEnityty> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Name).IsRequired();
            builder.HasMany(f => f.Halls).WithOne(f => f.Cinema).HasForeignKey(f => f.CinemaId);
        }
    }
}
