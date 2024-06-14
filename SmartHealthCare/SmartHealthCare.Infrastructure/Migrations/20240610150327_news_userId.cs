using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class news_userId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notification_Staff_StaffId",
                table: "Notification");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "Notification",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Notification_StaffId",
                table: "Notification",
                newName: "IX_Notification_UserId");

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
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "1606 Heaney Road, Port Zita, Cameroon", new DateTime(2018, 12, 30, 18, 35, 9, 575, DateTimeKind.Unspecified).AddTicks(5646), true, "HS2023502" });

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
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "3472 Cummings Branch, North Camila, Dominica", new DateTime(2011, 10, 29, 14, 37, 59, 81, DateTimeKind.Unspecified).AddTicks(6476), "HS2021949" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "134 Kory Flats, Lake Adrianna, Montserrat", new DateTime(2014, 9, 4, 20, 59, 41, 811, DateTimeKind.Unspecified).AddTicks(9232), "HS2023661" });

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_AspNetUsers_UserId",
                table: "Notification",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notification_AspNetUsers_UserId",
                table: "Notification");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Notification",
                newName: "StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_Notification_UserId",
                table: "Notification",
                newName: "IX_Notification_StaffId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a43e5bc-851d-4e6e-a73a-a33d1ab88d4b", "AQAAAAIAAYagAAAAEF5FJoeO6lJSZ+pQnecMwBzsCdxRziMebce1jyrHEvfKWbSmrqakfx8iLupqiqyAfg==", "5df2f6b2-d330-4f2c-af23-00e97ecdf835" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1de76dac-cbfe-4469-894c-b7d324647934", "Emilia.Deckow55@hotmail.com", "Shayna Klocko", "EMILIA.DECKOW55@HOTMAIL.COM", "HS2023466", "AQAAAAIAAYagAAAAEHqQuQbh2O2+U/jXE1vAiV6+bfQtE02c5z5itDAsy2Km+FIxBddPdJPTaUoaSEy7aw==", "29c0b329-b34d-48b1-9233-90eea9638f1a", "HS2023466" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cd22a41e-aca2-464d-bc95-b92335a51ad2", "Rene_Breitenberg78@yahoo.com", "Kamren Heaney", "RENE_BREITENBERG78@YAHOO.COM", "HS2022433", "AQAAAAIAAYagAAAAEO2I5YJR25EMPx1T6sc2ofKhF3yiLmdD5IgUfLBrKCsTB2W8Mg2HzCPOFeuy2reC4g==", "b03df7fb-7aca-4927-ab73-ed65dfe9937c", "HS2022433" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cf01a55b-2eeb-47ff-839b-6c5218a0afac", "Bessie_Murray55@gmail.com", "Rose Goyette", "BESSIE_MURRAY55@GMAIL.COM", "HS2021329", "AQAAAAIAAYagAAAAEECUArZt6eReL+Rz0l8MBQLo2uGugoyeFt+9Lku+vH5baGGVy3B01w5fAccXNaDXDA==", "c2b0b6e2-1634-415f-be68-1a54a853fb21", "HS2021329" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bc439c5b-9d0a-45ee-a993-cdb59b9e9c64", "Josue_Kilback65@gmail.com", "Hazle Reinger", "JOSUE_KILBACK65@GMAIL.COM", "HS2020473", "AQAAAAIAAYagAAAAECGNXx+K9BjybMtT4261LJfQeXA3G+fyGYU/ijfiZ9Nrc2kmDM83I2WP2R36UVUWdQ==", "2e66efae-790c-45d6-b285-ceb9252d7a94", "HS2020473" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c291ad0a-cf6f-450f-8d3a-e22072d65b77", "Peggie.Rosenbaum8@yahoo.com", "Jalen Schaefer", "PEGGIE.ROSENBAUM8@YAHOO.COM", "HS2020884", "AQAAAAIAAYagAAAAEM9QiFhzsE+mJpo3/J3aPioLR2B08pouKTvRc4fLFoWkeHIhiZ2vu4rOvOxQPskq+A==", "b683d45b-c58f-486a-9b2a-c92b030054d3", "HS2020884" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6a800de0-55c5-4d88-bd26-c85c58db5c2c", "Mavis_Treutel@yahoo.com", "Dannie Denesik", "MAVIS_TREUTEL@YAHOO.COM", "HS2022224", "AQAAAAIAAYagAAAAEBR021q77IJtGcPvZMqtzwjuSyncyb0sRfkztbKonb0De7OB0AcfBTaRto+VACdDhA==", "a8c36cd6-0cbb-4c8c-a2a9-d0977455d323", "HS2022224" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "747c8121-74ce-4341-949c-618e9d8dec20", "Patricia.Collins@hotmail.com", "Jordon Gaylord", "PATRICIA.COLLINS@HOTMAIL.COM", "HS2023890", "AQAAAAIAAYagAAAAEJCMX8IzAQ8u/Sfz2BjLYPfNr7xCW6GUh2/5gYdA6pHTTvlX5OYXqA4ml1uVrdTqaA==", "06b943bc-1b31-4256-a898-acb90082cc71", "HS2023890" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bc3ff5f3-373e-4482-bcb8-bc251036c1a3", "Brooks_Conroy51@hotmail.com", "Palma Russel", "BROOKS_CONROY51@HOTMAIL.COM", "HS2021787", "AQAAAAIAAYagAAAAEHFLAD2AoDX9WaUtfDkJJsfWOP3WhuamyofoWfelRbhzGRRCh2Jp/qAe5vzCuIdQNw==", "be444321-482d-4bcb-9154-39d48a71955b", "HS2021787" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a137fc3e-edc3-42f2-82cb-404fd4ae6a89", "Baron9@gmail.com", "Lorna Bernier", "BARON9@GMAIL.COM", "HS2021724", "AQAAAAIAAYagAAAAEJH0Axt1oHebUT+VNH/2q++YEu5TM4KVXWYcWQh1r9ej0t4dgi5mseAN10RhkKaCpg==", "0b7e5303-6840-40e9-89ce-7e8259977bd2", "HS2021724" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "97cb0448-584b-4f42-b013-ded93ca22b82", "Ulices.Lebsack44@hotmail.com", "Rosina Lindgren", "ULICES.LEBSACK44@HOTMAIL.COM", "HS2023466", "AQAAAAIAAYagAAAAEI/o/d3SYLVz/FWyyp5+0QeNivV1vKHzd6YObN4l8q5Wt+I6x0R+Jj9xQE9jK1zbGQ==", "038b40a1-6513-414f-96bc-c69619aa6d41", "HS2023466" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "25120 Rempel Expressway, Alimouth, Burundi", new DateTime(2010, 3, 13, 23, 6, 58, 244, DateTimeKind.Unspecified).AddTicks(8297), "HS2023466" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "0831 Jacobson River, Lake Grover, Lithuania", new DateTime(2010, 9, 14, 13, 46, 24, 588, DateTimeKind.Unspecified).AddTicks(9855), "HS2022433" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "673 Doug Well, Morissettemouth, Azerbaijan", new DateTime(2008, 8, 11, 9, 26, 43, 765, DateTimeKind.Unspecified).AddTicks(1388), true, "HS2021329" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "25169 Isom Course, Devynmouth, Germany", new DateTime(2018, 6, 24, 1, 41, 41, 79, DateTimeKind.Unspecified).AddTicks(474), true, "HS2020473" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "4458 Joelle Mountains, South Tyshawnburgh, Northern Mariana Islands", new DateTime(2009, 5, 1, 16, 2, 24, 954, DateTimeKind.Unspecified).AddTicks(1911), "HS2020884" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "49799 Una Mountain, Rhealand, Haiti", new DateTime(2008, 11, 30, 4, 12, 59, 18, DateTimeKind.Unspecified).AddTicks(3160), false, "HS2022224" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "94119 Kay Hill, Flatleyview, Cyprus", new DateTime(2009, 12, 21, 6, 15, 57, 21, DateTimeKind.Unspecified).AddTicks(2234), "HS2023890" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "37694 Koelpin Creek, Olsonshire, Philippines", new DateTime(2012, 12, 11, 9, 58, 51, 819, DateTimeKind.Unspecified).AddTicks(2352), false, "HS2021787" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "84227 Amelia Square, Larsonfurt, Sudan", new DateTime(2010, 6, 29, 19, 12, 18, 771, DateTimeKind.Unspecified).AddTicks(991), "HS2021724" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "339 Stacy Route, North Johannaburgh, Sudan", new DateTime(2013, 1, 23, 13, 41, 58, 479, DateTimeKind.Unspecified).AddTicks(4276), "HS2023466" });

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_Staff_StaffId",
                table: "Notification",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id");
        }
    }
}
