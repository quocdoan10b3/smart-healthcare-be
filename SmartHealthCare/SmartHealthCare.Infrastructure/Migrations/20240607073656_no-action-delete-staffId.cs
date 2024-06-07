using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class noactiondeletestaffId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicineImport_Staff_StaffId",
                table: "MedicineImport");

            migrationBuilder.DropForeignKey(
                name: "FK_Notification_Staff_StaffId",
                table: "Notification");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49676115-9bb7-483a-9b6e-3615381b42b6", "AQAAAAIAAYagAAAAEFx+5UUN+0hIflT6WO/FOZ+DN6A90sJKI2wewJhPgixlaLAA8JQTFIwm79VkElSkrA==", "2431e70c-77a9-4b6d-8db8-10575a76487c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7e3efa4f-7680-44d3-8fb9-883649cb4bc9", "Francisco_Hegmann@hotmail.com", "Antonina Considine", "FRANCISCO_HEGMANN@HOTMAIL.COM", "HS2022633", "AQAAAAIAAYagAAAAEJp8hiMc92H1wvSTxI1EVYD7SNoBlG0+tWolVQmlEEPjAWbPy+BPpWFQcBTTjEdebw==", "e375c328-d9b6-40ba-a724-58a940cd568b", "HS2022633" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e0c467b2-e164-4b20-9cf4-5abe6fb0512c", "Roberto67@gmail.com", "Eulah Ondricka", "ROBERTO67@GMAIL.COM", "HS2020309", "AQAAAAIAAYagAAAAEN0iBcWqSgp6yqf3wjIcZaNC/3pttpX+bCQDwa1KIH4xwzOjDz0yyMEJC1jH6zK+8g==", "c3b89e45-d2b1-4c3b-aad3-a56b9f44c156", "HS2020309" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "aa024185-6bb6-4112-ae98-30fd7168defb", "Mateo.Brakus@yahoo.com", "Hassie McClure", "MATEO.BRAKUS@YAHOO.COM", "HS2021746", "AQAAAAIAAYagAAAAEH0au/2vdyYJl0vPWvIyKNV50WBB4E46bnEVDNCL/ymZbvyAH9ov85ecNVf/irwsog==", "e857db35-cef7-44b2-b61e-8f733f052396", "HS2021746" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4d12ef29-d103-41e8-9b61-78d1935f8346", "Reggie62@gmail.com", "Nicolette Breitenberg", "REGGIE62@GMAIL.COM", "HS2020392", "AQAAAAIAAYagAAAAEDBYtCObSQRtKd8ZdrMf7A9LJMreNKAgtMTnP1ogfvYoCjHl7SNgmZbxIVqV28Q4rQ==", "eef47800-ee87-469a-a80b-560fd0802fd5", "HS2020392" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "38b0f1a4-3cd1-4787-a05c-46e3278660af", "Raleigh.Wiegand@gmail.com", "Angus Harber", "RALEIGH.WIEGAND@GMAIL.COM", "HS2020368", "AQAAAAIAAYagAAAAEJAnttPWkPfmmey6zMj+VkDlz43cUNoNAamESaMRQShl9U43yv8w4iHJIEXSAOwB0w==", "7faf4d17-0ff3-407b-9654-ecaa8ecff3f6", "HS2020368" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9614caa4-8700-4640-b4df-546ea66ddcc3", "Yasmine.Von1@yahoo.com", "Susie Dickinson", "YASMINE.VON1@YAHOO.COM", "HS2022048", "AQAAAAIAAYagAAAAEANBDhJh93tA0ENnRCSY/7hrjPipzCBg33WMFkkKKPpBGBDITYV9GNaYEI3n9LPUVg==", "a3b56181-24ee-4d85-afc3-c1c8a9bec6c7", "HS2022048" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5536bec1-cd03-430a-ae57-773e292978b4", "Elfrieda_Veum@yahoo.com", "Tate Nader", "ELFRIEDA_VEUM@YAHOO.COM", "HS2020181", "AQAAAAIAAYagAAAAEMDLf4dhjYWM153GeJLB+uiMbODdcWWEzHc81VKt7YaH+5MROgqcSMk84lVh9rPVLA==", "4f567c4e-a314-4dd5-856a-8239ac1a718f", "HS2020181" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b9b968ba-506d-4058-8e5f-f5733bdcc9ac", "Jameson_Schaefer47@gmail.com", "Horace Hagenes", "JAMESON_SCHAEFER47@GMAIL.COM", "HS2020927", "AQAAAAIAAYagAAAAEN28IoqMFNbSaCxrFfjcqICmLtQ8yP6nrm+JtyxPB3ebufF8pU00sJkZlbPrIYen0w==", "6f2f06e2-e980-4c30-adc7-2e796e3a9f69", "HS2020927" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9d6f2b82-9297-4e8c-83d0-e9b30d52b3ea", "April.Conn11@gmail.com", "Mattie Boyer", "APRIL.CONN11@GMAIL.COM", "HS2021703", "AQAAAAIAAYagAAAAEPuA6Z8y8KpZlWht3ZjbHwiVdughiUSfIRxAN++QxV2ikIHvAIOrKz5UXx/zln+w2w==", "352520c5-d279-4987-aef2-28e6ae3ef244", "HS2021703" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0b051bd5-b85d-4fff-b1b0-4aa13a5c447f", "Victor_Koelpin@yahoo.com", "Leslie Wyman", "VICTOR_KOELPIN@YAHOO.COM", "HS2022161", "AQAAAAIAAYagAAAAEEnJMTQyZTjKL2/pWd4H/olgKEfv4qSl+3TtpGJU6CWBkEvFAnfqDaVycFMGmDa4NQ==", "ed1e6aed-7da8-4036-b833-25d04ade62f7", "HS2022161" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "86295 Rice Village, West Noemi, Afghanistan", new DateTime(2016, 2, 3, 22, 43, 33, 239, DateTimeKind.Unspecified).AddTicks(8457), "HS2022633" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "221 Nolan Parkway, Guiseppemouth, Chad", new DateTime(2012, 2, 19, 19, 41, 17, 949, DateTimeKind.Unspecified).AddTicks(3972), true, "HS2020309" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "03679 Zora Trafficway, South Jodyborough, Canada", new DateTime(2008, 11, 23, 18, 46, 46, 935, DateTimeKind.Unspecified).AddTicks(6639), true, "HS2021746" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "3016 Spinka Pass, Carmellafort, French Southern Territories", new DateTime(2013, 5, 21, 21, 15, 50, 783, DateTimeKind.Unspecified).AddTicks(6624), "HS2020392" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "3165 Quigley Views, South Juston, Bahrain", new DateTime(2010, 10, 23, 20, 35, 5, 569, DateTimeKind.Unspecified).AddTicks(8948), "HS2020368" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "451 Heathcote Alley, Lake Carmenberg, Republic of Korea", new DateTime(2017, 1, 14, 1, 2, 34, 624, DateTimeKind.Unspecified).AddTicks(1929), "HS2022048" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "81347 Feest Estate, Emmiehaven, Burkina Faso", new DateTime(2018, 12, 27, 8, 6, 32, 429, DateTimeKind.Unspecified).AddTicks(1280), true, "HS2020181" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "9135 Ova Corner, South Royalborough, Tuvalu", new DateTime(2008, 2, 5, 8, 39, 25, 686, DateTimeKind.Unspecified).AddTicks(6958), "HS2020927" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "703 Brayan Ridges, East Silas, Romania", new DateTime(2018, 10, 26, 19, 2, 3, 207, DateTimeKind.Unspecified).AddTicks(1960), false, "HS2021703" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "90146 Dicki Way, West Leolaborough, Bahamas", new DateTime(2011, 4, 5, 20, 3, 9, 216, DateTimeKind.Unspecified).AddTicks(6595), true, "HS2022161" });

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineImport_Staff_StaffId",
                table: "MedicineImport",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_Staff_StaffId",
                table: "Notification",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicineImport_Staff_StaffId",
                table: "MedicineImport");

            migrationBuilder.DropForeignKey(
                name: "FK_Notification_Staff_StaffId",
                table: "Notification");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53c849d6-ddd9-4701-a07a-321933da7bc9", "AQAAAAIAAYagAAAAEMOF8VWKj5EmuysIsY+JnWuLiZi53ZilvcZ4QVeWc3637kzdhwH03t8t34eTaJG6Jw==", "04bb83ff-4242-44a4-a1e0-88ca28e525cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3d8409d7-fd12-4de4-8a67-9c1cd92ca4d0", "Lilla_Hodkiewicz15@hotmail.com", "Grady Borer", "LILLA_HODKIEWICZ15@HOTMAIL.COM", "HS2020327", "AQAAAAIAAYagAAAAEIxreI7c6MNqdD9IwNyTwxgWY3WHP9+ziazK4Jg2F6FjqxF+HX+TxTDShyR7aYXSKA==", "0267a7c1-9dc6-4165-8e2d-103fa52cf129", "HS2020327" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "16c6c558-0cce-419f-9f66-c93a63294d5d", "Monserrat_Hills@gmail.com", "Cathy Harris", "MONSERRAT_HILLS@GMAIL.COM", "HS2021767", "AQAAAAIAAYagAAAAELYPuO4hIW9KGC8tS7sbOBfp1crkUnDTMelHj/W9OM3ExxN90OHxns0PGNVWlWMJlg==", "bc4f1089-fad6-4dd1-8843-a5008e6433f0", "HS2021767" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c34520ef-cd7e-41d2-99f5-72786346a599", "Luz.Nitzsche@gmail.com", "Nathaniel Welch", "LUZ.NITZSCHE@GMAIL.COM", "HS2023580", "AQAAAAIAAYagAAAAELRoP9Gr3GZWXlefqg2QeLOIKAWztSbFbiriMbVzFLMj9EB2oGlTvrZWNmB4tPJeNA==", "a96d2060-4bfa-4b12-980f-5cb85c1e4d00", "HS2023580" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "dea861b0-857e-4da4-9f43-e4f6fdbfada7", "Orrin.Carter45@gmail.com", "Porter Haley", "ORRIN.CARTER45@GMAIL.COM", "HS2020999", "AQAAAAIAAYagAAAAEG844lcqa4SyVCAm5e4KmhLjTzrcISPjgYif3J4uaWhopRvwxFUYgcv6Zrh9JoqhNw==", "4016ae93-d9ac-4040-aeeb-94576c38edfa", "HS2020999" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5fb25223-3bf6-418e-b47c-e8dcfccb0831", "Grayson_Crooks@yahoo.com", "Darlene Bashirian", "GRAYSON_CROOKS@YAHOO.COM", "HS2023729", "AQAAAAIAAYagAAAAEGoaaT63cmlFuc/+KDZ6zU5P8LZVBLdB2GPwFuzbq23Y2PGgohC8xGzqRs7F0Z38uQ==", "e3cf3f09-bc76-4029-8ba3-21ec521a68b9", "HS2023729" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1620662a-c334-472f-8d10-ece212b1e17f", "Ike30@gmail.com", "Alexys Altenwerth", "IKE30@GMAIL.COM", "HS2022098", "AQAAAAIAAYagAAAAEPjv8s0ytQj3HIGhd3EawxnkzBJ7+7aj4LKBMTqO/dof2UpyMFuuz0qlhU6O6VUizA==", "b0ac2fea-7718-4930-b883-df540e805e9b", "HS2022098" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0cfeef24-e7fb-468c-83a4-fbe925c5891e", "Fay.Fadel67@gmail.com", "Jane Abshire", "FAY.FADEL67@GMAIL.COM", "HS2023677", "AQAAAAIAAYagAAAAED2sTUqw0H3MTZuA6pHGacEXSfnHyYUSdPi/YF4IV+iXxZHDuKkEtVnnczMLoHadMQ==", "e2a5ff98-db83-4a42-8a5a-eda49a1e7db6", "HS2023677" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6e83696a-df8d-435a-aabc-83ef25ae2a4a", "Jefferey_Bashirian@hotmail.com", "Felipe Hane", "JEFFEREY_BASHIRIAN@HOTMAIL.COM", "HS2021677", "AQAAAAIAAYagAAAAEFepzLGIZ7j9ocmuXGpIX6pI1K/yWrSIafKQZzrXHxHlm+JhXJlmcketRKTIguF/oA==", "6e852835-1448-4b96-9cb8-73a5dc0312be", "HS2021677" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f9dfccdf-bfd1-4cd3-a517-7e2a5c6ddaa9", "Rickie_Schroeder52@yahoo.com", "Bill Altenwerth", "RICKIE_SCHROEDER52@YAHOO.COM", "HS2023632", "AQAAAAIAAYagAAAAEMeXVK2A+7XCx0qlcFYN1kCE0WyKjMU0PiEW17/r+Ty1efz79k0QWE1m3a3Kx9xIaQ==", "81f05b6d-bb3f-4250-99b7-4d801cd385e1", "HS2023632" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "be025d20-1680-4577-bbcc-cbd2140078f7", "Nakia_Mayer15@gmail.com", "Kaci VonRueden", "NAKIA_MAYER15@GMAIL.COM", "HS2022171", "AQAAAAIAAYagAAAAEJoFaQ6RUana2GRx/Z1VTNcAcxKWviqjHb6T0P+gGRhoaQs74taeLFmOV2bCc955sQ==", "5b9817f0-71b6-4d80-888c-70aea4117dca", "HS2022171" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "40334 Leo Stravenue, Pacochaville, Cote d'Ivoire", new DateTime(2013, 7, 2, 21, 18, 50, 268, DateTimeKind.Unspecified).AddTicks(5382), "HS2020327" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "7054 Jacobson Prairie, Shayleehaven, China", new DateTime(2018, 3, 15, 2, 9, 9, 840, DateTimeKind.Unspecified).AddTicks(5368), false, "HS2021767" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "46930 Olson Landing, West Talonbury, Pakistan", new DateTime(2017, 5, 23, 2, 15, 17, 247, DateTimeKind.Unspecified).AddTicks(8740), false, "HS2023580" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "0759 Kemmer Turnpike, Willmshaven, Mali", new DateTime(2009, 6, 10, 17, 30, 32, 476, DateTimeKind.Unspecified).AddTicks(9519), "HS2020999" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "9940 Jevon Cape, Emelyside, Bosnia and Herzegovina", new DateTime(2009, 7, 7, 5, 35, 16, 688, DateTimeKind.Unspecified).AddTicks(2435), "HS2023729" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "68254 Nia Islands, Jonesbury, Yemen", new DateTime(2012, 2, 4, 23, 15, 34, 414, DateTimeKind.Unspecified).AddTicks(3477), "HS2022098" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "3998 Gardner Coves, Lake Joesph, Honduras", new DateTime(2015, 5, 26, 4, 35, 44, 455, DateTimeKind.Unspecified).AddTicks(4717), false, "HS2023677" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "2636 Geoffrey Bypass, New Dock, Macedonia", new DateTime(2016, 6, 3, 20, 10, 35, 549, DateTimeKind.Unspecified).AddTicks(1518), "HS2021677" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "67934 Trenton Roads, East Talonside, Togo", new DateTime(2015, 11, 22, 8, 21, 52, 814, DateTimeKind.Unspecified).AddTicks(2566), true, "HS2023632" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "42159 Dallas Wells, West Delta, Morocco", new DateTime(2012, 10, 30, 11, 13, 32, 996, DateTimeKind.Unspecified).AddTicks(9696), false, "HS2022171" });

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineImport_Staff_StaffId",
                table: "MedicineImport",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_Staff_StaffId",
                table: "Notification",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
