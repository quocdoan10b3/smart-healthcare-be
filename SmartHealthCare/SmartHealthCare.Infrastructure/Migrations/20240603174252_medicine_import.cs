using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class medicine_import : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpDate",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "ImportDate",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "UsedCount",
                table: "Medicines");

            migrationBuilder.AlterColumn<string>(
                name: "Effect",
                table: "Medicines",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "Histories",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

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
                    MedicineId = table.Column<int>(type: "int", nullable: false)
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
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af1617cb-0735-44d6-bd4e-e103fe84cb8a", "AQAAAAIAAYagAAAAECGAvtq/X4k1BAEY8M3NwyTIQXO0lxI42gzgxqQAtcCBAASFnNbPOR7wh9Oy7tbfMA==", "da103fa3-e574-4e36-af1a-3bca52a8f98d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f26bf51e-f341-4c94-98a9-b6d39636f7b4", "Lizzie91@gmail.com", "Annamarie Luettgen", "LIZZIE91@GMAIL.COM", "HS2021012", "AQAAAAIAAYagAAAAEMHlJgJqL57F2cq87R7RmV5T78uRh9pp8u+YZ4GW7b0yAGIQv3t6aV3tEEbiYsQ45A==", "464e701f-4641-4a92-a2e1-270f7e2a524a", "HS2021012" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0023d56e-f11a-4d36-9818-2d03e855bdbe", "Ubaldo15@hotmail.com", "Ramon White", "UBALDO15@HOTMAIL.COM", "HS2021816", "AQAAAAIAAYagAAAAEM4dsgOmsApe7LyBE2N9oTJD6TqQDmjIinq8nq7Zh2GeznbTqeghJRBhxD5VdBf/zg==", "5659a0ee-6a1f-403a-998d-e9baeba7c479", "HS2021816" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "05be68bb-4b68-4fe6-8caf-3d8aa04b463c", "Elena29@yahoo.com", "Keegan Schneider", "ELENA29@YAHOO.COM", "HS2022722", "AQAAAAIAAYagAAAAEMHUb6BNFweHprlUPQ42/td2xIjLYmJqMehS38D4WsWU3TcELOnZvBrPb33tbf9OZA==", "1b811a70-9aee-4f61-81f7-3b3ea1dad895", "HS2022722" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bdd94064-c5af-4758-9d7b-b1050ca44508", "Precious.Mann97@hotmail.com", "Vicente Rodriguez", "PRECIOUS.MANN97@HOTMAIL.COM", "HS2023157", "AQAAAAIAAYagAAAAEHbZu74WCNxHn8pR80aNAUqxqTKqqzaIuXp+ElwgQj1/SAhNYsVqQhLfFP8bYceuCA==", "384c70f0-e163-4aa6-989c-a3143a7b2791", "HS2023157" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "24deafaf-05de-4b58-b22a-958fe476b673", "Krystel.Friesen72@yahoo.com", "Gloria Powlowski", "KRYSTEL.FRIESEN72@YAHOO.COM", "HS2021901", "AQAAAAIAAYagAAAAENnkTwsnLGOOu0S/VdbsGkuqAg0MTTNRjBGdtdE+XkqEJXbULLgUyY2cno/GCsJ1Lw==", "60837039-2b29-4256-947d-2185da614820", "HS2021901" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "21b8cae1-ac5c-42cc-8f1d-63340e98d36c", "Angelita_Schneider@hotmail.com", "Shanna Crona", "ANGELITA_SCHNEIDER@HOTMAIL.COM", "HS2021213", "AQAAAAIAAYagAAAAEICHawrUMXJB1vsYRH02Ziz2bJKVfMwyK8qLToVYxkgCazy2MS9aB4nrUojxFAJS4g==", "5bcd559a-0d26-4c34-9efe-00244a182249", "HS2021213" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2e8a5311-d693-4792-8ead-ab2c24f0897f", "Warren16@yahoo.com", "Hester Stark", "WARREN16@YAHOO.COM", "HS2021737", "AQAAAAIAAYagAAAAEBClsHYAzcWVYGURZA7aM3jtcFpMZslUpsFvxcZlOdouDh6Nfw19IOsRA7tBB1CXqQ==", "1b95c23c-3f91-41bf-8789-78537f6892b8", "HS2021737" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "24db54af-4a97-4e3b-8340-cbef7acda42d", "Krista.Schneider@yahoo.com", "Delores Connelly", "KRISTA.SCHNEIDER@YAHOO.COM", "HS2021930", "AQAAAAIAAYagAAAAEOdC6OThe5QOWDxyqjnwIBET+BklW4g9umZjrvwlrnnZugBF7OJ8An0SvCioRjRs0A==", "1fde3b21-d593-4d90-8f21-ac3e88d9ac72", "HS2021930" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8fb1120a-3a46-49c0-a268-b5421a2d3ab5", "Norris.Hintz95@gmail.com", "Adella Daniel", "NORRIS.HINTZ95@GMAIL.COM", "HS2023605", "AQAAAAIAAYagAAAAEMHXU5NP6YLq00fV8fdStthKXAzOgzl1gyoHYM4orbNqevoPpHOkhQs7elpgtgRnXg==", "0a24c91f-8c18-4ef2-aaf1-51982a1f4bf8", "HS2023605" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "584c31c6-cae9-44b4-9448-ce076f24d41b", "Maribel34@gmail.com", "Orlo Fahey", "MARIBEL34@GMAIL.COM", "HS2021907", "AQAAAAIAAYagAAAAEFLHL9OS0MfBSynmd0Xf9VARxePrNvrvbciLeJaH5iS/Xa5xx99zzEu0b0Zdm2fo8w==", "2287eb11-c569-4ada-af91-9139686ac0b3", "HS2021907" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "34828 Moore Field, West Mozelle, Panama", new DateTime(2015, 8, 3, 8, 35, 40, 232, DateTimeKind.Unspecified).AddTicks(1562), false, "HS2021012" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "2230 Heathcote Drive, South Lamar, Tunisia", new DateTime(2011, 11, 16, 14, 31, 42, 384, DateTimeKind.Unspecified).AddTicks(7196), true, "HS2021816" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "463 Jaycee Roads, Port Gregoria, Venezuela", new DateTime(2010, 6, 11, 19, 7, 12, 776, DateTimeKind.Unspecified).AddTicks(1604), "HS2022722" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "24638 Welch Extension, Lake Jeromemouth, Cyprus", new DateTime(2017, 11, 19, 22, 41, 9, 4, DateTimeKind.Unspecified).AddTicks(741), true, "HS2023157" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "999 Electa Keys, Marcelinomouth, Turkey", new DateTime(2009, 12, 31, 12, 40, 36, 78, DateTimeKind.Unspecified).AddTicks(661), true, "HS2021901" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "371 Lorna Square, Lake Ivory, Hong Kong", new DateTime(2011, 1, 1, 20, 35, 23, 116, DateTimeKind.Unspecified).AddTicks(5521), false, "HS2021213" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "88941 Bessie Village, New Marcia, Fiji", new DateTime(2014, 7, 3, 17, 22, 17, 527, DateTimeKind.Unspecified).AddTicks(6171), "HS2021737" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "783 Langosh Rapid, Kasandrahaven, Austria", new DateTime(2012, 7, 2, 5, 3, 19, 89, DateTimeKind.Unspecified).AddTicks(3542), true, "HS2021930" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "33077 Roselyn Isle, Neldaville, Finland", new DateTime(2008, 8, 29, 4, 11, 59, 35, DateTimeKind.Unspecified).AddTicks(7122), "HS2023605" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "75379 Torp Shores, Champlinchester, Western Sahara", new DateTime(2018, 3, 2, 12, 56, 45, 563, DateTimeKind.Unspecified).AddTicks(2250), "HS2021907" });

            migrationBuilder.CreateIndex(
                name: "IX_MedicineImport_MedicineId",
                table: "MedicineImport",
                column: "MedicineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicineImport");

            migrationBuilder.AlterColumn<string>(
                name: "Effect",
                table: "Medicines",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Medicines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsedCount",
                table: "Medicines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "Histories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 5000,
                oldNullable: true);

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
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "9932 Liliane Villages, North Loriview, Costa Rica", new DateTime(2014, 7, 5, 0, 35, 27, 160, DateTimeKind.Unspecified).AddTicks(2950), false, "HS2022444" });

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
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "8790 Irving River, South Mikel, Iceland", new DateTime(2009, 11, 22, 14, 10, 38, 117, DateTimeKind.Unspecified).AddTicks(8286), false, "HS2020415" });

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
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "87804 Jessica Square, Lake Samara, Azerbaijan", new DateTime(2013, 1, 27, 1, 25, 8, 747, DateTimeKind.Unspecified).AddTicks(7610), "HS2021436" });
        }
    }
}
