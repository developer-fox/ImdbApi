using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImdbApi.Migrations
{
    public partial class AddDefaultDataInDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
