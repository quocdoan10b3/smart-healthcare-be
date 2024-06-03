using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_property_image_medicine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageMedicine",
                table: "Medicines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa199d9d-8a20-4a62-8b30-fa8e85b9cc37", "AQAAAAIAAYagAAAAECK4h0ACqRI7MzKhAII1ZG505SwUvW/B2HU9kPdg06yPw0vs8HsAPqS7bS8ewwn+nA==", "02754361-beca-4fbc-a85b-6924d17f3c1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3e880ffb-9298-41dc-98eb-7cc1393270d5", "Maverick62@gmail.com", "Deangelo Fisher", "MAVERICK62@GMAIL.COM", "HS2021925", "AQAAAAIAAYagAAAAEHNZzk4uupEka901yvYQehcPBKREEI0NdvtT8AwjIzHshQe3Re8DGWHsJxX1oNA+HA==", "9d95697e-125f-4cd3-bff3-99fd7ba1c9c5", "HS2021925" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7dd33481-85ed-426f-907b-95001632520b", "Lance_Barton@gmail.com", "Jude Trantow", "LANCE_BARTON@GMAIL.COM", "HS2021312", "AQAAAAIAAYagAAAAEEgwFaZxIg6uspmSrr0zlqvZw3QWH1vfczmH5JLSZO8G4DX78IuN0Ej/7dFof2wA0A==", "a949ca0f-c4cf-4ec9-b324-2390b79415a9", "HS2021312" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3eb1d8d7-f23e-48e2-b557-14fed4af6272", "Teresa_Larkin22@yahoo.com", "Melany Davis", "TERESA_LARKIN22@YAHOO.COM", "HS2020102", "AQAAAAIAAYagAAAAEBweI2nL5yZXc1d+OPP5ywbAxt1me1S7poJgoKtMf3U/odZ9ylgG1PwuOq2um4eF6g==", "bcd14695-dd39-46e2-b2de-a3fe39bda277", "HS2020102" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "452c2027-6527-414c-9b6c-5a1ba87dabc5", "Davin.Jenkins12@yahoo.com", "Gilda Wyman", "DAVIN.JENKINS12@YAHOO.COM", "HS2021365", "AQAAAAIAAYagAAAAEBn8XLw4U62nMSivXSS837lva27aZ8o0kBIZL9d6kQiM4Vuo+kgY3I/2jjCPdvAVkw==", "7ec51d88-2fce-4f3c-82e6-79bf564001cf", "HS2021365" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cfe7444f-7f0e-4190-967a-9f132afac9fb", "Erica.Haag@hotmail.com", "Mikel Leffler", "ERICA.HAAG@HOTMAIL.COM", "HS2021081", "AQAAAAIAAYagAAAAEFc1VyTh2+BQAtw1pGNbTFEKadjA2jeX+mzevx14oD4yJ45cWYRpEB8wBMc8AMLZYQ==", "abb4da86-828a-42d7-a027-84ded01257cd", "HS2021081" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b267dcec-0d5b-40c7-ae68-7b618c99bb91", "Agnes.DuBuque86@yahoo.com", "May Rice", "AGNES.DUBUQUE86@YAHOO.COM", "HS2022166", "AQAAAAIAAYagAAAAENvo4zUxS6cBgePE52Hs+o7X2/DAewg7jSgDcX4skRBYIBvdkip/aYgIxpH01sc+DQ==", "0175b9df-480b-4aec-9d3b-95e0bf192286", "HS2022166" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "17825feb-b0c5-4844-91d3-0a8913d080ef", "Maximilian_Maggio89@hotmail.com", "Elsie Schamberger", "MAXIMILIAN_MAGGIO89@HOTMAIL.COM", "HS2022192", "AQAAAAIAAYagAAAAEJUl2Tlkeapj+Bi1YijhkDXKRLCPfOVKuUuc8IBB8/GB/Dp3EsfLqBFcWKqvgqyXag==", "6d55f3a1-3696-428c-b4ed-2d31bca3d5b2", "HS2022192" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ad293b60-d539-43ed-9066-e88040e3cac0", "Freddie75@gmail.com", "Helena Stoltenberg", "FREDDIE75@GMAIL.COM", "HS2020269", "AQAAAAIAAYagAAAAEGUTkKDY15V02JLDdk8VAdZmUKyBD3wBArqySzkGXF70zLsF+c/PhNGITwkxTGai6g==", "5ac139d8-fbc9-4e84-9865-fd9f733766c6", "HS2020269" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "29c174c2-6a4a-4bb1-a5f5-7276ac4d6b93", "Marta.Howe8@gmail.com", "Jeramie Shields", "MARTA.HOWE8@GMAIL.COM", "HS2023140", "AQAAAAIAAYagAAAAEOwxTaZJqei5S0OQ8aVcbvmoUNIbNEiqlRIiAojTaHp4fOpuTej3djA35fhMtE/gaQ==", "0233a65f-e6d8-438b-8227-0aedf28b1765", "HS2023140" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "90737ca2-e67f-408b-b87c-d97b17f24814", "Anahi57@gmail.com", "Elisa Green", "ANAHI57@GMAIL.COM", "HS2022165", "AQAAAAIAAYagAAAAEPYOzER455GXdHbHFUHLAZW59hMi9s05pAkyTPrvkfQO5EWrrUitzVMRbUH5KyaHLQ==", "0f466ada-8faf-4804-8ad6-e62469230704", "HS2022165" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "94437 Schmitt Island, Teaganport, Saint Barthelemy", new DateTime(2011, 11, 17, 17, 4, 24, 388, DateTimeKind.Unspecified).AddTicks(6118), "HS2021925" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "083 Farrell Hollow, Harveyland, Christmas Island", new DateTime(2011, 12, 28, 14, 28, 37, 301, DateTimeKind.Unspecified).AddTicks(5814), true, "HS2021312" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "96331 Verdie Center, Bechtelarberg, Finland", new DateTime(2008, 3, 11, 20, 26, 10, 90, DateTimeKind.Unspecified).AddTicks(5555), true, "HS2020102" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "5345 Hilll Stream, Larrymouth, Guam", new DateTime(2014, 11, 18, 12, 38, 48, 281, DateTimeKind.Unspecified).AddTicks(3419), false, "HS2021365" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "09156 Spencer Fords, New Allenmouth, Libyan Arab Jamahiriya", new DateTime(2017, 12, 29, 10, 48, 13, 814, DateTimeKind.Unspecified).AddTicks(5617), true, "HS2021081" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "28508 Paucek Walk, South Connorfort, Puerto Rico", new DateTime(2010, 5, 11, 17, 55, 57, 197, DateTimeKind.Unspecified).AddTicks(3251), false, "HS2022166" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "61821 Amari Parks, Morganstad, Jordan", new DateTime(2015, 7, 5, 1, 28, 37, 537, DateTimeKind.Unspecified).AddTicks(4667), "HS2022192" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "263 Streich Manors, East Earleneville, Mozambique", new DateTime(2008, 8, 6, 15, 4, 57, 34, DateTimeKind.Unspecified).AddTicks(5082), "HS2020269" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "115 Leffler Lock, Jastchester, Liberia", new DateTime(2012, 7, 13, 13, 26, 49, 167, DateTimeKind.Unspecified).AddTicks(5492), "HS2023140" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "21786 Muhammad Street, North Marcel, Fiji", new DateTime(2015, 11, 20, 4, 16, 27, 383, DateTimeKind.Unspecified).AddTicks(9232), false, "HS2022165" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageMedicine",
                table: "Medicines");

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
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "27256 Hansen Cape, Caylaside, Falkland Islands (Malvinas)", new DateTime(2018, 7, 5, 23, 20, 51, 52, DateTimeKind.Unspecified).AddTicks(6450), "HS2022937" });

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
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "87016 Talia Springs, New Orlandside, South Africa", new DateTime(2011, 2, 22, 2, 1, 21, 644, DateTimeKind.Unspecified).AddTicks(2548), false, "HS2020112" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "0630 Jast Inlet, Lake Zeldaview, Denmark", new DateTime(2011, 3, 31, 0, 30, 17, 57, DateTimeKind.Unspecified).AddTicks(4718), true, "HS2023302" });

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
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "972 Emard Village, Collinstown, Congo", new DateTime(2008, 12, 2, 22, 23, 56, 335, DateTimeKind.Unspecified).AddTicks(5256), "HS2022109" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "499 Swaniawski Pine, Adrielbury, Eritrea", new DateTime(2018, 6, 9, 0, 6, 52, 65, DateTimeKind.Unspecified).AddTicks(7475), true, "HS2022675" });
        }
    }
}
