using Cinema.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persistence.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Date).IsRequired();
            builder.HasOne(f => f.Movie).WithMany(f => f.Sessions).HasForeignKey(f => f.MovieId);
            builder.HasMany(f => f.Halls).WithOne(f => f.Session).HasForeignKey(f => f.SessionId);
        }
    }
}
