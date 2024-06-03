using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_usedCount_medicine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Effect",
                table: "Medicines",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsedCount",
                table: "Medicines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3eb1855b-0b8f-483a-a39c-439fb381c1d7", "AQAAAAIAAYagAAAAEHnbCzO3GcBkHKhrpGDs8YUHFTFaYON866RIcShYktLNZXDDt6Msgsj93Eq3XoHN9w==", "292ce9be-fb38-4564-8fe2-15115099dab0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c4992094-4934-44bf-a14c-7ef8c1643a1b", "Isaiah_Keeling81@hotmail.com", "Shanelle Feest", "ISAIAH_KEELING81@HOTMAIL.COM", "HS2022584", "AQAAAAIAAYagAAAAELILjG6ZzXGsn5Wz+AgJ+d4XeLBhlMxbVBUPgEWMBmhC2rNM5PmvQten8YSLq2XVpw==", "2db7c01a-ab59-4e19-a8ef-2a2ffcbb3577", "HS2022584" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0045b136-0931-4891-bcb0-04a57ec9e844", "Greg36@hotmail.com", "Madelyn Anderson", "GREG36@HOTMAIL.COM", "HS2023224", "AQAAAAIAAYagAAAAENN5j6PfqCQULvo8SZRKk8aQm1D0zsygR3ly57tJsJLApMTzUF0wszBLZR1lcTwmGQ==", "18bf591b-cfe7-4fb5-a71d-973a847c1eee", "HS2023224" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "654e642d-0549-4f68-b951-6b6f37fd40c3", "Cristian18@gmail.com", "Otho Wiza", "CRISTIAN18@GMAIL.COM", "HS2023218", "AQAAAAIAAYagAAAAEJT1V+Hn6z3BZfNTjvmxsVl6C8skzA4UByZZ0viIib2qZ5k78W/k+PuaCdJdyzO1YA==", "7d2fec3c-91f5-42ab-b91c-047baea95964", "HS2023218" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e1ce2a53-10d9-4d1f-a711-125d66b900bf", "Candace48@gmail.com", "Forrest Kunze", "CANDACE48@GMAIL.COM", "HS2022444", "AQAAAAIAAYagAAAAEKwLzn1kN5RCWdAx593N2T1M4Ua1eWVaVonVQ/NR7tThW3p6iYUOp3NL6eAUdD/AwA==", "7b26e5e2-1c4e-42ef-b91e-0a383fc467e4", "HS2022444" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1cbd8f0a-1da2-415b-aaa0-507abbfddbd9", "Berry.Kirlin70@yahoo.com", "Marcel Ortiz", "BERRY.KIRLIN70@YAHOO.COM", "HS2021443", "AQAAAAIAAYagAAAAEPTHn89Us8I2/WChQkylUEQ8eOzIpOfhFBok6xJjW7HEbnyUsTD3u2xAJtg5d/NXRw==", "0a6b05b4-80b7-4172-97d3-b3b19ecc5c25", "HS2021443" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f9b01e2b-8c51-4bc0-9b22-42e1c2e4eea6", "Emile_Fadel51@gmail.com", "Mohammad Farrell", "EMILE_FADEL51@GMAIL.COM", "HS2023431", "AQAAAAIAAYagAAAAENMrVrCxBQiqofUqdbPPLXJxuqtFmQy2SzD4JhL6PDRRO5km2bIK0mcj1cltnGV7ww==", "8404b0c5-0343-4320-89c7-3bc1e79a3320", "HS2023431" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4b54252e-a9b4-43e4-8cfe-2b035c6b0862", "Agnes.Wunsch@yahoo.com", "Maryse Hessel", "AGNES.WUNSCH@YAHOO.COM", "HS2021959", "AQAAAAIAAYagAAAAEHJw25BeHBivshhg7zXu7Ac8vP7PfpVAdJkvCSkeWOWb6e1M+2ldWitfQagPHmO95w==", "9dfe423b-7a19-40f6-98cd-a7171f619210", "HS2021959" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "451b951f-e643-4908-a646-9c702329e488", "Savannah.Lockman@gmail.com", "Harley Bosco", "SAVANNAH.LOCKMAN@GMAIL.COM", "HS2020415", "AQAAAAIAAYagAAAAEFkzdvXorXrUxup8OcDwDTuWcWrtikWsipzU69tJoyE3BY2F+YvFkEla8MRwPyu9RQ==", "200664e4-da5f-486a-8cb9-19af80d91915", "HS2020415" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d7d6f49d-5819-4ce5-abdf-67c1c2abaef9", "Hazle.Greenfelder68@yahoo.com", "Brandi Botsford", "HAZLE.GREENFELDER68@YAHOO.COM", "HS2023614", "AQAAAAIAAYagAAAAENLcPFRZzNk5aySPK9ykTQuwMDis2JJcluQ2x74bMB/3Pa6b2CyRJx3PZi+UIeon7g==", "4df974a2-9bf0-4e09-aa29-13d63d61c23d", "HS2023614" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fc2774cc-5070-4369-81a8-0c16a02f75a7", "Erick90@hotmail.com", "Caden Pagac", "ERICK90@HOTMAIL.COM", "HS2021436", "AQAAAAIAAYagAAAAEG80jKYd8beUO4q2YS4lLX7JqFRI+0WvBTHL5a3TOUClfWjBBnAKK58hMXBogLPimA==", "08dc9afd-523a-45a4-84ab-adce22dcf995", "HS2021436" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "61826 Bergstrom Parkway, West Milesfurt, Kuwait", new DateTime(2016, 2, 27, 14, 31, 17, 492, DateTimeKind.Unspecified).AddTicks(8183), true, "HS2022584" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "487 Kenny Wall, Predovicview, Qatar", new DateTime(2012, 7, 29, 1, 56, 32, 706, DateTimeKind.Unspecified).AddTicks(9497), false, "HS2023224" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "71455 O'Hara Springs, Lake Boville, Macedonia", new DateTime(2009, 3, 10, 20, 54, 4, 236, DateTimeKind.Unspecified).AddTicks(3562), "HS2023218" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "9932 Liliane Villages, North Loriview, Costa Rica", new DateTime(2014, 7, 5, 0, 35, 27, 160, DateTimeKind.Unspecified).AddTicks(2950), "HS2022444" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "531 Bechtelar Center, West Madisyn, Uganda", new DateTime(2010, 11, 28, 9, 46, 31, 571, DateTimeKind.Unspecified).AddTicks(1508), false, "HS2021443" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "802 McCullough Gateway, Lake Tina, Honduras", new DateTime(2009, 11, 23, 4, 28, 54, 991, DateTimeKind.Unspecified).AddTicks(1964), true, "HS2023431" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "598 Rudolph Run, Lake Colleenview, Tajikistan", new DateTime(2014, 6, 25, 7, 26, 32, 535, DateTimeKind.Unspecified).AddTicks(8176), "HS2021959" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "8790 Irving River, South Mikel, Iceland", new DateTime(2009, 11, 22, 14, 10, 38, 117, DateTimeKind.Unspecified).AddTicks(8286), "HS2020415" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "81423 Destini Burg, Gorczanymouth, Saudi Arabia", new DateTime(2009, 9, 28, 12, 58, 40, 419, DateTimeKind.Unspecified).AddTicks(6024), "HS2023614" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "87804 Jessica Square, Lake Samara, Azerbaijan", new DateTime(2013, 1, 27, 1, 25, 8, 747, DateTimeKind.Unspecified).AddTicks(7610), true, "HS2021436" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsedCount",
                table: "Medicines");

            migrationBuilder.AlterColumn<string>(
                name: "Effect",
                table: "Medicines",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

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
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "94437 Schmitt Island, Teaganport, Saint Barthelemy", new DateTime(2011, 11, 17, 17, 4, 24, 388, DateTimeKind.Unspecified).AddTicks(6118), false, "HS2021925" });

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
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "96331 Verdie Center, Bechtelarberg, Finland", new DateTime(2008, 3, 11, 20, 26, 10, 90, DateTimeKind.Unspecified).AddTicks(5555), "HS2020102" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "5345 Hilll Stream, Larrymouth, Guam", new DateTime(2014, 11, 18, 12, 38, 48, 281, DateTimeKind.Unspecified).AddTicks(3419), "HS2021365" });

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
    }
}
