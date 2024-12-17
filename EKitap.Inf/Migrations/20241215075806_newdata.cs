using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EKitap.Inf.Migrations
{
    /// <inheritdoc />
    public partial class newdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Yazarlar",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "YayinEvleri",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Sepetler",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 15, 10, 58, 4, 668, DateTimeKind.Local).AddTicks(8141),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "KitapYazarlar",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 15, 10, 58, 4, 620, DateTimeKind.Local).AddTicks(3349),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 739, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Kitaplar",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 15, 10, 58, 4, 620, DateTimeKind.Local).AddTicks(992),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Kategoriler",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "IletisimBilgileri",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(6954),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 737, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c9699fe6-3914-47f3-8f59-89f0c754cc46");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "294b30b1-8cd5-4e09-a52b-f1f0b0b97316");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "189a7a59-c5ae-4a3c-a77a-d02f7f9c4dad", "AQAAAAIAAYagAAAAEJfuo5NsJIbOjVxHw0c59xEAwg5AW2/PrQNy5aBK9xudAnwbaNHp7HLoQqvWAv0vag==", "a6589249-75f7-4858-9660-c307e6ee567e" });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 101,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 102,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 103,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 104,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 105,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 106,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 107,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 108,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 109,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 110,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 111,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 112,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 113,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 114,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 115,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 116,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 117,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 118,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 119,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "KategoriID",
                keyValue: 120,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "201",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "202",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "203",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "204",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "205",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "206",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "207",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "208",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "209",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "210",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "211",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "212",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "213",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "214",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "YayinEvleri",
                keyColumn: "YayinEviID",
                keyValue: "215",
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 201,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 202,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 203,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 204,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 205,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 206,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 207,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 208,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 209,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 210,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 211,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 212,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 213,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 214,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 215,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 216,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 217,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 218,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 219,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 220,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 221,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 222,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 223,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 224,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 225,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Yazarlar",
                keyColumn: "YazarID",
                keyValue: 226,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Yazarlar",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 829, DateTimeKind.Local).AddTicks(3586),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "YayinEvleri",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(9892),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 15, 10, 58, 4, 669, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Sepetler",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 828, DateTimeKind.Local).AddTicks(5516),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 15, 10, 58, 4, 668, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "KitapYazarlar",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 739, DateTimeKind.Local).AddTicks(4619),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 15, 10, 58, 4, 620, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Kitaplar",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(8025),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 15, 10, 58, 4, 620, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Kategoriler",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 738, DateTimeKind.Local).AddTicks(3238),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "IletisimBilgileri",
                type: "smalldatetime",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 3, 17, 17, 35, 737, DateTimeKind.Local).AddTicks(6709),
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValue: new DateTime(2024, 12, 15, 10, 58, 4, 619, DateTimeKind.Local).AddTicks(6954));

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
        }
    }
}
