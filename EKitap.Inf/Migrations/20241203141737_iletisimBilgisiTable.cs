using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EKitap.Inf.Migrations
{
    /// <inheritdoc />
    public partial class iletisimBilgisiTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Yazarlar",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "YayinEvleri",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Sepetler",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(5516),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 11, 23, 23, 7, 50, 505, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "KitapYazarlar",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 739, DateTimeKind.Local).AddTicks(4619),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Kitaplar",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(8025),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Kategoriler",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.CreateTable(
                name: "IletisimBilgileri",
                columns: table => new
                {
                    IletisimBilgiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    AdresBasligi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostaKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 737, DateTimeKind.Local).AddTicks(6709)),
                    GuncellemeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    KayitDurumu = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IletisimBilgileri", x => x.IletisimBilgiID);
                    table.ForeignKey(
                        name: "FK_IletisimBilgileri_AspNetUsers_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d5036718-375f-43c6-8894-9ed8de691207");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0043c480-c3f6-4182-b172-e3f594e75864");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adaebcff-d06b-4a19-a7ec-564729b3ce63", "AQAAAAIAAYagAAAAEJK2m9b4sWEbTTu6GY59cN4ifaTA7wVJIvJquwD+6JGwMFX5cPWzjEfs/4WITRQrtg==", "404f9af7-2b07-4704-bb70-25cb61724b9f" });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 101,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 102,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 103,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 104,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 105,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 106,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 107,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 108,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 109,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 110,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 111,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 112,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 113,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 114,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 115,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 116,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 117,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 118,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 119,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 120,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "201",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "202",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "203",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "204",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "205",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "206",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "207",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "208",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "209",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "210",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "211",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "212",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "213",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "214",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "215",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 201,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 202,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 203,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 204,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 205,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 206,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 207,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 208,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 209,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 210,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 211,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 212,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 213,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 214,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 215,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 216,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 217,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 218,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 219,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 220,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 221,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 222,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 223,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 224,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 225,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 226,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.CreateIndex(
                name: "IX_IletisimBilgileri_KullaniciID",
                table: "IletisimBilgileri",
                column: "KullaniciID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IletisimBilgileri");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Yazarlar",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "YayinEvleri",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Sepetler",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 23, 23, 7, 50, 505, DateTimeKind.Local).AddTicks(9521),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "KitapYazarlar",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(9003),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 739, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Kitaplar",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(5099),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Kategoriler",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d265c286-c1b4-4348-942d-afc4062c79c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "98cb1992-e146-4faa-acf2-32826ab431c0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc64e402-5695-41a4-81fb-f7c2a36c8f73", "AQAAAAIAAYagAAAAEB0MuC/sJDSYKC0sG6Z1xJC4P/KNItDhXdG9QtPLjv/ISwSw2VaP/dnTXvC3JD4+JQ==", "e84de9b4-1ddb-4a80-af2f-ce3d240c13d7" });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 101,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 102,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 103,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 104,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 105,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 106,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 107,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 108,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 109,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 110,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 111,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 112,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 113,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 114,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 115,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 116,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 117,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 118,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 119,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 120,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 384, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "201",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "202",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "203",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "204",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "205",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "206",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "207",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "208",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "209",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "210",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "211",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "212",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "213",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "214",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "215",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 506, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 201,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 202,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 203,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 204,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 205,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 206,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 207,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 208,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 209,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 210,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 211,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 212,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 213,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 214,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 215,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 216,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 217,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 218,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 219,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 220,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 221,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 222,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 223,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 224,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 225,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 226,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 11, 23, 23, 7, 50, 507, DateTimeKind.Local).AddTicks(9178));
        }
    }
}
