using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eticaret.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameİletisimToIletisim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "İletisimler");

            migrationBuilder.CreateTable(
                name: "Iletisimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İsim = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Soyisim = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefon = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Mesaj = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisimler", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iletisimler");

            migrationBuilder.CreateTable(
                name: "İletisimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mesaj = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Soyisim = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Telefon = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    İsim = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_İletisimler", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KullaniciGuid", "OlusturmaTarihi" },
                values: new object[] { new Guid("a3a7a83a-238f-43df-b6f4-4eb10a081797"), new DateTime(2025, 3, 17, 18, 37, 4, 148, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2025, 3, 17, 18, 37, 4, 154, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2025, 3, 17, 18, 37, 4, 154, DateTimeKind.Local).AddTicks(2228));
        }
    }
}
