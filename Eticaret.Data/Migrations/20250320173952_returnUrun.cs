using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eticaret.Data.Migrations
{
    /// <inheritdoc />
    public partial class returnUrun : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IndirimOrani",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "IndirimliFiyat",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "IndirimliMi",
                table: "Urunler");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KullaniciGuid", "OlusturmaTarihi" },
                values: new object[] { new Guid("abe54555-abe9-4b08-b292-8dcaafcf5ccb"), new DateTime(2025, 3, 20, 20, 39, 51, 589, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2025, 3, 20, 20, 39, 51, 593, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2025, 3, 20, 20, 39, 51, 593, DateTimeKind.Local).AddTicks(9677));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "IndirimOrani",
                table: "Urunler",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "IndirimliFiyat",
                table: "Urunler",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IndirimliMi",
                table: "Urunler",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KullaniciGuid", "OlusturmaTarihi" },
                values: new object[] { new Guid("8f87ab61-43ee-4c90-8f04-c1cbb5fd2ab4"), new DateTime(2025, 3, 20, 20, 9, 26, 671, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2025, 3, 20, 20, 9, 26, 675, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2025, 3, 20, 20, 9, 26, 675, DateTimeKind.Local).AddTicks(2884));
        }
    }
}
