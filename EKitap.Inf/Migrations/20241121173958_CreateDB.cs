using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EKitap.Inf.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Soyad = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValue: new DateTime(2024, 11, 21, 20, 39, 57, 480, DateTimeKind.Local).AddTicks(2305)),
                    GuncellemeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    KayitDurumu = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "YayinEvleri",
                columns: table => new
                {
                    YayinEviID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YayinEviAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YetkiliKisi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YayinEviAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YayinEviMail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YayinEvleri", x => x.YayinEviID);
                });

            migrationBuilder.CreateTable(
                name: "Yazarlar",
                columns: table => new
                {
                    YazarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdi = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValue: new DateTime(2024, 11, 21, 20, 39, 57, 552, DateTimeKind.Local).AddTicks(4584)),
                    GuncellemeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    KayitDurumu = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazarlar", x => x.YazarID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    KitapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAdi = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    KitapResmi = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, defaultValue: "bosResim.jpg"),
                    Fiyat = table.Column<decimal>(type: "money", nullable: false),
                    StokAdedi = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    EklenmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValue: new DateTime(2024, 11, 21, 20, 39, 57, 480, DateTimeKind.Local).AddTicks(5583)),
                    GuncellemeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    KayitDurumu = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    YazarID = table.Column<int>(type: "int", nullable: false),
                    YayinEviID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.KitapID);
                    table.ForeignKey(
                        name: "FK_Kitaplar_AspNetUsers_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaplar_YayinEvleri_YayinEviID",
                        column: x => x.YayinEviID,
                        principalTable: "YayinEvleri",
                        principalColumn: "YayinEviID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Yazarlar_YazarID",
                        column: x => x.YazarID,
                        principalTable: "Yazarlar",
                        principalColumn: "YazarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitapYazarlar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapID = table.Column<int>(type: "int", nullable: false),
                    YazarID = table.Column<int>(type: "int", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValue: new DateTime(2024, 11, 21, 20, 39, 57, 480, DateTimeKind.Local).AddTicks(9258)),
                    GuncellemeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    KayitDurumu = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Kategoriler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapYazarlar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KitapYazarlar_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriID");
                    table.ForeignKey(
                        name: "FK_KitapYazarlar_Kitaplar_KitapID",
                        column: x => x.KitapID,
                        principalTable: "Kitaplar",
                        principalColumn: "KitapID");
                    table.ForeignKey(
                        name: "FK_KitapYazarlar_Yazarlar_YazarID",
                        column: x => x.YazarID,
                        principalTable: "Yazarlar",
                        principalColumn: "YazarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sepetler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapID = table.Column<int>(type: "int", nullable: true),
                    KullaniciID = table.Column<int>(type: "int", nullable: true),
                    Adet = table.Column<short>(type: "smallint", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValue: new DateTime(2024, 11, 21, 20, 39, 57, 552, DateTimeKind.Local).AddTicks(1254)),
                    GuncellemeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    KayitDurumu = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sepetler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sepetler_AspNetUsers_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sepetler_Kitaplar_KitapID",
                        column: x => x.KitapID,
                        principalTable: "Kitaplar",
                        principalColumn: "KitapID");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "acb679f3-ea1f-4f99-93aa-2cc3b36e0100", "Yonetici", "YONETICI" },
                    { 2, "f2e1f01a-a888-451e-9d0f-0ff4ac133c05", "Kullanici", "KULLANICI" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "Bilge", "961bf0c9-d46f-459b-b685-3ce623a3d378", "bilgeadam@deneme.com", false, false, null, "BILGEADAM@DENEME.COM", "BLGADM", "AQAAAAIAAYagAAAAEI56Gdb01RjjUfDBNuk81nM3Rtl4UQLqbPmUKeLKJqXwSjSf2Fozll7PwDbeJiK2SA==", null, false, "95994cc6-5102-4dbc-9762-b68ab92a5e43", "Adam", false, "blgAdm" });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriID", "GuncellemeTarihi", "KategoriAdi", "SilmeTarihi" },
                values: new object[,]
                {
                    { 101, null, "Roman", null },
                    { 102, null, "Hikaye", null },
                    { 103, null, "Bilim Kurgu", null },
                    { 104, null, "Fantastik", null },
                    { 105, null, "Tarih", null },
                    { 106, null, "Biyografi", null },
                    { 107, null, "Otobiyografi", null },
                    { 108, null, "Felsefe", null },
                    { 109, null, "Psikoloji", null },
                    { 110, null, "Klasikler", null },
                    { 111, null, "Şiir", null },
                    { 112, null, "Kişisel Gelişim", null },
                    { 113, null, "Çocuk Kitapları", null },
                    { 114, null, "Edebiyat", null },
                    { 115, null, "Sanat", null },
                    { 116, null, "Din", null },
                    { 117, null, "Gezi", null },
                    { 118, null, "Araştırma-İnceleme", null },
                    { 119, null, "Mizah", null },
                    { 120, null, "Ansiklopedi", null }
                });

            migrationBuilder.InsertData(
                table: "Yazarlar",
                columns: new[] { "YazarID", "GuncellemeTarihi", "SilmeTarihi", "YazarAdi" },
                values: new object[,]
                {
                    { 201, null, null, "Ahmet Hamdi Tanpınar" },
                    { 202, null, null, "Yaşar Kemal" },
                    { 203, null, null, "Orhan Pamuk" },
                    { 204, null, null, "Sabahattin Ali" },
                    { 205, null, null, "Nazım Hikmet" },
                    { 206, null, null, "Halide Edib Adıvar" },
                    { 207, null, null, "Reşat Nuri Güntekin" },
                    { 208, null, null, "Oğuz Atay" },
                    { 209, null, null, "Peyami Safa" },
                    { 210, null, null, "Elif Şafak" },
                    { 211, null, null, "J.K. Rowling" },
                    { 212, null, null, "George Orwell" },
                    { 213, null, null, "J.R.R. Tolkien" },
                    { 214, null, null, "Agatha Christie" },
                    { 215, null, null, "Fyodor Dostoevsky" },
                    { 216, null, null, "Leo Tolstoy" },
                    { 217, null, null, "Ernest Hemingway" },
                    { 218, null, null, "Jane Austen" },
                    { 219, null, null, "Mark Twain" },
                    { 220, null, null, "Franz Kafka" },
                    { 221, null, null, "Charles Dickens" },
                    { 222, null, null, "Gabriel Garcia Marquez" },
                    { 223, null, null, "Haruki Murakami" },
                    { 224, null, null, "Stephen King" },
                    { 225, null, null, "Victor Hugo" },
                    { 226, null, null, "Virginia Woolf" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KategoriID",
                table: "Kitaplar",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KullaniciID",
                table: "Kitaplar",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_YayinEviID",
                table: "Kitaplar",
                column: "YayinEviID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_YazarID",
                table: "Kitaplar",
                column: "YazarID");

            migrationBuilder.CreateIndex(
                name: "IX_KitapYazarlar_KategoriID",
                table: "KitapYazarlar",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_KitapYazarlar_KitapID",
                table: "KitapYazarlar",
                column: "KitapID");

            migrationBuilder.CreateIndex(
                name: "IX_KitapYazarlar_YazarID",
                table: "KitapYazarlar",
                column: "YazarID");

            migrationBuilder.CreateIndex(
                name: "IX_Sepetler_KitapID",
                table: "Sepetler",
                column: "KitapID");

            migrationBuilder.CreateIndex(
                name: "IX_Sepetler_KullaniciID",
                table: "Sepetler",
                column: "KullaniciID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "KitapYazarlar");

            migrationBuilder.DropTable(
                name: "Sepetler");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "YayinEvleri");

            migrationBuilder.DropTable(
                name: "Yazarlar");
        }
    }
}
