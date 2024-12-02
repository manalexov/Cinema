using Cinema.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persistence.Configurations
{
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Column).IsRequired();
            builder.Property(f => f.Row).IsRequired();
            builder.HasOne(f => f.Ticket).WithMany(f => f.Seats).HasForeignKey(f => f.TicketId);
            builder.HasOne(f => f.Hall).WithMany(f => f.Seats).HasForeignKey(f => f.HallId);
        }
    }
}
