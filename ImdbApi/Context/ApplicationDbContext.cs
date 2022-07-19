using ImdbApi.Entities;
using ImdbApi.Entities.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ImdbApi.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new MovieConfiguration());

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 1",
                    Description = "Movie 1 Descriptions",
                    Score = 9,
                    CreatedDate = DateTime.Now,
                    ReleaseDate = new DateTime(2019,12,25),
                    Certificate = "13+",
                    Like = 3,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg"
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 1",
                    Description = "Movie 1 Descriptions",
                    Score = 9,
                    CreatedDate = DateTime.Now,
                    ReleaseDate = new DateTime(2019, 12, 25),
                    Certificate = "12+",
                    Like = 15,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg"
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 2",
                    Description = "Movie 2 Descriptions",
                    Score = 8,
                    CreatedDate = DateTime.Now,
                    ReleaseDate = new DateTime(2019, 12, 25),
                    Certificate = "13+",
                    Like = 20,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg"
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 3",
                    Description = "Movie 3 Descriptions",
                    Score = 7,
                    CreatedDate = DateTime.Now,
                    ReleaseDate = new DateTime(2019, 12, 25),
                    Certificate = "13+",
                    Like = 30,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg"
                    
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 4",
                    Description = "Movie 4 Descriptions",
                    Score = 10,
                    CreatedDate = DateTime.Now,
                    ReleaseDate = new DateTime(2019, 12, 25),
                    Certificate = "18+",
                    Like = 40,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg"
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 5",
                    Description = "Movie 5 Descriptions",
                    Score = 6,
                    CreatedDate = DateTime.Now,
                    Certificate = "7+",
                    ReleaseDate = new DateTime(2019, 12, 25),
                    Like = 60,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg"
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 4",
                    Description = "Movie 6 Descriptions",
                    Score = 4,
                    Certificate = "7+",
                    CreatedDate = DateTime.Now,
                    ReleaseDate = new DateTime(2019, 12, 25),
                    Like = 150,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg"
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 3",
                    Description = "Movie 6 Descriptions",
                    Score = 3,
                    Certificate = "18+",
                    CreatedDate = DateTime.Now,
                    ReleaseDate = new DateTime(2019, 12, 25),
                    Like = 160,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg"
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 2",
                    Description = "Movie 6 Descriptions",
                    Score = 3,
                    CreatedDate = DateTime.Now,
                    Certificate = "13+",
                    ReleaseDate = new DateTime(2019, 12, 25),
                    Like = 100,
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg"

                }
                );

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
