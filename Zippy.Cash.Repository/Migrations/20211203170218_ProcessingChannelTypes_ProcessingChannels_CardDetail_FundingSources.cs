using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zippy.Cash.Repository.Migrations
{
    public partial class ProcessingChannelTypes_ProcessingChannels_CardDetail_FundingSources : Migration
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
                values: new object[] { "05e16863-473a-4428-b40b-6cab195f103c", new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(8529), new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(8766), new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(8767), new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(8875), new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(8877), new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(8944), new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(9039), new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(9042), new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOnUTC", "UpdatedOnUTC" },
                values: new object[] { new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(9043), new DateTime(2021, 12, 3, 17, 2, 17, 988, DateTimeKind.Utc).AddTicks(9043) });

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
