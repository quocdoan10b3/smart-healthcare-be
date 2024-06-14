using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class delete_property_staff_id_medicineImport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicineImport_Staff_StaffId",
                table: "MedicineImport");

            migrationBuilder.DropIndex(
                name: "IX_MedicineImport_StaffId",
                table: "MedicineImport");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "MedicineImport");

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
                values: new object[] { "97cb0448-584b-4f42-b013-ded93ca22b82", "Ulices.Lebsack44@hotmail.com", "Rosina Lindgren", "ULICES.LEBSACK44@HOTMAIL.COM", "HS2023468", "AQAAAAIAAYagAAAAEI/o/d3SYLVz/FWyyp5+0QeNivV1vKHzd6YObN4l8q5Wt+I6x0R+Jj9xQE9jK1zbGQ==", "038b40a1-6513-414f-96bc-c69619aa6d41", "HS2023468" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "25120 Rempel Expressway, Alimouth, Burundi", new DateTime(2010, 3, 13, 23, 6, 58, 244, DateTimeKind.Unspecified).AddTicks(8297), true, "HS2023466" });

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
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "673 Doug Well, Morissettemouth, Azerbaijan", new DateTime(2008, 8, 11, 9, 26, 43, 765, DateTimeKind.Unspecified).AddTicks(1388), "HS2021329" });

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
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "49799 Una Mountain, Rhealand, Haiti", new DateTime(2008, 11, 30, 4, 12, 59, 18, DateTimeKind.Unspecified).AddTicks(3160), "HS2022224" });

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
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "339 Stacy Route, North Johannaburgh, Sudan", new DateTime(2013, 1, 23, 13, 41, 58, 479, DateTimeKind.Unspecified).AddTicks(4276), false, "HS2023468" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "MedicineImport",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "86295 Rice Village, West Noemi, Afghanistan", new DateTime(2016, 2, 3, 22, 43, 33, 239, DateTimeKind.Unspecified).AddTicks(8457), false, "HS2022633" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "221 Nolan Parkway, Guiseppemouth, Chad", new DateTime(2012, 2, 19, 19, 41, 17, 949, DateTimeKind.Unspecified).AddTicks(3972), "HS2020309" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "03679 Zora Trafficway, South Jodyborough, Canada", new DateTime(2008, 11, 23, 18, 46, 46, 935, DateTimeKind.Unspecified).AddTicks(6639), "HS2021746" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "3016 Spinka Pass, Carmellafort, French Southern Territories", new DateTime(2013, 5, 21, 21, 15, 50, 783, DateTimeKind.Unspecified).AddTicks(6624), false, "HS2020392" });

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
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "81347 Feest Estate, Emmiehaven, Burkina Faso", new DateTime(2018, 12, 27, 8, 6, 32, 429, DateTimeKind.Unspecified).AddTicks(1280), "HS2020181" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "9135 Ova Corner, South Royalborough, Tuvalu", new DateTime(2008, 2, 5, 8, 39, 25, 686, DateTimeKind.Unspecified).AddTicks(6958), true, "HS2020927" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "703 Brayan Ridges, East Silas, Romania", new DateTime(2018, 10, 26, 19, 2, 3, 207, DateTimeKind.Unspecified).AddTicks(1960), "HS2021703" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "90146 Dicki Way, West Leolaborough, Bahamas", new DateTime(2011, 4, 5, 20, 3, 9, 216, DateTimeKind.Unspecified).AddTicks(6595), true, "HS2022161" });

            migrationBuilder.CreateIndex(
                name: "IX_MedicineImport_StaffId",
                table: "MedicineImport",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineImport_Staff_StaffId",
                table: "MedicineImport",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id");
        }
    }
}
