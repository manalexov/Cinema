namespace Cinema.Domain.Entities
{
    public class Seat
    {
        public Guid Id { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public Guid HallId { get; set; }
        public Hall Hall { get; set; }
        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; }
    }
}
