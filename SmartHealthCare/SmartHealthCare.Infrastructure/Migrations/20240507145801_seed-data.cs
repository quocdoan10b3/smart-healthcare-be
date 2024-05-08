using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
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
                    FullName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Effect = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Status = table.Column<bool>(type: "bit", nullable: false)
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
                    Hearing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DentalHealth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Allergies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "2641074e-7b4e-467f-b509-24c735930212", "example@gmail.com", true, "Admin", false, null, "EXAMPLE@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAENVmiKGQ2H+/7sCita++Kwldl6T63Lpm13bIoxA4GjS3aj4QKxoK2Py9HbRGot6+Cg==", null, false, "", "82c9feb7-5346-43c5-9888-dacc90b6b50e", false, "admin" },
                    { 2, 0, "7ce241b0-ee18-499f-8e60-7e030d7fb9d3", "Raleigh_Cummerata35@hotmail.com", true, "Kameron Schowalter", false, null, "RALEIGH_CUMMERATA35@HOTMAIL.COM", "RALEIGH_CUMMERATA35@HOTMAIL.COM", "AQAAAAIAAYagAAAAEI5dYYIpLtXCczu0y20Rn7ncpeZ1QqsIXJFHItaxnQwUGcw3Q12twJO45Dz73dMvTw==", null, false, "", "8b526ad7-4e92-418d-aa30-536c2f9738fb", false, "Raleigh_Cummerata35@hotmail.com" },
                    { 3, 0, "e307e7d4-2712-4ad3-8d23-e8d7b63ebf7a", "Tyrell.Gislason@yahoo.com", true, "Toby Schamberger", false, null, "TYRELL.GISLASON@YAHOO.COM", "TYRELL.GISLASON@YAHOO.COM", "AQAAAAIAAYagAAAAENe7vk+PkgdNJtYb5qhqenRpc59JYiUKlrlPq4EhQSjqC+wgYGH4z0Ip5mK94CS0rA==", null, false, "", "4cb65477-5fed-49a6-a3fd-691b5d3c81d5", false, "Tyrell.Gislason@yahoo.com" },
                    { 4, 0, "8ed30601-d850-4a08-9439-32fd8f1e8dd9", "Corrine49@yahoo.com", true, "Percival Collins", false, null, "CORRINE49@YAHOO.COM", "CORRINE49@YAHOO.COM", "AQAAAAIAAYagAAAAEDvrUu0wz9Ei69t58/H8X7cLF/HBYnHtruJ6L3JgdlgpksCWt8CjR9lhv8SReFHckw==", null, false, "", "2c29193e-7a9e-4094-bd56-59860a9907bc", false, "Corrine49@yahoo.com" },
                    { 5, 0, "e405250a-e38e-41a7-843a-590b83528b90", "Jules.Labadie@gmail.com", true, "Tiffany Maggio", false, null, "JULES.LABADIE@GMAIL.COM", "JULES.LABADIE@GMAIL.COM", "AQAAAAIAAYagAAAAEJ/ESaLxhxE8zJkHbPSsgoLXJPDwZvIoo37/ySfLCWk+xYc8OLh6FGBSO77Fi95/Xw==", null, false, "", "6bcb5487-f66e-4f95-8b5a-39b24d89190a", false, "Jules.Labadie@gmail.com" },
                    { 6, 0, "8c82b043-1f36-4d4b-91d8-eb61ba3f0870", "Agustina_Schamberger37@gmail.com", true, "Christiana Homenick", false, null, "AGUSTINA_SCHAMBERGER37@GMAIL.COM", "AGUSTINA_SCHAMBERGER37@GMAIL.COM", "AQAAAAIAAYagAAAAEIklceEiXd/kx/0UhUYp3gI7t77PUvuA69K7a+fzNNcyHAXUWj/lCu4gDMzZ67xjzQ==", null, false, "", "f33704c4-1dee-434f-b26d-8bcb88491d10", false, "Agustina_Schamberger37@gmail.com" },
                    { 7, 0, "20efacda-d72e-4a5b-8692-1dbbbe473fe6", "Mose_Green@gmail.com", true, "Howard Kihn", false, null, "MOSE_GREEN@GMAIL.COM", "MOSE_GREEN@GMAIL.COM", "AQAAAAIAAYagAAAAEEBhqKIVYKeep9kv1ACJ0BMRIjA5cm/oqZbdfZvQQoN+ZFHb8+pl5+rEpgTD3ubJtQ==", null, false, "", "d44dce38-dc71-4675-861c-6200224d2be3", false, "Mose_Green@gmail.com" },
                    { 8, 0, "4c15100e-a6da-4cdf-9162-8f1eccdee39b", "Jazmin_Hayes@hotmail.com", true, "Alvera Jerde", false, null, "JAZMIN_HAYES@HOTMAIL.COM", "JAZMIN_HAYES@HOTMAIL.COM", "AQAAAAIAAYagAAAAEN8y1zGuKgQy6uUQ7iZA9+NYE01ruPVi2xe7DEtybm6UX5yiT83E3SKBt72zyo27Ng==", null, false, "", "420ee887-b8d8-472d-ab04-483b244d45ae", false, "Jazmin_Hayes@hotmail.com" },
                    { 9, 0, "19416cab-cf1f-40ec-b98b-1117df8bd609", "Orville_Predovic@yahoo.com", true, "Serena Koelpin", false, null, "ORVILLE_PREDOVIC@YAHOO.COM", "ORVILLE_PREDOVIC@YAHOO.COM", "AQAAAAIAAYagAAAAECD/iAajTjwTcttj/0ro1K/OgvmpCdzt51vc9vw+t/zm01BjZzb0XlO7ERSl06N4Sg==", null, false, "", "89710e99-91fe-45a9-a3e0-6886423b1ced", false, "Orville_Predovic@yahoo.com" },
                    { 10, 0, "321b088d-9358-4d8a-af21-24253e536cf3", "Adah.Hoeger@gmail.com", true, "Euna Wolf", false, null, "ADAH.HOEGER@GMAIL.COM", "ADAH.HOEGER@GMAIL.COM", "AQAAAAIAAYagAAAAENIlpyE3mnRjgONZvT7nYdmVfn6pSQiCxww5kcaz0/RNAtD3bemVu6fikuwTV/dMPQ==", null, false, "", "63d73237-e84a-4392-a58f-f0b367df70db", false, "Adah.Hoeger@gmail.com" },
                    { 11, 0, "aba2c43b-eef2-4220-9234-ed0f47d0f942", "Bernadette67@yahoo.com", true, "Ruby Gorczany", false, null, "BERNADETTE67@YAHOO.COM", "BERNADETTE67@YAHOO.COM", "AQAAAAIAAYagAAAAEIw2Fsympsj8O5QktYMrQMexrO6J+Y9nsDT7014Qm3B7kSIVHk24B3A/C+o4T8KxCw==", null, false, "", "dc107a26-3df2-4019-ae30-9a90c0955a24", false, "Bernadette67@yahoo.com" }
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
                    { 1, "38534 Schaefer Wells, Rebekahfurt, Australia", "9A", new DateTime(2014, 7, 23, 2, 34, 2, 944, DateTimeKind.Unspecified).AddTicks(7932), false, "Raleigh_Cummerata35@hotmail.com", 2 },
                    { 2, "592 Mortimer Spur, Borisland, United States of America", "9A", new DateTime(2013, 8, 9, 10, 39, 31, 754, DateTimeKind.Unspecified).AddTicks(7745), true, "Tyrell.Gislason@yahoo.com", 3 },
                    { 3, "6193 Manley Camp, North Dan, Turkey", "9A", new DateTime(2008, 6, 11, 9, 35, 18, 723, DateTimeKind.Unspecified).AddTicks(9313), true, "Corrine49@yahoo.com", 4 },
                    { 4, "18605 Scarlett Cliffs, Adahmouth, Serbia", "9A", new DateTime(2011, 12, 2, 17, 22, 37, 473, DateTimeKind.Unspecified).AddTicks(1517), false, "Jules.Labadie@gmail.com", 5 },
                    { 5, "6970 Adam Mill, Beckermouth, Puerto Rico", "9A", new DateTime(2011, 5, 23, 10, 13, 28, 547, DateTimeKind.Unspecified).AddTicks(3875), true, "Agustina_Schamberger37@gmail.com", 6 },
                    { 6, "1985 Erling Rue, North Janisfort, Bermuda", "9A", new DateTime(2016, 7, 13, 15, 5, 42, 345, DateTimeKind.Unspecified).AddTicks(9021), false, "Mose_Green@gmail.com", 7 },
                    { 7, "006 Aufderhar Mountains, Russelbury, Bangladesh", "9A", new DateTime(2018, 11, 13, 3, 30, 56, 474, DateTimeKind.Unspecified).AddTicks(5274), true, "Jazmin_Hayes@hotmail.com", 8 },
                    { 8, "7296 Ole Union, Bradtkefort, Malta", "9A", new DateTime(2014, 5, 7, 23, 17, 56, 653, DateTimeKind.Unspecified).AddTicks(2514), true, "Orville_Predovic@yahoo.com", 9 },
                    { 9, "090 Schoen Forks, Eastonland, Belgium", "9A", new DateTime(2009, 1, 11, 5, 9, 39, 126, DateTimeKind.Unspecified).AddTicks(3390), true, "Adah.Hoeger@gmail.com", 10 },
                    { 10, "951 Alda Grove, Lake Murphyside, Uzbekistan", "9A", new DateTime(2012, 4, 22, 17, 46, 50, 189, DateTimeKind.Unspecified).AddTicks(2570), false, "Bernadette67@yahoo.com", 11 }
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
                column: "StudentId",
                unique: true);

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
