using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eticaret.Data.Migrations
{
    /// <inheritdoc />
    public partial class UrunEntityColumnIndirimliMi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IndirimliMi",
                table: "Urunler");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KullaniciGuid", "OlusturmaTarihi" },
                values: new object[] { new Guid("c5a60d50-57e9-496d-ad1f-8dd7b4906018"), new DateTime(2025, 3, 19, 17, 33, 42, 287, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2025, 3, 19, 17, 33, 42, 290, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2025, 3, 19, 17, 33, 42, 290, DateTimeKind.Local).AddTicks(8379));
        }
    }
}
