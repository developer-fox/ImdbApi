using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImdbApi.Migrations
{
    public partial class AddLikeColumnInMovieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("38cd7009-0ce1-45d6-9738-f59b8dbd89e0"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("44871444-adca-4cc6-bbd5-872af479ced8"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("4aaed804-1768-4ac3-8bf5-cd323fa7617a"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("5e0cd383-3720-4590-9d2a-ac9af625c622"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("617ac8bb-baf9-4315-9084-2e2a4b6b3a5e"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("664c3a1a-8fc6-4aa7-a571-692bb4b106db"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("7a10e1c6-1290-468e-94e6-d2b1c4df2e3b"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("8040b6f5-2f3f-4e4c-af9b-4cbeff886b3f"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("e4542652-2191-40e9-86c1-77258b932e22"));

            migrationBuilder.AddColumn<int>(
                name: "Like",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "CreatedDate", "Description", "Like", "Name", "ReleaseDate", "Score", "Status" },
                values: new object[,]
                {
                    { new Guid("0ce1f813-63d9-4840-8735-3c49f4aa145a"), new DateTime(2022, 7, 16, 0, 13, 13, 623, DateTimeKind.Local).AddTicks(769), "Movie 1 Descriptions", 0, "Movie 1", "2019", 9.0, true },
                    { new Guid("13866839-4f8a-490d-a0c8-c90e385daeb2"), new DateTime(2022, 7, 16, 0, 13, 13, 623, DateTimeKind.Local).AddTicks(782), "Movie 2 Descriptions", 0, "Movie 2", "2019", 8.0, true },
                    { new Guid("4af5c42c-6e52-40f5-aac9-d4c0f1d01416"), new DateTime(2022, 7, 16, 0, 13, 13, 623, DateTimeKind.Local).AddTicks(786), "Movie 4 Descriptions", 0, "Movie 4", "2019", 10.0, true },
                    { new Guid("59065058-8b51-4d11-a4bc-b048dab87d8f"), new DateTime(2022, 7, 16, 0, 13, 13, 623, DateTimeKind.Local).AddTicks(789), "Movie 6 Descriptions", 0, "Movie 4", "2019", 4.0, true },
                    { new Guid("59887d97-299f-40d4-a65e-5f8efc24b99f"), new DateTime(2022, 7, 16, 0, 13, 13, 623, DateTimeKind.Local).AddTicks(780), "Movie 1 Descriptions", 0, "Movie 1", "2019", 9.0, true },
                    { new Guid("7edf8900-8be3-44b2-b73a-69bdb64f6778"), new DateTime(2022, 7, 16, 0, 13, 13, 623, DateTimeKind.Local).AddTicks(791), "Movie 6 Descriptions", 0, "Movie 3", "2019", 3.0, true },
                    { new Guid("b8d51c79-c92f-423d-9ccc-49983aed9a5f"), new DateTime(2022, 7, 16, 0, 13, 13, 623, DateTimeKind.Local).AddTicks(784), "Movie 3 Descriptions", 0, "Movie 3", "2019", 7.0, true },
                    { new Guid("dfb017f8-4e68-4e52-be28-10e2561773a2"), new DateTime(2022, 7, 16, 0, 13, 13, 623, DateTimeKind.Local).AddTicks(787), "Movie 5 Descriptions", 0, "Movie 5", "2019", 6.0, true },
                    { new Guid("f74d4114-99d4-42d5-bc13-1a9f0cf344a2"), new DateTime(2022, 7, 16, 0, 13, 13, 623, DateTimeKind.Local).AddTicks(795), "Movie 6 Descriptions", 0, "Movie 2", "2019", 3.0, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("0ce1f813-63d9-4840-8735-3c49f4aa145a"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("13866839-4f8a-490d-a0c8-c90e385daeb2"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("4af5c42c-6e52-40f5-aac9-d4c0f1d01416"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("59065058-8b51-4d11-a4bc-b048dab87d8f"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("59887d97-299f-40d4-a65e-5f8efc24b99f"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("7edf8900-8be3-44b2-b73a-69bdb64f6778"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("b8d51c79-c92f-423d-9ccc-49983aed9a5f"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("dfb017f8-4e68-4e52-be28-10e2561773a2"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("f74d4114-99d4-42d5-bc13-1a9f0cf344a2"));

            migrationBuilder.DropColumn(
                name: "Like",
                table: "Movie");

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "ReleaseDate", "Score", "Status" },
                values: new object[,]
                {
                    { new Guid("38cd7009-0ce1-45d6-9738-f59b8dbd89e0"), new DateTime(2022, 7, 16, 0, 9, 16, 602, DateTimeKind.Local).AddTicks(5597), "Movie 2 Descriptions", "Movie 2", "2019", 8.0, true },
                    { new Guid("44871444-adca-4cc6-bbd5-872af479ced8"), new DateTime(2022, 7, 16, 0, 9, 16, 602, DateTimeKind.Local).AddTicks(5595), "Movie 1 Descriptions", "Movie 1", "2019", 9.0, true },
                    { new Guid("4aaed804-1768-4ac3-8bf5-cd323fa7617a"), new DateTime(2022, 7, 16, 0, 9, 16, 602, DateTimeKind.Local).AddTicks(5609), "Movie 5 Descriptions", "Movie 5", "2019", 6.0, true },
                    { new Guid("5e0cd383-3720-4590-9d2a-ac9af625c622"), new DateTime(2022, 7, 16, 0, 9, 16, 602, DateTimeKind.Local).AddTicks(5599), "Movie 3 Descriptions", "Movie 3", "2019", 7.0, true },
                    { new Guid("617ac8bb-baf9-4315-9084-2e2a4b6b3a5e"), new DateTime(2022, 7, 16, 0, 9, 16, 602, DateTimeKind.Local).AddTicks(5611), "Movie 6 Descriptions", "Movie 4", "2019", 4.0, true },
                    { new Guid("664c3a1a-8fc6-4aa7-a571-692bb4b106db"), new DateTime(2022, 7, 16, 0, 9, 16, 602, DateTimeKind.Local).AddTicks(5614), "Movie 6 Descriptions", "Movie 2", "2019", 3.0, true },
                    { new Guid("7a10e1c6-1290-468e-94e6-d2b1c4df2e3b"), new DateTime(2022, 7, 16, 0, 9, 16, 602, DateTimeKind.Local).AddTicks(5586), "Movie 1 Descriptions", "Movie 1", "2019", 9.0, true },
                    { new Guid("8040b6f5-2f3f-4e4c-af9b-4cbeff886b3f"), new DateTime(2022, 7, 16, 0, 9, 16, 602, DateTimeKind.Local).AddTicks(5613), "Movie 6 Descriptions", "Movie 3", "2019", 3.0, true },
                    { new Guid("e4542652-2191-40e9-86c1-77258b932e22"), new DateTime(2022, 7, 16, 0, 9, 16, 602, DateTimeKind.Local).AddTicks(5607), "Movie 4 Descriptions", "Movie 4", "2019", 10.0, true }
                });
        }
    }
}
