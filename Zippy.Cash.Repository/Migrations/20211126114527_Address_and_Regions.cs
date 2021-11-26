using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zippy.Cash.Repository.Migrations
{
    public partial class Address_and_Regions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountId", "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { "b1df1ac6-771f-4802-95f3-96c55468f92c", new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(5091), new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(5724), new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(5727), new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(5974), new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(5980), new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(6193), new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(6493), new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(6498), new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(6502), new DateTime(2021, 11, 26, 11, 45, 27, 6, DateTimeKind.Utc).AddTicks(6503) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountId", "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { "9251de9a-5955-48f9-9942-1bb0aac437fe", new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6210), new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6522), new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6524), new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6640), new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6643), new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6735), new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6869), new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6871), new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6874), new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6874) });
        }
    }
}
