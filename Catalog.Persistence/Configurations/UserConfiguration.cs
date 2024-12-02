using Cinema.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Login).IsRequired();
            builder.Property(f => f.Password).IsRequired();
            builder.HasOne(f => f.Ticket).WithMany(f => f.Users).HasForeignKey(f => f.TicketId);
        }
    }
}
