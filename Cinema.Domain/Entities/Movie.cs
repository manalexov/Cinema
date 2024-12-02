namespace Cinema.Domain.Entities
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration {  get; set; }
        public byte[]? Image { get; set; }
        public List<Hall> Halls { get; set; }
        public List<Session> Sessions { get; set; }
    }
}
