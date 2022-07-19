namespace ImdbApi.Entities
{
    public class Movie
    {
        public Movie()
        {
            Status = true; 
        }
        public Guid Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Certificate { get; set; }
        public string Description { get; set; }
        public double Score { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Like { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}
