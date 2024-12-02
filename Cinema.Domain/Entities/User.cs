namespace Cinema.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Guid TicketId { get; set; }
        public Ticket Ticket { get; set; }
    }
}
