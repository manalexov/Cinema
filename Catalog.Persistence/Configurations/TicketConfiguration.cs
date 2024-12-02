using Cinema.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persistence.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Price).IsRequired();
            builder.HasMany(f => f.Seats).WithOne(f => f.Ticket).HasForeignKey(f => f.TicketId);
            builder.HasMany(f => f.Users).WithOne(f => f.Ticket).HasForeignKey(f => f.TicketId);
        }
    }
}
