using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zippy.Cash.Repository.Migrations
{
    public partial class Users_Roles_UserRoles_UserStatuses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserStatuses",
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
                    table.PrimaryKey("PK_UserStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    DOB = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Id_adb2c = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Metadata = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserStatuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "UserStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountId", "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { "cc9a468a-41e4-483d-b353-b83d04d8b07c", new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5331), new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5643), new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5645), new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5725), new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5726), new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5798), new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5961), new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5963), new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5965), new DateTime(2021, 12, 3, 15, 19, 3, 573, DateTimeKind.Utc).AddTicks(5965) });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StatusId",
                table: "Users",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserStatuses");

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
