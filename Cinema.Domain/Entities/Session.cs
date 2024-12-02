namespace Cinema.Domain.Entities
{
    public class Session
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public List<Hall> Halls { get; set; }
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
