using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eticaret.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditToUrurnEntitiy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IndirimOrani",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "IndirimliFiyat",
                table: "Urunler");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KullaniciGuid", "OlusturmaTarihi" },
                values: new object[] { new Guid("23d10eb2-5363-4ff7-9b64-56bfa6c260e1"), new DateTime(2025, 3, 20, 19, 36, 45, 492, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2025, 3, 20, 19, 36, 45, 496, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2025, 3, 20, 19, 36, 45, 496, DateTimeKind.Local).AddTicks(7336));
        }
    }
}
