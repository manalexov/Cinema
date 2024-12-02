namespace Cinema.Domain.Entities
{
    public class CinemaEnityty
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Hall> Halls { get; set; } = new List<Hall>();
    }
}
