using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MiniCommerce.Persistence.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
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
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
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
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Stock = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsOfferable = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    IsSold = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    BrandId = table.Column<int>(type: "integer", nullable: true),
                    UsageId = table.Column<int>(type: "integer", nullable: false),
                    ColorId = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Usage_UsageId",
                        column: x => x.UsageId,
                        principalTable: "Usage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    IsApproved = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Offers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 10, 0, "İzmir", "e8efd284-722c-4c68-8fd0-e160ddc205cb", "ezgi@seeddata.com", true, "Ezgi", "Dene", false, null, "EZGI@SEEDDATA.COM", "EZGI@SEEDDATA.COM", "AQAAAAEAACcQAAAAEB0PxtZSluYYx+HsL9VpFTcTsnEJsCzUrytUAxgZnQsLJcjPO+fAEqwsuUYdrwwTVA==", null, false, "6b209ab1-d936-4d63-9850-7d901f684428", false, "ezgi@seeddata.com" },
                    { 8, 0, "İzmir", "492866b0-cfe3-4fd1-b880-c18a717f368f", "ahmet@seeddata.com", true, "Ahmet", "Yıkılmaz", false, null, "AHMET@SEEDDATA.COM", "AHMET@SEEDDATA.COM", "AQAAAAEAACcQAAAAEOveZRmI0mhNjAzrUEMEGLUgFMLlAJwKFMrUSOjFxc3P66rbnNqUWdMqrE9WjAIEvA==", null, false, "a29330e5-7cf6-412d-97ec-b19cd969ee94", false, "ahmet@seeddata.com" },
                    { 7, 0, "İzmir", "4ab76ec3-cbd7-47c5-8f9d-6fe82f68fe5d", "bora@seeddata.com", true, "Bora", "Kırılmaz", false, null, "BORA@SEEDDATA.COM", "BORA@SEEDDATA.COM", "AQAAAAEAACcQAAAAEA8zGy7Av0RoHjsBx7yS7/SKjf/kRgdGSpciDxB73GIP0/9YL0BGhH9UW45XLhnkAA==", null, false, "2c98325a-47cb-4884-8a7b-7cc483c9055b", false, "bora@seeddata.com" },
                    { 6, 0, "İzmir", "adb8531a-12da-4a55-978b-341805d5c6f6", "kaan@seeddata.com", true, "Kaan", "Kara", false, null, "KAAN@SEEDDATA.COM", "KAAN@SEEDDATA.COM", "AQAAAAEAACcQAAAAEHlbuyUy+mPQ/OivDuKbuVFPMmd6s5GE39sGUuSiP+hk+p3Ih4QwESbryzE7Nht7yw==", null, false, "1e91665c-26d2-427f-bd3c-8230ec368d08", false, "kaan@seeddata.com" },
                    { 5, 0, "İzmir", "2cd43b4c-01ce-43d0-81c9-ba3a0e124b0e", "mert@seeddata.com", true, "Mert", "Durmaz", false, null, "MERT@SEEDDATA.COM", "MERT@SEEDDATA.COM", "AQAAAAEAACcQAAAAEMBMvWjGehJh9TO0U6wIhmP90tUvpMjoqFQ0pf0fU/2LMEeXxZbc/JZI/Jf/AsCQCg==", null, false, "78ce31a5-21b4-4b81-9c85-1a82e3b2c357", false, "mert@seeddata.com" },
                    { 4, 0, "İzmir", "e6aff20a-4256-4025-93a2-d86544418e60", "sezer@seeddata.com", true, "Sezer", "Yılmaz", false, null, "SEZER@SEEDDATA.COM", "SEZER@SEEDDATA.COM", "AQAAAAEAACcQAAAAEA3W/ii7VAwyY4F1T+IDTE4TwfbiCxpTEIKXOD05/uHoippkAjXLV1LeRg3NHGr+AA==", null, false, "84908030-83c1-4e61-a9d6-0f2aa7325845", false, "sezer@seeddata.com" },
                    { 3, 0, "İzmir", "3715e4f0-307f-4b44-8afc-8831a5b616d8", "mehmet@seeddata.com", true, "Mehmet", "Turan", false, null, "MEHMET@SEEDDATA.COM", "MEHMET@SEEDDATA.COM", "AQAAAAEAACcQAAAAEMuT292bXv9uZYFzEURA3xiX/YvmZ8zKt7jwcxkCQpQlpvnJbA9T5wK3yn+l75rGsg==", null, false, "28c68f35-d8e0-40e8-9a8b-1d5fae9d4b93", false, "mehmet@seeddata.com" },
                    { 2, 0, "İzmir", "aa2eb667-2e85-4473-bc38-556e076ef982", "lale@seeddata.com", true, "Lale", "Gezer", false, null, "LALE@SEEDDATA.COM", "LALE@SEEDDATA.COM", "AQAAAAEAACcQAAAAEBbEqLcKxydd3m3zTDgJ74paOKx6uWwObpFOIVnqGmXGzz8IMPgHX7nV60IZSNlknQ==", null, false, "96e41dce-e385-4a0e-a241-2afbffcdf5d7", false, "lale@seeddata.com" },
                    { 1, 0, "İzmir", "e75a9ef3-4358-4d1d-b75a-b51ed77054d2", "kutay@seeddata.com", true, "Kutay", "Demirel", false, null, "KUTAY@SEEDDATA.COM", "KUTAY@SEEDDATA.COM", "AQAAAAEAACcQAAAAEOmWYZlMpMeowRqVU42bkFTtizThbu630cu5fU2Cnh4ltN7+gwyhVpeEmh6jyaXeww==", null, false, "7e330673-5a92-4603-9da7-3ac4b6f53b25", false, "kutay@seeddata.com" },
                    { 9, 0, "İzmir", "b90d0562-67fd-4074-b625-93f1c5655262", "fatma@seeddata.com", true, "Fatma", "Gedik", false, null, "FATMA@SEEDDATA.COM", "FATMA@SEEDDATA.COM", "AQAAAAEAACcQAAAAENpVZvEkPNKKbpOueVayIGvi2ihHTvBzFgBO98AVs5ikKiofu33rbdSIx1pwmTfUyA==", null, false, "e8047a17-eeeb-47b4-b5ef-bbab55b33063", false, "fatma@seeddata.com" }
                });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "LCW VISION", null },
                    { 2, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "XSIDE", null },
                    { 3, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "LCW CLASSIC", null },
                    { 4, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "LCW CASUAL", null },
                    { 5, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "LCW BASIC", null },
                    { 6, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "LCW FORMAL", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 6, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Favorilerini seç soğuktan korun", "Sweatshirt", null },
                    { 7, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rahat pantolonlarla kendini keşfet", "Jean", null },
                    { 8, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Güzel görünmenin vakti", "Elbise", null },
                    { 4, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Şık zamanların tercihi", "Gömlek", null },
                    { 1, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soğuk zamanlarda bire bir", "Mont", null },
                    { 2, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baharda üşümeyin tutar", "Hırka ve Süveter", null },
                    { 3, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kışın üşümeyin diye", "Kazak", null },
                    { 5, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Güneşin keyfini çıkar", "Tişört", null }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 4, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beyaz", null },
                    { 9, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gri", null },
                    { 8, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mavi", null },
                    { 7, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bej", null },
                    { 6, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeşil", null },
                    { 5, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pembe", null },
                    { 3, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kırmızı", null },
                    { 2, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sarı", null },
                    { 1, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Siyah", null }
                });

            migrationBuilder.InsertData(
                table: "Usage",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Çok Kullanılmış", null },
                    { 2, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Az Kullanılmış", null },
                    { 1, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeni", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "ColorId", "CreatedDate", "Description", "ImageUrl", "IsOfferable", "Name", "Price", "Stock", "UpdatedDate", "UsageId", "UserId" },
                values: new object[,]
                {
                    { 1, 4, 1, 7, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatın keyfini çıkarın", "LCWCASUALBejMont.jpg", true, "Slim Fit Kapüşonlu İnce Erkek Kanguru Mont", 309.99m, 1, null, 1, 1 },
                    { 2, 4, 1, 5, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatın keyfini çıkarın", "LCWCASUALPembeMont.jpg", true, "Dik Yaka Düz Uzun Kollu İnce Kadın Mont", 319.99m, 1, null, 2, 1 },
                    { 3, 5, 2, 4, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatın keyfini çıkarın", "LCWBASICBeyazHirka.jpg", true, "Bisiklet Yaka Düz Uzun Kollu Viskon Kadın Hırka", 59.99m, 1, null, 3, 1 },
                    { 4, 2, 2, 6, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatın keyfini çıkarın", "XSIDEYeşilHırka.jpg", true, "Dik Yaka Düz Uzun Kollu Crop Kadın Hırka", 109.99m, 1, null, 1, 1 },
                    { 5, 1, 3, 2, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatın keyfini çıkarın", "LCWVISIONSarıKazak.jpg", true, "Bisiklet Yaka Uzun Kollu Erkek Triko Kazak", 139.99m, 1, null, 2, 2 },
                    { 6, 4, 3, 3, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatın keyfini çıkarın", "LCWCASUALKirmiziKazak.jpg", true, "Bisiklet Yaka Düz Uzun Kollu Kadın Triko Kazak", 99.99m, 1, null, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "ColorId", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "Stock", "UpdatedDate", "UsageId", "UserId" },
                values: new object[] { 15, 3, 8, 5, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatın keyfini çıkarın", "LCWCASUALPembeElbise.jpg", "U Yaka Düz Askılı A Kesim Poplin Kadın Elbise", 199.99m, 1, null, 1, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "ColorId", "CreatedDate", "Description", "ImageUrl", "IsOfferable", "Name", "Price", "Stock", "UpdatedDate", "UsageId", "UserId" },
                values: new object[,]
                {
                    { 7, 6, 4, 8, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatın keyfini çıkarın", "LCWFORMALMaviGomlek.jpg", true, "Slim Fit Uzun Kollu Poplin Erkek Gömlek", 289.99m, 1, null, 1, 3 },
                    { 8, 1, 4, 4, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatın keyfini çıkarın", "LCWVISIONBeyazGomlek.jpg", true, "Önden Düğme Kapamalı Düz Kısa Kollu Poplin Kadın Gömlek", 149.99m, 1, null, 2, 3 },
                    { 9, 2, 5, 2, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatın keyfini çıkarın", "XSIDESarıTisort.jpg", true, "Bisiklet Yaka Baskılı Kısa Kollu Pamuklu Crop Kadın Tişört", 99.99m, 1, null, 3, 3 },
                    { 10, 4, 5, 1, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatın keyfini çıkarın", "LCWCASUALSiyahTisort.jpg", true, "Polo Yaka Kısa Kollu Pike Erkek Tişört", 149.99m, 1, null, 1, 4 },
                    { 11, 2, 6, 8, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatın keyfini çıkarın", "XSIDEMaviSweatShirt.jpg", true, "Kapüşon Yaka Nakışlı Uzun Kollu Kadın Sweatshirt", 89.99m, 1, null, 3, 5 },
                    { 12, 2, 6, 6, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatın keyfini çıkarın", "XSIDEYeşilSweatShirt.jpg", true, "Kapüşonlu Uzun Kollu Baskılı Erkek Sweatshirt", 199.99m, 1, null, 2, 6 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "ColorId", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "Stock", "UpdatedDate", "UsageId", "UserId" },
                values: new object[,]
                {
                    { 13, 4, 7, 9, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatın keyfini çıkarın", "LCWCASULGriJean.jpg", "750 Slim Fit Erkek Jean Pantolon", 189.99m, 1, null, 1, 7 },
                    { 14, 1, 8, 6, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayatın keyfini çıkarın", "LCWVISIONYesilElbise.jpg", "Halter Yaka Düz Kolsuz Kadın Elbise", 199.99m, 1, null, 2, 8 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreatedDate", "Price", "ProductId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 250.00m, 1, null, 2 },
                    { 15, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 76.00m, 11, null, 4 },
                    { 14, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 56.00m, 10, null, 3 },
                    { 13, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 95.00m, 9, null, 3 },
                    { 12, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 78.00m, 8, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreatedDate", "IsApproved", "Price", "ProductId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 11, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 205.00m, 7, null, 1 },
                    { 10, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 85.00m, 6, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreatedDate", "Price", "ProductId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 16, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 63.00m, 12, null, 4 },
                    { 1, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.00m, 6, null, 1 },
                    { 8, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 90.00m, 4, null, 5 },
                    { 7, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 70.00m, 3, null, 7 },
                    { 6, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 85.00m, 3, null, 6 },
                    { 5, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 271.00m, 2, null, 5 },
                    { 4, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.00m, 2, null, 4 },
                    { 3, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 230.00m, 1, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreatedDate", "IsApproved", "Price", "ProductId", "UpdatedDate", "UserId" },
                values: new object[] { 9, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 92.00m, 5, null, 1 });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreatedDate", "Price", "ProductId", "UpdatedDate", "UserId" },
                values: new object[] { 17, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 84.00m, 12, null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offers_ProductId",
                table: "Offers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_UserId",
                table: "Offers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorId",
                table: "Products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Name",
                table: "Products",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_UsageId",
                table: "Products",
                column: "UsageId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserId",
                table: "Products",
                column: "UserId");
        }

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
                name: "Offers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Usage");
        }
    }
}
