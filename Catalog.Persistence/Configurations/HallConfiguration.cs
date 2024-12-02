using Cinema.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persistence.Configurations
{
    public class HallConfiguration : IEntityTypeConfiguration<Hall>
    {
        public void Configure(EntityTypeBuilder<Hall> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Name).IsRequired();
            builder.HasOne(f => f.Movie).WithMany(f => f.Halls).HasForeignKey(f => f.MovieId);
            builder.HasOne(f => f.Cinema).WithMany(f => f.Halls).HasForeignKey(f => f.CinemaId);
            builder.HasOne(f => f.Session).WithMany(f => f.Halls).HasForeignKey(f => f.SessionId);
            builder.HasMany(f => f.Seats).WithOne(f => f.Hall).HasForeignKey(h => h.HallId);
        }
    }
}
