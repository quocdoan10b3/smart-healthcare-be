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
                    Effect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageMedicine = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_AspNetUsers_UserId",
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
                name: "MedicineImport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsedCount = table.Column<int>(type: "int", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineImport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicineImport_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicineImport_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreatAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notification_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
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
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Scholastic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthInsurances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthInsurances_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id");
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
                    Hearing = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DentalHealth = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Allergies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Scholastic = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthRecords_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id");
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
                    Reason = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Histories_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id");
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
                    { 1, 0, null, "53c849d6-ddd9-4701-a07a-321933da7bc9", "example@gmail.com", true, "Admin", false, null, "EXAMPLE@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEMOF8VWKj5EmuysIsY+JnWuLiZi53ZilvcZ4QVeWc3637kzdhwH03t8t34eTaJG6Jw==", null, false, "", "04bb83ff-4242-44a4-a1e0-88ca28e525cb", false, "admin" },
                    { 2, 0, null, "3d8409d7-fd12-4de4-8a67-9c1cd92ca4d0", "Lilla_Hodkiewicz15@hotmail.com", true, "Grady Borer", false, null, "LILLA_HODKIEWICZ15@HOTMAIL.COM", "HS2020327", "AQAAAAIAAYagAAAAEIxreI7c6MNqdD9IwNyTwxgWY3WHP9+ziazK4Jg2F6FjqxF+HX+TxTDShyR7aYXSKA==", null, false, "", "0267a7c1-9dc6-4165-8e2d-103fa52cf129", false, "HS2020327" },
                    { 3, 0, null, "16c6c558-0cce-419f-9f66-c93a63294d5d", "Monserrat_Hills@gmail.com", true, "Cathy Harris", false, null, "MONSERRAT_HILLS@GMAIL.COM", "HS2021767", "AQAAAAIAAYagAAAAELYPuO4hIW9KGC8tS7sbOBfp1crkUnDTMelHj/W9OM3ExxN90OHxns0PGNVWlWMJlg==", null, false, "", "bc4f1089-fad6-4dd1-8843-a5008e6433f0", false, "HS2021767" },
                    { 4, 0, null, "c34520ef-cd7e-41d2-99f5-72786346a599", "Luz.Nitzsche@gmail.com", true, "Nathaniel Welch", false, null, "LUZ.NITZSCHE@GMAIL.COM", "HS2023580", "AQAAAAIAAYagAAAAELRoP9Gr3GZWXlefqg2QeLOIKAWztSbFbiriMbVzFLMj9EB2oGlTvrZWNmB4tPJeNA==", null, false, "", "a96d2060-4bfa-4b12-980f-5cb85c1e4d00", false, "HS2023580" },
                    { 5, 0, null, "dea861b0-857e-4da4-9f43-e4f6fdbfada7", "Orrin.Carter45@gmail.com", true, "Porter Haley", false, null, "ORRIN.CARTER45@GMAIL.COM", "HS2020999", "AQAAAAIAAYagAAAAEG844lcqa4SyVCAm5e4KmhLjTzrcISPjgYif3J4uaWhopRvwxFUYgcv6Zrh9JoqhNw==", null, false, "", "4016ae93-d9ac-4040-aeeb-94576c38edfa", false, "HS2020999" },
                    { 6, 0, null, "5fb25223-3bf6-418e-b47c-e8dcfccb0831", "Grayson_Crooks@yahoo.com", true, "Darlene Bashirian", false, null, "GRAYSON_CROOKS@YAHOO.COM", "HS2023729", "AQAAAAIAAYagAAAAEGoaaT63cmlFuc/+KDZ6zU5P8LZVBLdB2GPwFuzbq23Y2PGgohC8xGzqRs7F0Z38uQ==", null, false, "", "e3cf3f09-bc76-4029-8ba3-21ec521a68b9", false, "HS2023729" },
                    { 7, 0, null, "1620662a-c334-472f-8d10-ece212b1e17f", "Ike30@gmail.com", true, "Alexys Altenwerth", false, null, "IKE30@GMAIL.COM", "HS2022098", "AQAAAAIAAYagAAAAEPjv8s0ytQj3HIGhd3EawxnkzBJ7+7aj4LKBMTqO/dof2UpyMFuuz0qlhU6O6VUizA==", null, false, "", "b0ac2fea-7718-4930-b883-df540e805e9b", false, "HS2022098" },
                    { 8, 0, null, "0cfeef24-e7fb-468c-83a4-fbe925c5891e", "Fay.Fadel67@gmail.com", true, "Jane Abshire", false, null, "FAY.FADEL67@GMAIL.COM", "HS2023677", "AQAAAAIAAYagAAAAED2sTUqw0H3MTZuA6pHGacEXSfnHyYUSdPi/YF4IV+iXxZHDuKkEtVnnczMLoHadMQ==", null, false, "", "e2a5ff98-db83-4a42-8a5a-eda49a1e7db6", false, "HS2023677" },
                    { 9, 0, null, "6e83696a-df8d-435a-aabc-83ef25ae2a4a", "Jefferey_Bashirian@hotmail.com", true, "Felipe Hane", false, null, "JEFFEREY_BASHIRIAN@HOTMAIL.COM", "HS2021677", "AQAAAAIAAYagAAAAEFepzLGIZ7j9ocmuXGpIX6pI1K/yWrSIafKQZzrXHxHlm+JhXJlmcketRKTIguF/oA==", null, false, "", "6e852835-1448-4b96-9cb8-73a5dc0312be", false, "HS2021677" },
                    { 10, 0, null, "f9dfccdf-bfd1-4cd3-a517-7e2a5c6ddaa9", "Rickie_Schroeder52@yahoo.com", true, "Bill Altenwerth", false, null, "RICKIE_SCHROEDER52@YAHOO.COM", "HS2023632", "AQAAAAIAAYagAAAAEMeXVK2A+7XCx0qlcFYN1kCE0WyKjMU0PiEW17/r+Ty1efz79k0QWE1m3a3Kx9xIaQ==", null, false, "", "81f05b6d-bb3f-4250-99b7-4d801cd385e1", false, "HS2023632" },
                    { 11, 0, null, "be025d20-1680-4577-bbcc-cbd2140078f7", "Nakia_Mayer15@gmail.com", true, "Kaci VonRueden", false, null, "NAKIA_MAYER15@GMAIL.COM", "HS2022171", "AQAAAAIAAYagAAAAEJoFaQ6RUana2GRx/Z1VTNcAcxKWviqjHb6T0P+gGRhoaQs74taeLFmOV2bCc955sQ==", null, false, "", "5b9817f0-71b6-4d80-888c-70aea4117dca", false, "HS2022171" }
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
                    { 1, "40334 Leo Stravenue, Pacochaville, Cote d'Ivoire", "9/1", new DateTime(2013, 7, 2, 21, 18, 50, 268, DateTimeKind.Unspecified).AddTicks(5382), false, "HS2020327", 2 },
                    { 2, "7054 Jacobson Prairie, Shayleehaven, China", "9/1", new DateTime(2018, 3, 15, 2, 9, 9, 840, DateTimeKind.Unspecified).AddTicks(5368), false, "HS2021767", 3 },
                    { 3, "46930 Olson Landing, West Talonbury, Pakistan", "9/1", new DateTime(2017, 5, 23, 2, 15, 17, 247, DateTimeKind.Unspecified).AddTicks(8740), false, "HS2023580", 4 },
                    { 4, "0759 Kemmer Turnpike, Willmshaven, Mali", "9/1", new DateTime(2009, 6, 10, 17, 30, 32, 476, DateTimeKind.Unspecified).AddTicks(9519), false, "HS2020999", 5 },
                    { 5, "9940 Jevon Cape, Emelyside, Bosnia and Herzegovina", "9/1", new DateTime(2009, 7, 7, 5, 35, 16, 688, DateTimeKind.Unspecified).AddTicks(2435), true, "HS2023729", 6 },
                    { 6, "68254 Nia Islands, Jonesbury, Yemen", "9/1", new DateTime(2012, 2, 4, 23, 15, 34, 414, DateTimeKind.Unspecified).AddTicks(3477), false, "HS2022098", 7 },
                    { 7, "3998 Gardner Coves, Lake Joesph, Honduras", "9/1", new DateTime(2015, 5, 26, 4, 35, 44, 455, DateTimeKind.Unspecified).AddTicks(4717), false, "HS2023677", 8 },
                    { 8, "2636 Geoffrey Bypass, New Dock, Macedonia", "9/1", new DateTime(2016, 6, 3, 20, 10, 35, 549, DateTimeKind.Unspecified).AddTicks(1518), true, "HS2021677", 9 },
                    { 9, "67934 Trenton Roads, East Talonside, Togo", "9/1", new DateTime(2015, 11, 22, 8, 21, 52, 814, DateTimeKind.Unspecified).AddTicks(2566), true, "HS2023632", 10 },
                    { 10, "42159 Dallas Wells, West Delta, Morocco", "9/1", new DateTime(2012, 10, 30, 11, 13, 32, 996, DateTimeKind.Unspecified).AddTicks(9696), false, "HS2022171", 11 }
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
                name: "IX_HealthInsurances_StaffId",
                table: "HealthInsurances",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthInsurances_StudentId",
                table: "HealthInsurances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthRecords_StaffId",
                table: "HealthRecords",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthRecords_StudentId",
                table: "HealthRecords",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Histories_StaffId",
                table: "Histories",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Histories_StudentId",
                table: "Histories",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineImport_MedicineId",
                table: "MedicineImport",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineImport_StaffId",
                table: "MedicineImport",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_StaffId",
                table: "Notification",
                column: "StaffId");

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
                name: "IX_Staff_UserId",
                table: "Staff",
                column: "UserId",
                unique: true);

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
                name: "MedicineImport");

            migrationBuilder.DropTable(
                name: "Notification");

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
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
