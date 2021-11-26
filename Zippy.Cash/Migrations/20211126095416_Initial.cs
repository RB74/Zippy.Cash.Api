using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zippy.Cash.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TaxID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfBusiness = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurposeOfBusiness = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Region_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "AccountId", "CreatedOnUTC", "OwnerId", "UpdatedOnUTC" },
                values: new object[] { 1, "9251de9a-5955-48f9-9942-1bb0aac437fe", new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6210), 1, new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6210) });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CreatedOnUTC", "Name", "UpdatedOnUTC" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6522), "United States", new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6522) },
                    { 2, new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6524), "Canada", new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6525) }
                });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "Id", "CreatedOnUTC", "Name", "UpdatedOnUTC" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6640), "USD", new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6641) },
                    { 2, new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6643), "CAD", new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6643) }
                });

            migrationBuilder.InsertData(
                table: "Organization",
                columns: new[] { "Id", "AccountId", "CountryId", "CreatedOnUTC", "Name", "TaxID", "UpdatedOnUTC" },
                values: new object[] { 1, "", 2, new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6735), "Zippy", "", new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6736) });

            migrationBuilder.InsertData(
                table: "Region",
                columns: new[] { "Id", "CountryId", "CreatedOnUTC", "Name", "RegionCode", "UpdatedOnUTC" },
                values: new object[] { 1, 2, new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6869), "Ontario", "001", new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6869) });

            migrationBuilder.InsertData(
                table: "Region",
                columns: new[] { "Id", "CountryId", "CreatedOnUTC", "Name", "RegionCode", "UpdatedOnUTC" },
                values: new object[] { 2, 2, new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6871), "Manitoba", "002", new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6872) });

            migrationBuilder.InsertData(
                table: "Region",
                columns: new[] { "Id", "CountryId", "CreatedOnUTC", "Name", "RegionCode", "UpdatedOnUTC" },
                values: new object[] { 3, 2, new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6874), "Quebec", "003", new DateTime(2021, 11, 26, 9, 54, 15, 951, DateTimeKind.Utc).AddTicks(6874) });

            migrationBuilder.CreateIndex(
                name: "IX_Region_CountryId",
                table: "Region",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
