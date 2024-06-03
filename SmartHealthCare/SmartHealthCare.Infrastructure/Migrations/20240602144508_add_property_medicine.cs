using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_property_medicine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ExpDate",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ImportDate",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57787e4c-78c3-48b8-a7e2-6aee0ce702f2", "AQAAAAIAAYagAAAAEHTL9ctYYsT0qD65JIfi2cPq6JxkHwmeEppy+IsNbtAF9TTX9O+ntW+oPoUb+2yAQw==", "5431d79d-9fc4-46d0-93ed-e9767d7f62ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8445657c-6f97-4368-89c2-a08d95d126d1", "Bryon63@yahoo.com", "Lina Lesch", "BRYON63@YAHOO.COM", "HS2022937", "AQAAAAIAAYagAAAAEBNOcyWowkdOzOPdpbMyzQlGezTfh6qyyefNWNQMKJ/fU+pGpJYicLCJJBJTH4+T6A==", "0891f46f-f564-44e2-b50b-bba9126fde70", "HS2022937" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "466e2c3d-084c-4dc5-aff3-399b21ea21de", "Charlene.Beatty87@gmail.com", "Justice Shanahan", "CHARLENE.BEATTY87@GMAIL.COM", "HS2023150", "AQAAAAIAAYagAAAAEM/ubh/vpSD8qOHRHC6IJxYYl+ZyyFrdRIu0GAKKt4N0ywxpV4TYm/lh0wMjYrls4Q==", "fbc8c1bd-334d-4ce8-8ebd-b447c7c57e1c", "HS2023150" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "143410b6-d924-420d-85d9-f64be2477a8a", "Thurman.Kuhic@yahoo.com", "Kara Hauck", "THURMAN.KUHIC@YAHOO.COM", "HS2020112", "AQAAAAIAAYagAAAAEBihzuglW2TBUltetU26VfDgBuR055OPX2nurOk5FS1RWNUuEHbOtgn4DJUzdj5ywQ==", "7ef3e6ac-9155-4266-b0de-68aa01d62d62", "HS2020112" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "48489536-e58c-4ec9-be6e-3bbddd26ff20", "Obie.Kling28@yahoo.com", "Dejon Bashirian", "OBIE.KLING28@YAHOO.COM", "HS2023302", "AQAAAAIAAYagAAAAELVSewVXYOwHXxvyYDUh+aSucEMM+qhlq8tSGX8rvLTMe0LRfUTTose3h/UtdTetZQ==", "e927f747-3ab7-49bb-8871-a57ac87a3651", "HS2023302" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cc5f0c97-6b82-4e50-a584-a973c5527ad9", "Joaquin67@gmail.com", "Margarete Heidenreich", "JOAQUIN67@GMAIL.COM", "HS2021343", "AQAAAAIAAYagAAAAECn+324PkO0xXFxf7+Cc2RSJkGT4e3A3FY5pwbzbPv0BDueGUUbA+abyf/X54hX4WA==", "40937428-1a0e-4945-a117-996ce8c713e6", "HS2021343" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b375bd4f-4d94-452a-8362-6c5b51dc13d2", "Alyson_Bahringer32@hotmail.com", "Katharina Gaylord", "ALYSON_BAHRINGER32@HOTMAIL.COM", "HS2020104", "AQAAAAIAAYagAAAAEEvTXeJcAQBQ359gp/0+9eQPfvxT3kBoBWYV3Vs6i+62GzRK1XiQHmmc/fQr9/Dd2w==", "321d9498-3637-4ffc-85ec-8665464c159f", "HS2020104" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f3a8ec03-1df9-4957-af4e-f4884ebdb5be", "Kathryn.McKenzie54@hotmail.com", "Rozella Lubowitz", "KATHRYN.MCKENZIE54@HOTMAIL.COM", "HS2023466", "AQAAAAIAAYagAAAAEEuyf4TOkpGltuTWMFvgTcj48kgGBp7JzX5u/L1I9fiqV7SnSwLpFz+6fb+og64wlA==", "8eaf04cb-39a9-46b9-9474-ba4247a88a03", "HS2023466" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "62066ce6-2ca2-4bc3-826d-97a9b71a2085", "Delta40@yahoo.com", "Kadin Ruecker", "DELTA40@YAHOO.COM", "HS2020977", "AQAAAAIAAYagAAAAEGeU10ucSgfzXeM0P5Ibwvdpdvt5ETApKiV563U2TKwP+WhkpdccUThAs7N1J7P1lA==", "04a72a06-d78b-4dc3-a9f4-2f82e4bd23da", "HS2020977" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e2594850-60c3-448d-9c2d-77c3201ebf26", "Carolyne.Predovic41@gmail.com", "Felipe Corkery", "CAROLYNE.PREDOVIC41@GMAIL.COM", "HS2022109", "AQAAAAIAAYagAAAAEKbRBH1XvvMNoagL7XGpKpu4LILiDDFJG8kKeXMBgjPE9fd/DChh8yETsn7YpSaQUQ==", "44569b7f-209b-4d64-9971-35743b8db78b", "HS2022109" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1a55ee47-8cab-4b55-b46b-8ee52663136b", "Mason.Schowalter86@hotmail.com", "Jayde Skiles", "MASON.SCHOWALTER86@HOTMAIL.COM", "HS2022675", "AQAAAAIAAYagAAAAEE7q/h4tQmIgvQmJZoBGVUqUxZhXmyZsMYxoY98GchPOFvN47fTRxDLrte3Fx5T/TQ==", "9d574c05-330f-4821-8ea4-afb38409f6a7", "HS2022675" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "27256 Hansen Cape, Caylaside, Falkland Islands (Malvinas)", new DateTime(2018, 7, 5, 23, 20, 51, 52, DateTimeKind.Unspecified).AddTicks(6450), false, "HS2022937" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "7167 Tyrese Parkway, North Ottis, Sri Lanka", new DateTime(2017, 4, 4, 5, 41, 14, 176, DateTimeKind.Unspecified).AddTicks(3189), false, "HS2023150" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "87016 Talia Springs, New Orlandside, South Africa", new DateTime(2011, 2, 22, 2, 1, 21, 644, DateTimeKind.Unspecified).AddTicks(2548), "HS2020112" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "0630 Jast Inlet, Lake Zeldaview, Denmark", new DateTime(2011, 3, 31, 0, 30, 17, 57, DateTimeKind.Unspecified).AddTicks(4718), "HS2023302" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "45281 Rodriguez Walks, Lake Donavonton, Nauru", new DateTime(2008, 2, 25, 1, 23, 34, 795, DateTimeKind.Unspecified).AddTicks(2279), false, "HS2021343" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "0891 Conroy Coves, East Christelle, Yemen", new DateTime(2012, 12, 14, 5, 21, 25, 590, DateTimeKind.Unspecified).AddTicks(3289), true, "HS2020104" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "485 Bailey Brook, East Othaville, Malaysia", new DateTime(2009, 8, 22, 5, 17, 57, 565, DateTimeKind.Unspecified).AddTicks(2328), "HS2023466" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "436 Hollis Ports, Westleyshire, Congo", new DateTime(2009, 7, 23, 20, 54, 52, 387, DateTimeKind.Unspecified).AddTicks(8834), "HS2020977" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "972 Emard Village, Collinstown, Congo", new DateTime(2008, 12, 2, 22, 23, 56, 335, DateTimeKind.Unspecified).AddTicks(5256), false, "HS2022109" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "499 Swaniawski Pine, Adrielbury, Eritrea", new DateTime(2018, 6, 9, 0, 6, 52, 65, DateTimeKind.Unspecified).AddTicks(7475), true, "HS2022675" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpDate",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "ImportDate",
                table: "Medicines");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5a7d47f-b393-4a35-aa50-19acf1e75c4e", "AQAAAAIAAYagAAAAED25TdgEROy7/3rOTE0Q709ulPk4etrtURFV3DDP7o5qPfeSsVHaEwRNLTjJ+/NOew==", "3f20af03-e399-4216-9a87-bd72a92e95a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "effd5985-977a-44c4-ac6b-fbff9f3704ea", "Stuart_Jaskolski50@hotmail.com", "Emily Heathcote", "STUART_JASKOLSKI50@HOTMAIL.COM", "HS2021867", "AQAAAAIAAYagAAAAENdAVU/lQx/R4vunjLALfBK057LQD0KjRPtql8SXBy42h6ccuKOud2oBYahbJM1wTg==", "987ecb3d-c76f-4e48-aade-348b299c705d", "HS2021867" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "455e0210-05e0-4368-b1f5-74fd0b22dd52", "Ayden24@gmail.com", "Alysson McDermott", "AYDEN24@GMAIL.COM", "HS2021844", "AQAAAAIAAYagAAAAEPkjejBz0FhZQwuYci4jWmrn3z3d0/Eioh3478Rkw9BpcB70bWx9t7xJYkvfC6G6Rg==", "839a0899-0e76-4e13-8fe3-0ee8bf62f67e", "HS2021844" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ab668ee6-87d9-4823-a89d-d19206364631", "Elena11@hotmail.com", "Stanton Cruickshank", "ELENA11@HOTMAIL.COM", "HS2022320", "AQAAAAIAAYagAAAAEJAjyqpBVPL5sUNSqfebs0OpS9Lneec7zaYyfs6z9LjqaZazfeT4HjH5RpLx5D2c2w==", "3c96324d-b8e0-4eeb-9b50-f4c7ab05a404", "HS2022320" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ab12240d-7570-4844-af25-054452002559", "Arturo54@gmail.com", "Hobart Klocko", "ARTURO54@GMAIL.COM", "HS2023505", "AQAAAAIAAYagAAAAEKBofNrcVS95oo6xs47ktdDzUaQTrp0QH8sx9kEDMZvcAwjIk+Pts9nCXkyPPE9oPg==", "9d003780-795c-451b-85b5-e4bd9f52e655", "HS2023505" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2d3f6c95-c4e6-462e-b3f7-c4abd4e47d2d", "Dangelo.Bahringer77@hotmail.com", "Ewell Gislason", "DANGELO.BAHRINGER77@HOTMAIL.COM", "HS2020423", "AQAAAAIAAYagAAAAEDp9pMiyFM7WubXQjN2xGe5ES2VOYpkg7dStJEtl4EF2kDmAGER+2uwo4i+zReJbdQ==", "c0fdf8a6-08e9-4051-9637-284185ef0618", "HS2020423" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cc872f95-2e78-44be-81ff-3560eac2fd53", "Adalberto45@hotmail.com", "Brycen Pacocha", "ADALBERTO45@HOTMAIL.COM", "HS2020698", "AQAAAAIAAYagAAAAEPV6cigNt1m8Ez25Ouv8Tr+Ap6IZl9iVLYirpWd9cSBpR3mpzXSy7L1TMgFkrOPyGg==", "336b9135-0c94-4816-96c5-3b7f63372f4d", "HS2020698" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2fdaeb6b-cba2-4e58-8b21-960804c24ee2", "Ellie.Hilpert95@yahoo.com", "Otha Heaney", "ELLIE.HILPERT95@YAHOO.COM", "HS2023931", "AQAAAAIAAYagAAAAEBgrsjhadclCjgLyZzPMIn4qHBKYJVPAqtf/Aio4R8tPtbUqvyw/V/o/mrBlyGEKRw==", "47552f79-9804-41c9-9ed7-c08afc2c7333", "HS2023931" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "974b6ad9-81aa-402b-ae0c-dd67d0de5793", "Ike.Walter@gmail.com", "Damien Christiansen", "IKE.WALTER@GMAIL.COM", "HS2023609", "AQAAAAIAAYagAAAAEJqe2rL2fSqjZR/adwQec4m1FcM2goQRnJQHctQrezjOFVbai6C9P45cNeqW0uCR2w==", "777b505b-2711-47e6-a065-926069a8447c", "HS2023609" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ec914a93-11dd-48f6-b040-1b2e968298f8", "Ozella.Ondricka@hotmail.com", "Ola Torp", "OZELLA.ONDRICKA@HOTMAIL.COM", "HS2020275", "AQAAAAIAAYagAAAAEKuRG/XDGjuyMFJx5W/8KUCV7qZomizC4h19d7J4WQibu+cbUUntZ7j3ZTWrSbm9MA==", "72518e7b-435e-42c0-a28b-5167cf9050d5", "HS2020275" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1e77711f-e952-4ac9-ad28-15b901e5494c", "David_Windler@hotmail.com", "Maureen Torphy", "DAVID_WINDLER@HOTMAIL.COM", "HS2020064", "AQAAAAIAAYagAAAAEHFrazSs3olB/qnSXS+l4Dwe6B9YzdU8YnTGMH2UdLuTXERMAQgLKJDC8Hfj3aWLcw==", "6f0ba570-0a65-4ecb-bc69-bfe39d84d04f", "HS2020064" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "4325 Dagmar Squares, Kerlukeborough, Costa Rica", new DateTime(2011, 8, 22, 18, 7, 1, 727, DateTimeKind.Unspecified).AddTicks(5366), true, "HS2021867" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "1931 Torrance Harbors, Eunicemouth, Brazil", new DateTime(2012, 8, 31, 13, 40, 29, 240, DateTimeKind.Unspecified).AddTicks(6587), true, "HS2021844" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "330 Beer Square, Denesikstad, Poland", new DateTime(2011, 4, 2, 0, 53, 11, 469, DateTimeKind.Unspecified).AddTicks(3239), "HS2022320" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "5664 Crona Cape, South Colinton, Chile", new DateTime(2010, 12, 21, 13, 36, 59, 540, DateTimeKind.Unspecified).AddTicks(6800), "HS2023505" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "7799 Loyal Prairie, Maychester, Netherlands Antilles", new DateTime(2010, 3, 8, 12, 8, 39, 620, DateTimeKind.Unspecified).AddTicks(6589), true, "HS2020423" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "49687 Schumm Springs, New Tyra, Honduras", new DateTime(2010, 5, 8, 6, 58, 16, 410, DateTimeKind.Unspecified).AddTicks(1833), false, "HS2020698" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "75313 Swift Summit, Lake Gina, Mali", new DateTime(2008, 9, 23, 4, 30, 26, 760, DateTimeKind.Unspecified).AddTicks(9323), "HS2023931" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "646 Odell Trail, Wolffville, Central African Republic", new DateTime(2013, 8, 10, 23, 48, 38, 336, DateTimeKind.Unspecified).AddTicks(2425), "HS2023609" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "18646 Benton Points, Lake Jeanette, Antarctica (the territory South of 60 deg S)", new DateTime(2012, 2, 14, 10, 9, 34, 158, DateTimeKind.Unspecified).AddTicks(7737), true, "HS2020275" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "05223 Otis Stream, Barrowsstad, Guatemala", new DateTime(2012, 1, 25, 23, 48, 16, 56, DateTimeKind.Unspecified).AddTicks(817), false, "HS2020064" });
        }
    }
}
