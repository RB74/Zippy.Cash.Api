using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zippy.Cash.Repository.Migrations
{
    public partial class ZCP_1538 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    ExpirationMonth = table.Column<int>(type: "int", nullable: false),
                    ExpriationYear = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SourceId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcessingChannelTypes",
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
                    table.PrimaryKey("PK_ProcessingChannelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FundingSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SourceId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    BankDetailsId = table.Column<int>(type: "int", nullable: false),
                    CardDetailId = table.Column<int>(type: "int", nullable: false),
                    LedgerId = table.Column<int>(type: "int", nullable: false),
                    Removed = table.Column<bool>(type: "bit", nullable: false),
                    Metadata = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundingSources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FundingSources_CardDetails_CardDetailId",
                        column: x => x.CardDetailId,
                        principalTable: "CardDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcessingChannels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FundingSourceId = table.Column<int>(type: "int", nullable: true),
                    ProcessingChannelTypeId = table.Column<int>(type: "int", nullable: true),
                    CreatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOnUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessingChannels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessingChannels_FundingSources_FundingSourceId",
                        column: x => x.FundingSourceId,
                        principalTable: "FundingSources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProcessingChannels_ProcessingChannelTypes_ProcessingChannelTypeId",
                        column: x => x.ProcessingChannelTypeId,
                        principalTable: "ProcessingChannelTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountId", "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { "8cfee763-1409-45b8-a36e-8adfbc0a4549", new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(6814), new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(7099), new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(7102), new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(7168), new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(7170), new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(7234), new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(7328), new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(7330), new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(7332), new DateTime(2021, 12, 6, 14, 10, 17, 13, DateTimeKind.Utc).AddTicks(7332) });

            migrationBuilder.CreateIndex(
                name: "IX_FundingSources_CardDetailId",
                table: "FundingSources",
                column: "CardDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessingChannels_FundingSourceId",
                table: "ProcessingChannels",
                column: "FundingSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessingChannels_ProcessingChannelTypeId",
                table: "ProcessingChannels",
                column: "ProcessingChannelTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcessingChannels");

            migrationBuilder.DropTable(
                name: "FundingSources");

            migrationBuilder.DropTable(
                name: "ProcessingChannelTypes");

            migrationBuilder.DropTable(
                name: "CardDetails");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccountId", "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { "f6432a08-9c77-43c2-9449-8f8d79962953", new DateTime(2021, 12, 6, 13, 32, 45, 427, DateTimeKind.Utc).AddTicks(9526), new DateTime(2021, 12, 6, 13, 32, 45, 427, DateTimeKind.Utc).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 6, 13, 32, 45, 427, DateTimeKind.Utc).AddTicks(9778), new DateTime(2021, 12, 6, 13, 32, 45, 427, DateTimeKind.Utc).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 6, 13, 32, 45, 427, DateTimeKind.Utc).AddTicks(9781), new DateTime(2021, 12, 6, 13, 32, 45, 427, DateTimeKind.Utc).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 6, 13, 32, 45, 427, DateTimeKind.Utc).AddTicks(9858), new DateTime(2021, 12, 6, 13, 32, 45, 427, DateTimeKind.Utc).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 6, 13, 32, 45, 427, DateTimeKind.Utc).AddTicks(9860), new DateTime(2021, 12, 6, 13, 32, 45, 427, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 6, 13, 32, 45, 427, DateTimeKind.Utc).AddTicks(9921), new DateTime(2021, 12, 6, 13, 32, 45, 427, DateTimeKind.Utc).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 6, 13, 32, 45, 428, DateTimeKind.Utc).AddTicks(28), new DateTime(2021, 12, 6, 13, 32, 45, 428, DateTimeKind.Utc).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 6, 13, 32, 45, 428, DateTimeKind.Utc).AddTicks(30), new DateTime(2021, 12, 6, 13, 32, 45, 428, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 6, 13, 32, 45, 428, DateTimeKind.Utc).AddTicks(32), new DateTime(2021, 12, 6, 13, 32, 45, 428, DateTimeKind.Utc).AddTicks(32) });
        }
    }
}
