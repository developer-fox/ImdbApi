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
                    Like = 3
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 1",
                    Description = "Movie 1 Descriptions",
                    Score = 9,
                    CreatedDate = DateTime.Now,
                    ReleaseDate = new DateTime(2019, 12, 25),
                    Like =15
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 2",
                    Description = "Movie 2 Descriptions",
                    Score = 8,
                    CreatedDate = DateTime.Now,
                    ReleaseDate = new DateTime(2019, 12, 25),
                    Like =20
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 3",
                    Description = "Movie 3 Descriptions",
                    Score = 7,
                    CreatedDate = DateTime.Now,
                    ReleaseDate = new DateTime(2019, 12, 25),
                    Like = 30
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 4",
                    Description = "Movie 4 Descriptions",
                    Score = 10,
                    CreatedDate = DateTime.Now,
                    ReleaseDate = new DateTime(2019, 12, 25),
                    Like = 40
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 5",
                    Description = "Movie 5 Descriptions",
                    Score = 6,
                    CreatedDate = DateTime.Now,
                    ReleaseDate = new DateTime(2019, 12, 25),
                    Like = 60
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 4",
                    Description = "Movie 6 Descriptions",
                    Score = 4,
                    CreatedDate = DateTime.Now,
                    ReleaseDate = new DateTime(2019, 12, 25),
                    Like = 150
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 3",
                    Description = "Movie 6 Descriptions",
                    Score = 3,
                    CreatedDate = DateTime.Now,
                    ReleaseDate = new DateTime(2019, 12, 25),
                    Like = 160
                },
                new Movie
                {
                    Id = Guid.NewGuid(),
                    Name = "Movie 2",
                    Description = "Movie 6 Descriptions",
                    Score = 3,
                    CreatedDate = DateTime.Now,
                    ReleaseDate = new DateTime(2019, 12, 25),
                    Like = 100
                }
                );

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
