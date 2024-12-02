namespace Cinema.Domain.Entities
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public List<Seat> Seats { get; set; }
        public List<User> Users { get; set; }
    }
}
