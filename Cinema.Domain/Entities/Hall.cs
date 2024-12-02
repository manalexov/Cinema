namespace Cinema.Domain.Entities
{
    public class Hall
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Seat> Seats { get; set; }
        public Guid CinemaId { get; set; }
        public CinemaEnityty Cinema { get; set; }
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
        public Guid SessionId { get; set; }
        public Session Session { get; set; }
    }
}
