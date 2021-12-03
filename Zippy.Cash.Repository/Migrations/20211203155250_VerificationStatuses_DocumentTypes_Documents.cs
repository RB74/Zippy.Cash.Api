using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zippy.Cash.Repository.Migrations
{
    public partial class VerificationStatuses_DocumentTypes_Documents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentTypes",
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
                    table.PrimaryKey("PK_DocumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VerificationStatuses",
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
                    table.PrimaryKey("PK_VerificationStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: false),
                    VerificationStatusId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_DocumentTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_VerificationStatuses_VerificationStatusId",
                        column: x => x.VerificationStatusId,
                        principalTable: "VerificationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountId", "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { "8aef45d2-1b8d-4f20-b58c-7abaffca99ba", new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(2598), new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(2850), new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(2852), new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(2969), new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(2972), new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(3039), new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(3131), new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(3133), new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(3135), new DateTime(2021, 12, 3, 15, 52, 49, 813, DateTimeKind.Utc).AddTicks(3135) });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_TypeId",
                table: "Documents",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_VerificationStatusId",
                table: "Documents",
                column: "VerificationStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "VerificationStatuses");

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
    }
}
