using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eticaret.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddOkunduToİletisim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Okundu",
                table: "Iletisimler",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Okundu",
                table: "Iletisimler");

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
    }
}
