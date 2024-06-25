using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class deleteseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59e61952-09b2-4ca5-a7da-7f3a0bb83d18", "AQAAAAIAAYagAAAAELD81XkKvIxylE+N3hA1Qk1bEndd0wfSVg0dc83tvH33qlfb4txKBWBrzSMfkw5J7g==", "11e4c9bd-9e55-40dc-9cfc-7b2ae5de284d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09f5ae6f-0d85-4182-b5ef-a198ac6012ea", "AQAAAAIAAYagAAAAENViD7SuvjOKDdb1Yt92A5437yAq9KH4aZd8wfhr5qSlsnNSnHdxqj4LWunEyLXk2g==", "89f40d34-99e2-4eef-a5b2-f2825b4e9552" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarUrl", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 2, 0, null, "33fb2842-3d01-4927-b334-d22f51e533dd", "Jamir23@gmail.com", true, "Randy Zieme", false, null, "JAMIR23@GMAIL.COM", "HS2021763", "AQAAAAIAAYagAAAAEJsz7RBxjIowGtJ9NQ3sS+FTqYgvd+lGwshy74dZ4h1OPu1/pIO5JqDd0hXE1EUblg==", null, false, "", "5a4e2445-a777-4125-9630-ef0b07317fd9", false, "HS2021763" },
                    { 3, 0, null, "b7d15ae9-4f87-4912-85f8-7ead10b0f3fd", "Violet.Christiansen4@gmail.com", true, "Andreane Watsica", false, null, "VIOLET.CHRISTIANSEN4@GMAIL.COM", "HS2022742", "AQAAAAIAAYagAAAAELNnwd9O8QcaS0ki/Jt/IUhjEWesu0dAt8XDPQj+lnw16U3r27mv7rQADo6A+9uenw==", null, false, "", "8069b0ca-8845-47e8-b16c-946f88a931fa", false, "HS2022742" },
                    { 4, 0, null, "d2388c0b-672f-48c3-bf34-f4b103cd1d91", "Tre_Simonis15@hotmail.com", true, "Alec Kutch", false, null, "TRE_SIMONIS15@HOTMAIL.COM", "HS2022694", "AQAAAAIAAYagAAAAEEm2bHaGpp0r1vOAnPtg3sDPsdLknu8aV28c/p2kmMSakQLHgdWQy94mMpg5/aIN5g==", null, false, "", "044cbf51-66b5-4a38-9187-e4b01508e6b6", false, "HS2022694" },
                    { 5, 0, null, "6c8f6316-5595-4e7d-9993-f128adc7472b", "Noemi.Moore@gmail.com", true, "Arnold Little", false, null, "NOEMI.MOORE@GMAIL.COM", "HS2023728", "AQAAAAIAAYagAAAAELvA67bqFVfbG62/und2KGmlu5Y8ys0gwP1afYxm1iy5UxOit8gpAgnwrxt+Xkrt4g==", null, false, "", "490e28fe-4712-4229-91a7-0168d923ea57", false, "HS2023728" },
                    { 6, 0, null, "c97e44fc-d926-4cee-b3ad-128e00eeb673", "Benton_Jacobi84@hotmail.com", true, "Chris Rodriguez", false, null, "BENTON_JACOBI84@HOTMAIL.COM", "HS2020661", "AQAAAAIAAYagAAAAEOWZsoWU33cGz6MuZWSPE5bFIHy1I5ZMO29NwdrmS9gSM6SK20bHUNtY9+oRlKImNg==", null, false, "", "0a38dc26-6752-49a9-9ca9-30a66ce92fd3", false, "HS2020661" },
                    { 7, 0, null, "a4125b60-e98d-45c5-8272-d6dbb29a3c6a", "Brisa.Murray19@hotmail.com", true, "Bernie Torp", false, null, "BRISA.MURRAY19@HOTMAIL.COM", "HS2023925", "AQAAAAIAAYagAAAAEK3R9piuVAu/8rfOkJ3t8iCskq367EPz/+NOo3AMGtG61tNwI+HYhGQWff+5wi612g==", null, false, "", "893de065-383b-41dd-a22b-3f80afe399e7", false, "HS2023925" },
                    { 8, 0, null, "20a354fc-e41c-4b73-99bd-3e8562b3422a", "Albin8@yahoo.com", true, "Aditya Schuppe", false, null, "ALBIN8@YAHOO.COM", "HS2021190", "AQAAAAIAAYagAAAAENU/MgQ/qQBR4bKnzYgbrJ6ixUh+8Nj96N4V5ZdkdEUZDVAIXZHTjfcEiD4vVOOXew==", null, false, "", "0832f540-3a12-4177-8c8e-8151439cd200", false, "HS2021190" },
                    { 9, 0, null, "ca844818-ede8-42b0-87c3-16856e3fa99c", "Lia.Ruecker88@hotmail.com", true, "Edythe Sporer", false, null, "LIA.RUECKER88@HOTMAIL.COM", "HS2021780", "AQAAAAIAAYagAAAAEN0TuSikYZQq35HOCC1kJaRyTXkBo7HslCyn1jaLoJccc5YqsO8cqa0dRZ8HdL5Ogg==", null, false, "", "627be29b-d0ed-4264-a88a-d747e09067c0", false, "HS2021780" },
                    { 10, 0, null, "79f1f987-173e-4e8e-b779-a097f1a85e71", "Keira.Legros@hotmail.com", true, "Emiliano Abbott", false, null, "KEIRA.LEGROS@HOTMAIL.COM", "HS2021786", "AQAAAAIAAYagAAAAEC89MUb6IzpoPtxIG9OBQgb8y185bbrZZGTswO3MID9y9DqTtYhyHGC5rh9spoJbgw==", null, false, "", "04105e81-9af7-4c3c-bcd6-5fb09ab6d6f1", false, "HS2021786" },
                    { 11, 0, null, "4f60073c-0474-4f2e-9216-610b59433252", "Delphia_Hodkiewicz29@yahoo.com", true, "Mariela Renner", false, null, "DELPHIA_HODKIEWICZ29@YAHOO.COM", "HS2020113", "AQAAAAIAAYagAAAAELkIO0RkDJ2EggYnTxDJDSmHrBkHsQgZxG1SbcakZ6HJQvrssXFs4FFpIm79lfUpTQ==", null, false, "", "0f704838-c428-4144-a259-28888d1d683f", false, "HS2020113" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "Class", "Date", "Gender", "StudentCode", "UserId" },
                values: new object[,]
                {
                    { 1, "398 Romaguera Rapid, Port Reid, Trinidad and Tobago", "9/1", new DateTime(2010, 7, 8, 13, 53, 44, 215, DateTimeKind.Unspecified).AddTicks(3904), true, "HS2021763", 2 },
                    { 2, "83854 Maddison Knoll, Walshport, Jersey", "9/1", new DateTime(2010, 11, 25, 5, 26, 55, 54, DateTimeKind.Unspecified).AddTicks(9222), true, "HS2022742", 3 },
                    { 3, "534 Fermin Highway, Gaylordburgh, Yemen", "9/1", new DateTime(2015, 9, 26, 13, 37, 54, 762, DateTimeKind.Unspecified).AddTicks(5426), true, "HS2022694", 4 },
                    { 4, "5522 Prohaska Hills, North Kodyburgh, Luxembourg", "9/1", new DateTime(2017, 3, 3, 21, 36, 10, 194, DateTimeKind.Unspecified).AddTicks(8428), true, "HS2023728", 5 },
                    { 5, "45714 Clementina Drives, Johntown, Tuvalu", "9/1", new DateTime(2012, 4, 29, 2, 22, 39, 651, DateTimeKind.Unspecified).AddTicks(723), true, "HS2020661", 6 },
                    { 6, "6089 Jaskolski Stravenue, East Modestobury, Cote d'Ivoire", "9/1", new DateTime(2008, 8, 29, 16, 40, 52, 73, DateTimeKind.Unspecified).AddTicks(4585), true, "HS2023925", 7 },
                    { 7, "565 Hessel Road, Mylenetown, Argentina", "9/1", new DateTime(2016, 1, 6, 18, 59, 49, 99, DateTimeKind.Unspecified).AddTicks(6674), true, "HS2021190", 8 },
                    { 8, "191 Elza Locks, East Dillon, Thailand", "9/1", new DateTime(2016, 8, 11, 9, 17, 30, 851, DateTimeKind.Unspecified).AddTicks(6452), false, "HS2021780", 9 },
                    { 9, "632 Dorcas Cliff, Kuhlmanville, Norfolk Island", "9/1", new DateTime(2016, 1, 26, 18, 27, 57, 829, DateTimeKind.Unspecified).AddTicks(7412), true, "HS2021786", 10 },
                    { 10, "311 Emerson Vista, Port Nedberg, Yemen", "9/1", new DateTime(2010, 10, 17, 22, 56, 34, 829, DateTimeKind.Unspecified).AddTicks(3808), true, "HS2020113", 11 }
                });
        }
    }
}
