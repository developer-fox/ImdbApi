using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImdbApi.Migrations
{
    public partial class AddLikeColumnDataInDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "CreatedDate", "Description", "Like", "Name", "ReleaseDate", "Score", "Status" },
                values: new object[,]
                {
                    { new Guid("184ce48a-2e09-42c6-b1f1-8e3dd1d07a31"), new DateTime(2022, 7, 16, 0, 16, 24, 270, DateTimeKind.Local).AddTicks(6600), "Movie 4 Descriptions", 40, "Movie 4", "2019", 10.0, true },
                    { new Guid("67611fc5-a2e5-4612-84c8-c485d6e247c8"), new DateTime(2022, 7, 16, 0, 16, 24, 270, DateTimeKind.Local).AddTicks(6598), "Movie 3 Descriptions", 30, "Movie 3", "2019", 7.0, true },
                    { new Guid("71e5f31f-a11f-4b6b-b903-5adc6cdcddaf"), new DateTime(2022, 7, 16, 0, 16, 24, 270, DateTimeKind.Local).AddTicks(6583), "Movie 1 Descriptions", 3, "Movie 1", "2019", 9.0, true },
                    { new Guid("841b8d7d-738e-4781-9b9e-23496774941d"), new DateTime(2022, 7, 16, 0, 16, 24, 270, DateTimeKind.Local).AddTicks(6605), "Movie 6 Descriptions", 160, "Movie 3", "2019", 3.0, true },
                    { new Guid("a8446b8b-e9c2-4b65-b284-6b5b870c5e95"), new DateTime(2022, 7, 16, 0, 16, 24, 270, DateTimeKind.Local).AddTicks(6609), "Movie 6 Descriptions", 100, "Movie 2", "2019", 3.0, true },
                    { new Guid("b317fe62-db4c-41a3-8f03-26c59163d0e1"), new DateTime(2022, 7, 16, 0, 16, 24, 270, DateTimeKind.Local).AddTicks(6595), "Movie 1 Descriptions", 15, "Movie 1", "2019", 9.0, true },
                    { new Guid("ccb360e8-d5f1-4334-ba89-e652dab2634e"), new DateTime(2022, 7, 16, 0, 16, 24, 270, DateTimeKind.Local).AddTicks(6602), "Movie 5 Descriptions", 60, "Movie 5", "2019", 6.0, true },
                    { new Guid("d2daff69-9403-42d6-b9f8-ffc8944ddd8f"), new DateTime(2022, 7, 16, 0, 16, 24, 270, DateTimeKind.Local).AddTicks(6597), "Movie 2 Descriptions", 20, "Movie 2", "2019", 8.0, true },
                    { new Guid("d806e889-0039-40b6-88ac-fe80e65de3dd"), new DateTime(2022, 7, 16, 0, 16, 24, 270, DateTimeKind.Local).AddTicks(6603), "Movie 6 Descriptions", 150, "Movie 4", "2019", 4.0, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("184ce48a-2e09-42c6-b1f1-8e3dd1d07a31"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("67611fc5-a2e5-4612-84c8-c485d6e247c8"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("71e5f31f-a11f-4b6b-b903-5adc6cdcddaf"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("841b8d7d-738e-4781-9b9e-23496774941d"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("a8446b8b-e9c2-4b65-b284-6b5b870c5e95"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("b317fe62-db4c-41a3-8f03-26c59163d0e1"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("ccb360e8-d5f1-4334-ba89-e652dab2634e"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("d2daff69-9403-42d6-b9f8-ffc8944ddd8f"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("d806e889-0039-40b6-88ac-fe80e65de3dd"));

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
    }
}
