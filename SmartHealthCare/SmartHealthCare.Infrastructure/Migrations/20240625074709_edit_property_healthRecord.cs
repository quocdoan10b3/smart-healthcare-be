using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edit_property_healthRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Weight",
                table: "HealthRecords",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Height",
                table: "HealthRecords",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09f5ae6f-0d85-4182-b5ef-a198ac6012ea", "AQAAAAIAAYagAAAAENViD7SuvjOKDdb1Yt92A5437yAq9KH4aZd8wfhr5qSlsnNSnHdxqj4LWunEyLXk2g==", "89f40d34-99e2-4eef-a5b2-f2825b4e9552" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "33fb2842-3d01-4927-b334-d22f51e533dd", "Jamir23@gmail.com", "Randy Zieme", "JAMIR23@GMAIL.COM", "HS2021763", "AQAAAAIAAYagAAAAEJsz7RBxjIowGtJ9NQ3sS+FTqYgvd+lGwshy74dZ4h1OPu1/pIO5JqDd0hXE1EUblg==", "5a4e2445-a777-4125-9630-ef0b07317fd9", "HS2021763" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b7d15ae9-4f87-4912-85f8-7ead10b0f3fd", "Violet.Christiansen4@gmail.com", "Andreane Watsica", "VIOLET.CHRISTIANSEN4@GMAIL.COM", "HS2022742", "AQAAAAIAAYagAAAAELNnwd9O8QcaS0ki/Jt/IUhjEWesu0dAt8XDPQj+lnw16U3r27mv7rQADo6A+9uenw==", "8069b0ca-8845-47e8-b16c-946f88a931fa", "HS2022742" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d2388c0b-672f-48c3-bf34-f4b103cd1d91", "Tre_Simonis15@hotmail.com", "Alec Kutch", "TRE_SIMONIS15@HOTMAIL.COM", "HS2022694", "AQAAAAIAAYagAAAAEEm2bHaGpp0r1vOAnPtg3sDPsdLknu8aV28c/p2kmMSakQLHgdWQy94mMpg5/aIN5g==", "044cbf51-66b5-4a38-9187-e4b01508e6b6", "HS2022694" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6c8f6316-5595-4e7d-9993-f128adc7472b", "Noemi.Moore@gmail.com", "Arnold Little", "NOEMI.MOORE@GMAIL.COM", "HS2023728", "AQAAAAIAAYagAAAAELvA67bqFVfbG62/und2KGmlu5Y8ys0gwP1afYxm1iy5UxOit8gpAgnwrxt+Xkrt4g==", "490e28fe-4712-4229-91a7-0168d923ea57", "HS2023728" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c97e44fc-d926-4cee-b3ad-128e00eeb673", "Benton_Jacobi84@hotmail.com", "Chris Rodriguez", "BENTON_JACOBI84@HOTMAIL.COM", "HS2020661", "AQAAAAIAAYagAAAAEOWZsoWU33cGz6MuZWSPE5bFIHy1I5ZMO29NwdrmS9gSM6SK20bHUNtY9+oRlKImNg==", "0a38dc26-6752-49a9-9ca9-30a66ce92fd3", "HS2020661" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a4125b60-e98d-45c5-8272-d6dbb29a3c6a", "Brisa.Murray19@hotmail.com", "Bernie Torp", "BRISA.MURRAY19@HOTMAIL.COM", "HS2023925", "AQAAAAIAAYagAAAAEK3R9piuVAu/8rfOkJ3t8iCskq367EPz/+NOo3AMGtG61tNwI+HYhGQWff+5wi612g==", "893de065-383b-41dd-a22b-3f80afe399e7", "HS2023925" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "20a354fc-e41c-4b73-99bd-3e8562b3422a", "Albin8@yahoo.com", "Aditya Schuppe", "ALBIN8@YAHOO.COM", "HS2021190", "AQAAAAIAAYagAAAAENU/MgQ/qQBR4bKnzYgbrJ6ixUh+8Nj96N4V5ZdkdEUZDVAIXZHTjfcEiD4vVOOXew==", "0832f540-3a12-4177-8c8e-8151439cd200", "HS2021190" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ca844818-ede8-42b0-87c3-16856e3fa99c", "Lia.Ruecker88@hotmail.com", "Edythe Sporer", "LIA.RUECKER88@HOTMAIL.COM", "HS2021780", "AQAAAAIAAYagAAAAEN0TuSikYZQq35HOCC1kJaRyTXkBo7HslCyn1jaLoJccc5YqsO8cqa0dRZ8HdL5Ogg==", "627be29b-d0ed-4264-a88a-d747e09067c0", "HS2021780" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "79f1f987-173e-4e8e-b779-a097f1a85e71", "Keira.Legros@hotmail.com", "Emiliano Abbott", "KEIRA.LEGROS@HOTMAIL.COM", "HS2021786", "AQAAAAIAAYagAAAAEC89MUb6IzpoPtxIG9OBQgb8y185bbrZZGTswO3MID9y9DqTtYhyHGC5rh9spoJbgw==", "04105e81-9af7-4c3c-bcd6-5fb09ab6d6f1", "HS2021786" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4f60073c-0474-4f2e-9216-610b59433252", "Delphia_Hodkiewicz29@yahoo.com", "Mariela Renner", "DELPHIA_HODKIEWICZ29@YAHOO.COM", "HS2020113", "AQAAAAIAAYagAAAAELkIO0RkDJ2EggYnTxDJDSmHrBkHsQgZxG1SbcakZ6HJQvrssXFs4FFpIm79lfUpTQ==", "0f704838-c428-4144-a259-28888d1d683f", "HS2020113" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "398 Romaguera Rapid, Port Reid, Trinidad and Tobago", new DateTime(2010, 7, 8, 13, 53, 44, 215, DateTimeKind.Unspecified).AddTicks(3904), "HS2021763" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "83854 Maddison Knoll, Walshport, Jersey", new DateTime(2010, 11, 25, 5, 26, 55, 54, DateTimeKind.Unspecified).AddTicks(9222), "HS2022742" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "534 Fermin Highway, Gaylordburgh, Yemen", new DateTime(2015, 9, 26, 13, 37, 54, 762, DateTimeKind.Unspecified).AddTicks(5426), true, "HS2022694" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "5522 Prohaska Hills, North Kodyburgh, Luxembourg", new DateTime(2017, 3, 3, 21, 36, 10, 194, DateTimeKind.Unspecified).AddTicks(8428), true, "HS2023728" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "45714 Clementina Drives, Johntown, Tuvalu", new DateTime(2012, 4, 29, 2, 22, 39, 651, DateTimeKind.Unspecified).AddTicks(723), "HS2020661" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "6089 Jaskolski Stravenue, East Modestobury, Cote d'Ivoire", new DateTime(2008, 8, 29, 16, 40, 52, 73, DateTimeKind.Unspecified).AddTicks(4585), "HS2023925" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "565 Hessel Road, Mylenetown, Argentina", new DateTime(2016, 1, 6, 18, 59, 49, 99, DateTimeKind.Unspecified).AddTicks(6674), "HS2021190" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "191 Elza Locks, East Dillon, Thailand", new DateTime(2016, 8, 11, 9, 17, 30, 851, DateTimeKind.Unspecified).AddTicks(6452), false, "HS2021780" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "632 Dorcas Cliff, Kuhlmanville, Norfolk Island", new DateTime(2016, 1, 26, 18, 27, 57, 829, DateTimeKind.Unspecified).AddTicks(7412), true, "HS2021786" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "311 Emerson Vista, Port Nedberg, Yemen", new DateTime(2010, 10, 17, 22, 56, 34, 829, DateTimeKind.Unspecified).AddTicks(3808), true, "HS2020113" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "HealthRecords",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "Height",
                table: "HealthRecords",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c200b4e1-23f8-4a53-b473-a9f8edbdbbb8", "AQAAAAIAAYagAAAAEIIp8Zg9evsZve7nQlUXeCWe7ftzHnkssDF69viKT/7fn8jBuBqAsiAgaP9yju6FjA==", "5f6a3a37-fdd1-4ac6-801d-e0f5d167b00c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fe8b61f5-d270-4f23-be19-08feaa505da5", "Griffin_Shanahan@hotmail.com", "Sydney Hyatt", "GRIFFIN_SHANAHAN@HOTMAIL.COM", "HS2020513", "AQAAAAIAAYagAAAAEGCIy4wIvisKeCWGkhjz6+tlLekoxyn6zVlmEGrHeO9kxJBFMr1PiOFXaR0lML/f2g==", "b2442492-9bb6-4426-8caa-62c5b18f155d", "HS2020513" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "35bbcef9-e393-4989-a1c4-dc8a92c55318", "Agustina.Stracke@gmail.com", "Rachelle Kunde", "AGUSTINA.STRACKE@GMAIL.COM", "HS2022861", "AQAAAAIAAYagAAAAEC2/638TwWfmQ9ECgE99ReeAwFu5i6Imk7+zIp0ZLiVUEFASs33Y6Uqp7iGa2MqU/A==", "cba05978-3f61-4572-ba87-b1766335c53d", "HS2022861" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "be84358c-8744-4377-bebd-5f33b9fc9d24", "Dusty.Kris85@yahoo.com", "Lulu Kuhlman", "DUSTY.KRIS85@YAHOO.COM", "HS2021355", "AQAAAAIAAYagAAAAEGuE0DSsf9Id/8hSBZlrWkWSRcaMkYTvK3WPIyouegVZxgf/6cbf+gDB3qEd5cHZ+w==", "952538df-0afe-4faf-a5c0-2892ed252571", "HS2021355" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1e4784f5-1e82-4a1c-a1ff-2f6df946660c", "Alf21@gmail.com", "Shayne Welch", "ALF21@GMAIL.COM", "HS2020965", "AQAAAAIAAYagAAAAEPmHv/FpsU4czuH7e+yMvMlEpfl0sXaD9w1pSb9ZqJtzG3CH6qlxOmEGC5UpU+WySw==", "fc470c2a-136a-4575-838e-d13d587d9b5b", "HS2020965" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7e6d6aba-7e73-4b27-8c10-b35ffb9cff6f", "Avis92@yahoo.com", "Dagmar Ruecker", "AVIS92@YAHOO.COM", "HS2021968", "AQAAAAIAAYagAAAAEMLbRQ3YYk9I5FJCibuyp1t9L+WCZJmKGnatjVxVXL4D4jV2TNR8UXr57Zn3kIM3MQ==", "08a69aaf-e2e8-44f4-8229-50ef25898b49", "HS2021968" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b4ae19b3-55e3-45e2-aa27-59919f9c819a", "Audreanne72@hotmail.com", "Nigel Brakus", "AUDREANNE72@HOTMAIL.COM", "HS2023502", "AQAAAAIAAYagAAAAEGZn+elnKaH6JCRM3hNCi6U7XefiFO1YlqwFe8hx1nukqbXkisJQDsvwWVM0y3VG9w==", "514117c8-b087-490a-a54f-5708d950098b", "HS2023502" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e9f0b215-f4ab-4670-a337-37ee50e71ac7", "Gregory_Crooks76@gmail.com", "Christop Bayer", "GREGORY_CROOKS76@GMAIL.COM", "HS2023225", "AQAAAAIAAYagAAAAEDMSgvEVSznS8sk312aWo/S8Mg/7eaKktjurv+lHCHaRgRQBEKc2rjGEodmo8qAQZg==", "667aeab6-b1df-4c09-a0d2-f5a703c5e9a8", "HS2023225" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5dfd93dd-78c5-427a-9046-b98410f3f667", "Loren_Hahn@yahoo.com", "Virginie Yundt", "LOREN_HAHN@YAHOO.COM", "HS2020297", "AQAAAAIAAYagAAAAEN0zCh132wreDAK3c0xzXl/DHKBcyxU1K1ApKovMU0bWQvMmy+XUmVTGlNxLX4XUhQ==", "d5c15d18-b7ea-47c9-bf92-7e5d908590a5", "HS2020297" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a71123b2-36d3-4e9b-ab70-8ea33f1360c2", "Eula62@yahoo.com", "Gennaro Rice", "EULA62@YAHOO.COM", "HS2021949", "AQAAAAIAAYagAAAAEJfOIJG46ECoIub5XnQtA70i7sZsVONaLEx03GNpAZvStnmfnLPwDg0LRP4VcKNfIA==", "5fe18f79-ed74-407d-a948-2ca889a1b41d", "HS2021949" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "53b7df19-1132-4ac4-abca-495bf480f5f7", "Glenda.Rosenbaum36@gmail.com", "Lavinia Hagenes", "GLENDA.ROSENBAUM36@GMAIL.COM", "HS2023661", "AQAAAAIAAYagAAAAEH/uv/od1rgb0Lm9WmA2zi0sskxzDhpklnAK7CArqtUrMTuQK7P/bmoFC8ZHRPbuXA==", "c42b3af5-dda8-4844-a152-af74f9301c07", "HS2023661" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "3503 Yessenia Drive, Prohaskaville, Svalbard & Jan Mayen Islands", new DateTime(2013, 2, 6, 5, 42, 12, 575, DateTimeKind.Unspecified).AddTicks(6708), "HS2020513" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "4843 Deonte Greens, South Letitiafurt, Ukraine", new DateTime(2015, 2, 11, 19, 47, 41, 829, DateTimeKind.Unspecified).AddTicks(2966), "HS2022861" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "93992 Conn Radial, Port Vivashire, New Caledonia", new DateTime(2011, 7, 26, 3, 1, 37, 553, DateTimeKind.Unspecified).AddTicks(7512), false, "HS2021355" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "6577 Hammes Forges, South Helgachester, Sri Lanka", new DateTime(2018, 5, 12, 17, 42, 3, 763, DateTimeKind.Unspecified).AddTicks(6461), false, "HS2020965" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "7278 Bogisich Spur, Eltaborough, Azerbaijan", new DateTime(2012, 10, 15, 9, 24, 44, 356, DateTimeKind.Unspecified).AddTicks(5230), "HS2021968" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "1606 Heaney Road, Port Zita, Cameroon", new DateTime(2018, 12, 30, 18, 35, 9, 575, DateTimeKind.Unspecified).AddTicks(5646), "HS2023502" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "96489 Rempel Wall, West Londonchester, Grenada", new DateTime(2014, 8, 8, 3, 40, 58, 741, DateTimeKind.Unspecified).AddTicks(8332), "HS2023225" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "2624 Stefan Dam, Leonoramouth, Saint Barthelemy", new DateTime(2018, 12, 16, 20, 25, 30, 554, DateTimeKind.Unspecified).AddTicks(9460), true, "HS2020297" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "3472 Cummings Branch, North Camila, Dominica", new DateTime(2011, 10, 29, 14, 37, 59, 81, DateTimeKind.Unspecified).AddTicks(6476), false, "HS2021949" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "134 Kory Flats, Lake Adrianna, Montserrat", new DateTime(2014, 9, 4, 20, 59, 41, 811, DateTimeKind.Unspecified).AddTicks(9232), false, "HS2023661" });
        }
    }
}
