using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImdbApi.Migrations
{
    public partial class AddReleaseColumnDataInDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "CreatedDate", "Description", "Like", "Name", "ReleaseDate", "Score", "Status" },
                values: new object[,]
                {
                    { new Guid("0ad87b1d-6ec2-4848-b33d-ac95e014695c"), new DateTime(2022, 7, 16, 0, 23, 35, 320, DateTimeKind.Local).AddTicks(4061), "Movie 6 Descriptions", 100, "Movie 2", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, true },
                    { new Guid("0c7fbf6b-d609-48f7-9fc4-9a0b6d16264a"), new DateTime(2022, 7, 16, 0, 23, 35, 320, DateTimeKind.Local).AddTicks(4020), "Movie 1 Descriptions", 3, "Movie 1", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0, true },
                    { new Guid("1f19365b-0ff9-4c73-9c4e-0b9d5db6a8b3"), new DateTime(2022, 7, 16, 0, 23, 35, 320, DateTimeKind.Local).AddTicks(4040), "Movie 3 Descriptions", 30, "Movie 3", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, true },
                    { new Guid("3158b220-40fc-4a88-8218-a081e06101b4"), new DateTime(2022, 7, 16, 0, 23, 35, 320, DateTimeKind.Local).AddTicks(4037), "Movie 2 Descriptions", 20, "Movie 2", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0, true },
                    { new Guid("40d945d8-fe91-4d34-afe6-54310a9955e7"), new DateTime(2022, 7, 16, 0, 23, 35, 320, DateTimeKind.Local).AddTicks(4034), "Movie 1 Descriptions", 15, "Movie 1", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0, true },
                    { new Guid("45fa30c5-1df4-4755-9e17-b622c1bb5aea"), new DateTime(2022, 7, 16, 0, 23, 35, 320, DateTimeKind.Local).AddTicks(4056), "Movie 6 Descriptions", 150, "Movie 4", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, true },
                    { new Guid("4dc4ba44-715b-4e37-ad33-2ddfbd314891"), new DateTime(2022, 7, 16, 0, 23, 35, 320, DateTimeKind.Local).AddTicks(4059), "Movie 6 Descriptions", 160, "Movie 3", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, true },
                    { new Guid("54e6d1b5-6d14-4aa1-817e-9a6e9b3fdc77"), new DateTime(2022, 7, 16, 0, 23, 35, 320, DateTimeKind.Local).AddTicks(4053), "Movie 5 Descriptions", 60, "Movie 5", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, true },
                    { new Guid("bac65cb8-5dae-4a80-b421-3796698b36f7"), new DateTime(2022, 7, 16, 0, 23, 35, 320, DateTimeKind.Local).AddTicks(4043), "Movie 4 Descriptions", 40, "Movie 4", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("0ad87b1d-6ec2-4848-b33d-ac95e014695c"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("0c7fbf6b-d609-48f7-9fc4-9a0b6d16264a"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("1f19365b-0ff9-4c73-9c4e-0b9d5db6a8b3"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("3158b220-40fc-4a88-8218-a081e06101b4"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("40d945d8-fe91-4d34-afe6-54310a9955e7"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("45fa30c5-1df4-4755-9e17-b622c1bb5aea"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("4dc4ba44-715b-4e37-ad33-2ddfbd314891"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("54e6d1b5-6d14-4aa1-817e-9a6e9b3fdc77"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("bac65cb8-5dae-4a80-b421-3796698b36f7"));

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseDate",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
    }
}
