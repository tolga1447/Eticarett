using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eticaret.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdreslerEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sehir = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    İlce = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AcikAdres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsAktif = table.Column<bool>(type: "bit", nullable: false),
                    IsFaturaAdresi = table.Column<bool>(type: "bit", nullable: false),
                    IsTeslimatAdresi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdresGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adresler_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KullaniciGuid", "OlusturmaTarihi" },
                values: new object[] { new Guid("01ccaf9d-54b8-4304-a8b9-c5f27801e6ae"), new DateTime(2025, 5, 2, 16, 6, 29, 96, DateTimeKind.Local).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2025, 5, 2, 16, 6, 29, 99, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2025, 5, 2, 16, 6, 29, 99, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.CreateIndex(
                name: "IX_Adresler_AppUserId",
                table: "Adresler",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adresler");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KullaniciGuid", "OlusturmaTarihi" },
                values: new object[] { new Guid("8538d59e-aae9-40a8-9ba2-8e508eeafe26"), new DateTime(2025, 4, 26, 17, 39, 25, 578, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2025, 4, 26, 17, 39, 25, 582, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2025, 4, 26, 17, 39, 25, 582, DateTimeKind.Local).AddTicks(6010));
        }
    }
}
