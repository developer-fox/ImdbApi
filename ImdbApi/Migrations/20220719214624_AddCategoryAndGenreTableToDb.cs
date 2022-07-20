using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImdbApi.Migrations
{
    public partial class AddCategoryAndGenreTableToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("50e53d1a-a136-4722-970b-0ff13f764605"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("5abb4135-9fd3-4d73-9ca3-0dc5911ca299"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("81d3a760-38de-46f5-aa55-5d2b829e86e2"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("848d967a-3c9e-45af-a7ad-8cefc2ee6d82"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("85bc62a5-2346-4722-9f31-6c17e0f962a8"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("a737ccf6-860f-4981-91e0-8e93e9d8af17"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("e9d4e692-7555-4ef6-bed7-b81174c40a0b"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("f5902d5e-0840-4db8-bf70-aa617532e774"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("f8607203-6b8f-4ff5-b94c-7d4dba390c40"));

            migrationBuilder.AddColumn<Guid>(
                name: "GenreId",
                table: "Movie",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryMovie",
                columns: table => new
                {
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MoviesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMovie", x => new { x.CategoriesId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_CategoryMovie_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryMovie_Movie_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_GenreId",
                table: "Movie",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryMovie_MoviesId",
                table: "CategoryMovie",
                column: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Genres_GenreId",
                table: "Movie",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Genres_GenreId",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "CategoryMovie");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Movie_GenreId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Movie");

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Certificate", "CreatedDate", "Description", "ImageUrl", "Like", "Name", "ReleaseDate", "Score", "Status" },
                values: new object[,]
                {
                    { new Guid("50e53d1a-a136-4722-970b-0ff13f764605"), "7+", new DateTime(2022, 7, 18, 12, 59, 43, 32, DateTimeKind.Local).AddTicks(6680), "Movie 5 Descriptions", "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg", 60, "Movie 5", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, true },
                    { new Guid("5abb4135-9fd3-4d73-9ca3-0dc5911ca299"), "7+", new DateTime(2022, 7, 18, 12, 59, 43, 32, DateTimeKind.Local).AddTicks(6682), "Movie 6 Descriptions", "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg", 150, "Movie 4", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, true },
                    { new Guid("81d3a760-38de-46f5-aa55-5d2b829e86e2"), "13+", new DateTime(2022, 7, 18, 12, 59, 43, 32, DateTimeKind.Local).AddTicks(6674), "Movie 2 Descriptions", "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg", 20, "Movie 2", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0, true },
                    { new Guid("848d967a-3c9e-45af-a7ad-8cefc2ee6d82"), "13+", new DateTime(2022, 7, 18, 12, 59, 43, 32, DateTimeKind.Local).AddTicks(6676), "Movie 3 Descriptions", "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg", 30, "Movie 3", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, true },
                    { new Guid("85bc62a5-2346-4722-9f31-6c17e0f962a8"), "18+", new DateTime(2022, 7, 18, 12, 59, 43, 32, DateTimeKind.Local).AddTicks(6678), "Movie 4 Descriptions", "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg", 40, "Movie 4", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, true },
                    { new Guid("a737ccf6-860f-4981-91e0-8e93e9d8af17"), "12+", new DateTime(2022, 7, 18, 12, 59, 43, 32, DateTimeKind.Local).AddTicks(6671), "Movie 1 Descriptions", "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg", 15, "Movie 1", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0, true },
                    { new Guid("e9d4e692-7555-4ef6-bed7-b81174c40a0b"), "18+", new DateTime(2022, 7, 18, 12, 59, 43, 32, DateTimeKind.Local).AddTicks(6697), "Movie 6 Descriptions", "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg", 160, "Movie 3", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, true },
                    { new Guid("f5902d5e-0840-4db8-bf70-aa617532e774"), "13+", new DateTime(2022, 7, 18, 12, 59, 43, 32, DateTimeKind.Local).AddTicks(6699), "Movie 6 Descriptions", "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg", 100, "Movie 2", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, true },
                    { new Guid("f8607203-6b8f-4ff5-b94c-7d4dba390c40"), "13+", new DateTime(2022, 7, 18, 12, 59, 43, 32, DateTimeKind.Local).AddTicks(6657), "Movie 1 Descriptions", "https://m.media-amazon.com/images/M/MV5BMWEwNjhkYzYtNjgzYy00YTY2LThjYWYtYzViMGJkZTI4Y2MyXkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_FMjpg_UX1000_.jpg", 3, "Movie 1", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0, true }
                });
        }
    }
}
