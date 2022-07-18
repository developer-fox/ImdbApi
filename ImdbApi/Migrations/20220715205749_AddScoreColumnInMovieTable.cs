using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImdbApi.Migrations
{
    public partial class AddScoreColumnInMovieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Score",
                table: "Movie",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Movie");
        }
    }
}
