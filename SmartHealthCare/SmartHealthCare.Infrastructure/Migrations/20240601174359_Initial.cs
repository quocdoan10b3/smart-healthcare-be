using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    AvatarUrl = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
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
                name: "Medicines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Effect = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.Id);
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
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ResponseDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedBacks_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthInsurances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Scholastic = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthInsurances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthInsurances_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ExamDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Vision = table.Column<int>(type: "int", nullable: false),
                    Hearing = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DentalHealth = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Allergies = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Scholastic = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthRecords_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    UsageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Histories_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HistoryId = table.Column<int>(type: "int", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Histories_HistoryId",
                        column: x => x.HistoryId,
                        principalTable: "Histories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "admin", "ADMIN" },
                    { 2, null, "student", "STUDENT" },
                    { 3, null, "staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarUrl", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, null, "c5a7d47f-b393-4a35-aa50-19acf1e75c4e", "example@gmail.com", true, "Admin", false, null, "EXAMPLE@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAED25TdgEROy7/3rOTE0Q709ulPk4etrtURFV3DDP7o5qPfeSsVHaEwRNLTjJ+/NOew==", null, false, "", "3f20af03-e399-4216-9a87-bd72a92e95a1", false, "admin" },
                    { 2, 0, null, "effd5985-977a-44c4-ac6b-fbff9f3704ea", "Stuart_Jaskolski50@hotmail.com", true, "Emily Heathcote", false, null, "STUART_JASKOLSKI50@HOTMAIL.COM", "HS2021867", "AQAAAAIAAYagAAAAENdAVU/lQx/R4vunjLALfBK057LQD0KjRPtql8SXBy42h6ccuKOud2oBYahbJM1wTg==", null, false, "", "987ecb3d-c76f-4e48-aade-348b299c705d", false, "HS2021867" },
                    { 3, 0, null, "455e0210-05e0-4368-b1f5-74fd0b22dd52", "Ayden24@gmail.com", true, "Alysson McDermott", false, null, "AYDEN24@GMAIL.COM", "HS2021844", "AQAAAAIAAYagAAAAEPkjejBz0FhZQwuYci4jWmrn3z3d0/Eioh3478Rkw9BpcB70bWx9t7xJYkvfC6G6Rg==", null, false, "", "839a0899-0e76-4e13-8fe3-0ee8bf62f67e", false, "HS2021844" },
                    { 4, 0, null, "ab668ee6-87d9-4823-a89d-d19206364631", "Elena11@hotmail.com", true, "Stanton Cruickshank", false, null, "ELENA11@HOTMAIL.COM", "HS2022320", "AQAAAAIAAYagAAAAEJAjyqpBVPL5sUNSqfebs0OpS9Lneec7zaYyfs6z9LjqaZazfeT4HjH5RpLx5D2c2w==", null, false, "", "3c96324d-b8e0-4eeb-9b50-f4c7ab05a404", false, "HS2022320" },
                    { 5, 0, null, "ab12240d-7570-4844-af25-054452002559", "Arturo54@gmail.com", true, "Hobart Klocko", false, null, "ARTURO54@GMAIL.COM", "HS2023505", "AQAAAAIAAYagAAAAEKBofNrcVS95oo6xs47ktdDzUaQTrp0QH8sx9kEDMZvcAwjIk+Pts9nCXkyPPE9oPg==", null, false, "", "9d003780-795c-451b-85b5-e4bd9f52e655", false, "HS2023505" },
                    { 6, 0, null, "2d3f6c95-c4e6-462e-b3f7-c4abd4e47d2d", "Dangelo.Bahringer77@hotmail.com", true, "Ewell Gislason", false, null, "DANGELO.BAHRINGER77@HOTMAIL.COM", "HS2020423", "AQAAAAIAAYagAAAAEDp9pMiyFM7WubXQjN2xGe5ES2VOYpkg7dStJEtl4EF2kDmAGER+2uwo4i+zReJbdQ==", null, false, "", "c0fdf8a6-08e9-4051-9637-284185ef0618", false, "HS2020423" },
                    { 7, 0, null, "cc872f95-2e78-44be-81ff-3560eac2fd53", "Adalberto45@hotmail.com", true, "Brycen Pacocha", false, null, "ADALBERTO45@HOTMAIL.COM", "HS2020698", "AQAAAAIAAYagAAAAEPV6cigNt1m8Ez25Ouv8Tr+Ap6IZl9iVLYirpWd9cSBpR3mpzXSy7L1TMgFkrOPyGg==", null, false, "", "336b9135-0c94-4816-96c5-3b7f63372f4d", false, "HS2020698" },
                    { 8, 0, null, "2fdaeb6b-cba2-4e58-8b21-960804c24ee2", "Ellie.Hilpert95@yahoo.com", true, "Otha Heaney", false, null, "ELLIE.HILPERT95@YAHOO.COM", "HS2023931", "AQAAAAIAAYagAAAAEBgrsjhadclCjgLyZzPMIn4qHBKYJVPAqtf/Aio4R8tPtbUqvyw/V/o/mrBlyGEKRw==", null, false, "", "47552f79-9804-41c9-9ed7-c08afc2c7333", false, "HS2023931" },
                    { 9, 0, null, "974b6ad9-81aa-402b-ae0c-dd67d0de5793", "Ike.Walter@gmail.com", true, "Damien Christiansen", false, null, "IKE.WALTER@GMAIL.COM", "HS2023609", "AQAAAAIAAYagAAAAEJqe2rL2fSqjZR/adwQec4m1FcM2goQRnJQHctQrezjOFVbai6C9P45cNeqW0uCR2w==", null, false, "", "777b505b-2711-47e6-a065-926069a8447c", false, "HS2023609" },
                    { 10, 0, null, "ec914a93-11dd-48f6-b040-1b2e968298f8", "Ozella.Ondricka@hotmail.com", true, "Ola Torp", false, null, "OZELLA.ONDRICKA@HOTMAIL.COM", "HS2020275", "AQAAAAIAAYagAAAAEKuRG/XDGjuyMFJx5W/8KUCV7qZomizC4h19d7J4WQibu+cbUUntZ7j3ZTWrSbm9MA==", null, false, "", "72518e7b-435e-42c0-a28b-5167cf9050d5", false, "HS2020275" },
                    { 11, 0, null, "1e77711f-e952-4ac9-ad28-15b901e5494c", "David_Windler@hotmail.com", true, "Maureen Torphy", false, null, "DAVID_WINDLER@HOTMAIL.COM", "HS2020064", "AQAAAAIAAYagAAAAEHFrazSs3olB/qnSXS+l4Dwe6B9YzdU8YnTGMH2UdLuTXERMAQgLKJDC8Hfj3aWLcw==", null, false, "", "6f0ba570-0a65-4ecb-bc69-bfe39d84d04f", false, "HS2020064" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "Class", "Date", "Gender", "StudentCode", "UserId" },
                values: new object[,]
                {
                    { 1, "4325 Dagmar Squares, Kerlukeborough, Costa Rica", "9A", new DateTime(2011, 8, 22, 18, 7, 1, 727, DateTimeKind.Unspecified).AddTicks(5366), true, "HS2021867", 2 },
                    { 2, "1931 Torrance Harbors, Eunicemouth, Brazil", "9A", new DateTime(2012, 8, 31, 13, 40, 29, 240, DateTimeKind.Unspecified).AddTicks(6587), true, "HS2021844", 3 },
                    { 3, "330 Beer Square, Denesikstad, Poland", "9A", new DateTime(2011, 4, 2, 0, 53, 11, 469, DateTimeKind.Unspecified).AddTicks(3239), false, "HS2022320", 4 },
                    { 4, "5664 Crona Cape, South Colinton, Chile", "9A", new DateTime(2010, 12, 21, 13, 36, 59, 540, DateTimeKind.Unspecified).AddTicks(6800), true, "HS2023505", 5 },
                    { 5, "7799 Loyal Prairie, Maychester, Netherlands Antilles", "9A", new DateTime(2010, 3, 8, 12, 8, 39, 620, DateTimeKind.Unspecified).AddTicks(6589), true, "HS2020423", 6 },
                    { 6, "49687 Schumm Springs, New Tyra, Honduras", "9A", new DateTime(2010, 5, 8, 6, 58, 16, 410, DateTimeKind.Unspecified).AddTicks(1833), false, "HS2020698", 7 },
                    { 7, "75313 Swift Summit, Lake Gina, Mali", "9A", new DateTime(2008, 9, 23, 4, 30, 26, 760, DateTimeKind.Unspecified).AddTicks(9323), false, "HS2023931", 8 },
                    { 8, "646 Odell Trail, Wolffville, Central African Republic", "9A", new DateTime(2013, 8, 10, 23, 48, 38, 336, DateTimeKind.Unspecified).AddTicks(2425), false, "HS2023609", 9 },
                    { 9, "18646 Benton Points, Lake Jeanette, Antarctica (the territory South of 60 deg S)", "9A", new DateTime(2012, 2, 14, 10, 9, 34, 158, DateTimeKind.Unspecified).AddTicks(7737), true, "HS2020275", 10 },
                    { 10, "05223 Otis Stream, Barrowsstad, Guatemala", "9A", new DateTime(2012, 1, 25, 23, 48, 16, 56, DateTimeKind.Unspecified).AddTicks(817), false, "HS2020064", 11 }
                });

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
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserName",
                table: "AspNetUsers",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_StudentId",
                table: "FeedBacks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthInsurances_StudentId",
                table: "HealthInsurances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthRecords_StudentId",
                table: "HealthRecords",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Histories_StudentId",
                table: "Histories",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_HistoryId",
                table: "Prescriptions",
                column: "HistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_MedicineId",
                table: "Prescriptions",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_Token",
                table: "RefreshTokens",
                column: "Token",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId",
                unique: true);
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
                name: "FeedBacks");

            migrationBuilder.DropTable(
                name: "HealthInsurances");

            migrationBuilder.DropTable(
                name: "HealthRecords");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
