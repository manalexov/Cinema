using Cinema.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persistence.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Name).IsRequired();
            builder.Property(f => f.Description).IsRequired();
            builder.Property(f => f.Duration).IsRequired();
            builder.HasMany(f => f.Halls).WithOne(f => f.Movie).HasForeignKey(f => f.MovieId);
        }
    }
}
