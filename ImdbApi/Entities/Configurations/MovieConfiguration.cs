using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImdbApi.Entities.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movie");

            builder.Property(e=>e.ImageUrl).IsRequired();

            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);

            builder.Property(e => e.Description).IsRequired().HasMaxLength(1000);
            
            builder.Property(e => e.Score).IsRequired();

            builder.Property(e => e.ReleaseDate).IsRequired();

            builder.Property(e => e.Status).IsRequired().HasDefaultValueSql("((1))");
        }
    }
}
