using ImdbApi.Entities;

namespace ImdbApi.Models
{
    public class CategoryListDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<MovieListDto> Movies { get; set; }
    }
}
