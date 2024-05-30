using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_property_feedBack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "FeedBacks",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CommentDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Response",
                table: "FeedBacks",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResponseDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a2a4ed8-3650-4622-9cc8-b1355645248e", "AQAAAAIAAYagAAAAEJ2oWxxDDjyQw5NP1GO2A3jM0lMyx9NUFnm76ZG1V2gbEYAa+m9VsXusQLF2qokzkA==", "62e4e0cd-9bf7-49ba-8299-00135c2b95f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "dc4ae790-b0b8-4e36-86e5-e6a701238c2d", "Jayda_Wunsch76@hotmail.com", "Dusty Gislason", "JAYDA_WUNSCH76@HOTMAIL.COM", "JAYDA_WUNSCH76@HOTMAIL.COM", "AQAAAAIAAYagAAAAEOxp1jhjGSvzM0dSeeCB90GKmnai4rdylEdsc4ea1JuKXqD47AFfy2SGOCM2td7N6g==", "c4fa5384-7ef7-4c14-9eec-c585f80f8652", "Jayda_Wunsch76@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9169f83a-dd98-4a10-b86d-43f3bc08331b", "Rowan_Lindgren@hotmail.com", "Robbie Greenfelder", "ROWAN_LINDGREN@HOTMAIL.COM", "ROWAN_LINDGREN@HOTMAIL.COM", "AQAAAAIAAYagAAAAELTeiZqn0O4miz5CurJPKYsVCzFumkGRFR0ukEt682QMtVY3Qr5L3V+xcOXk/4wwCA==", "51d22836-74fc-4328-b51a-b8ae48aac05a", "Rowan_Lindgren@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0f295219-eb51-4066-927d-5d2183ba1790", "Jaylin49@gmail.com", "Nasir Mills", "JAYLIN49@GMAIL.COM", "JAYLIN49@GMAIL.COM", "AQAAAAIAAYagAAAAEPe4Gh7KjdQ7hEfQ36SPYckjfEpb+gf8OYC6UKvTMEurvqn5gOg7x9ctH+iVuggM+g==", "0ce0bd1f-a774-40ee-bd67-1e29a9041755", "Jaylin49@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b74807d2-8102-4fca-9bc8-53adf483ef5a", "Name.Dickens@gmail.com", "Hester Ritchie", "NAME.DICKENS@GMAIL.COM", "NAME.DICKENS@GMAIL.COM", "AQAAAAIAAYagAAAAEMWECMLuPQTFe3gYCQiCzulcYG7bagggtJqaLUz3cylrz5+XOZJt3EdKqKDyOlek6A==", "1d0d1f95-7902-4d08-8c30-1532e0c133ac", "Name.Dickens@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b5a60c6c-0b24-4cee-92cf-aad603d597f0", "Dax4@yahoo.com", "Dale Runte", "DAX4@YAHOO.COM", "DAX4@YAHOO.COM", "AQAAAAIAAYagAAAAEK8yclNQuiU+PN8dSoG+v05lH8UOGGdAKk8bmJzFxphgoqLae7Ku3Ni3hvEaRCVE2A==", "4cad5a1f-03f1-4a04-a9b7-a93783f5b481", "Dax4@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a1aeceb4-aedf-46a0-919f-8350688623df", "Lance50@yahoo.com", "Nathan Oberbrunner", "LANCE50@YAHOO.COM", "LANCE50@YAHOO.COM", "AQAAAAIAAYagAAAAEAIO/e0iXDAeW2fr1oRmrqLINfON/colNvEduaOUSUddUbw6JL/bBEv0qstzpHx0vg==", "caf9bba8-f659-4509-b1bf-08ab2e23082d", "Lance50@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "78fdc457-d002-48ed-834b-7d5d5ff03497", "Lorenz.Jerde@yahoo.com", "Demetris Franecki", "LORENZ.JERDE@YAHOO.COM", "LORENZ.JERDE@YAHOO.COM", "AQAAAAIAAYagAAAAEAdCyiCiPF7gWO33IF3CJziKrr8FoseIL6517QuZ9ufeNeXwWPXqlc6OURsWq/Y6Qw==", "4f5830ee-80f1-423d-8c3b-47168616c6d3", "Lorenz.Jerde@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9ab8b63d-bb9f-4ca6-b972-5c7216af82b1", "Ayana_Lowe0@gmail.com", "Oren Robel", "AYANA_LOWE0@GMAIL.COM", "AYANA_LOWE0@GMAIL.COM", "AQAAAAIAAYagAAAAEBizPbDJ6ECRyjvxtSxDubgcKRTD72Jtex4TyOcFuDe9Yjp9NKF4qr0WxQFHAwSNCg==", "b7beabb6-5e48-43d8-8e97-1613f6d0b4dd", "Ayana_Lowe0@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9b66178c-8e2f-4276-8088-666bb02fdd87", "Jaclyn_Jenkins@yahoo.com", "Iliana Hickle", "JACLYN_JENKINS@YAHOO.COM", "JACLYN_JENKINS@YAHOO.COM", "AQAAAAIAAYagAAAAEH7BR68CCygr8pytaBF0hWea0xX4O08aegzPFVlhsVC9I3qAVxxheYj3askMPCFZJA==", "ee131d59-a9e2-427f-922d-78d562127364", "Jaclyn_Jenkins@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f7accdc9-aee7-4b18-891c-3397b1427bf8", "Rickey32@yahoo.com", "Carter Labadie", "RICKEY32@YAHOO.COM", "RICKEY32@YAHOO.COM", "AQAAAAIAAYagAAAAEFxXnWHn11OgZx3QRCqvXG1Tt6YRGdtjniniNiKu2yn8Eo0dpI/NzL4iRsfxCdkwtg==", "85c4c7ec-4d16-4005-a9f8-8aa1b9932b3d", "Rickey32@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "8881 Skyla Causeway, Lake Julien, Timor-Leste", new DateTime(2013, 11, 16, 16, 38, 31, 152, DateTimeKind.Unspecified).AddTicks(6218), false, "Jayda_Wunsch76@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "620 Bayer Track, Geovannyside, Lao People's Democratic Republic", new DateTime(2009, 9, 20, 18, 23, 48, 256, DateTimeKind.Unspecified).AddTicks(672), "Rowan_Lindgren@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "027 Morissette Lane, Strackestad, Montenegro", new DateTime(2014, 8, 13, 13, 59, 5, 800, DateTimeKind.Unspecified).AddTicks(1970), "Jaylin49@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "0019 King Pass, South Leolafort, Bouvet Island (Bouvetoya)", new DateTime(2010, 6, 29, 8, 4, 32, 44, DateTimeKind.Unspecified).AddTicks(8043), true, "Name.Dickens@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "650 Blanche Stravenue, Lake Reggieside, Saint Pierre and Miquelon", new DateTime(2014, 9, 7, 4, 48, 2, 20, DateTimeKind.Unspecified).AddTicks(286), "Dax4@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "3976 Schoen Estates, West Lura, Netherlands Antilles", new DateTime(2012, 11, 13, 17, 51, 32, 941, DateTimeKind.Unspecified).AddTicks(3342), "Lance50@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "04089 Freeman Well, Marcmouth, Saint Pierre and Miquelon", new DateTime(2010, 7, 30, 0, 8, 5, 291, DateTimeKind.Unspecified).AddTicks(6620), "Lorenz.Jerde@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "832 Verda Freeway, Port Morton, Bahamas", new DateTime(2009, 10, 9, 6, 24, 27, 313, DateTimeKind.Unspecified).AddTicks(6050), true, "Ayana_Lowe0@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "6141 Strosin Mall, Hailieton, Romania", new DateTime(2009, 4, 1, 22, 45, 9, 392, DateTimeKind.Unspecified).AddTicks(8808), "Jaclyn_Jenkins@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "006 Morris Loop, Jarodchester, Guinea-Bissau", new DateTime(2016, 2, 17, 16, 31, 59, 999, DateTimeKind.Unspecified).AddTicks(7361), false, "Rickey32@yahoo.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentDate",
                table: "FeedBacks");

            migrationBuilder.DropColumn(
                name: "Response",
                table: "FeedBacks");

            migrationBuilder.DropColumn(
                name: "ResponseDate",
                table: "FeedBacks");

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "FeedBacks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87873e02-afb5-4337-a28f-ce10c7250f48", "AQAAAAIAAYagAAAAEAxDUkNdPnwAtcACzBra1OFpYwEupc4GmMvRWhem9o1ZtC/TSrXvddlVuqNzWbyKEQ==", "0ddec862-2dd0-46f3-8c41-28b279da070d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0f925165-884c-41de-b525-f263942abbdb", "Adrain_Konopelski70@yahoo.com", "Marie Upton", "ADRAIN_KONOPELSKI70@YAHOO.COM", "ADRAIN_KONOPELSKI70@YAHOO.COM", "AQAAAAIAAYagAAAAEHsEvC/OCkDKmyVJfl4y7KichtE8XCiGQq8BbbuY5wSQZpiARyATq+sAfZo+JAvsKg==", "4bc919bf-8e9b-48a1-adfa-499f30b54247", "Adrain_Konopelski70@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a770c275-7c5c-4606-bc99-82a02b48e99b", "Coby_Zulauf@gmail.com", "Bryce Wuckert", "COBY_ZULAUF@GMAIL.COM", "COBY_ZULAUF@GMAIL.COM", "AQAAAAIAAYagAAAAEMEH5LahLVsL5KgcllPJxoRTH7/i/yYaxyB+vr0KUf/bQjHWa1kc4QpceIoydMb2yg==", "15c290db-ff06-424a-947c-69cb98cfbd55", "Coby_Zulauf@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "27a9bc34-7886-4f25-906d-26cfb8170a98", "Anabel_Lind9@gmail.com", "Vincenza O'Reilly", "ANABEL_LIND9@GMAIL.COM", "ANABEL_LIND9@GMAIL.COM", "AQAAAAIAAYagAAAAEHa/3lducxvAJ9+omLMAgv0jI7dGGUJYNF+0PyLaBQXzNOcl4+KtMokL5MFQkvTotQ==", "55949f3c-c783-4519-9596-d2298a4cca9c", "Anabel_Lind9@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "15684063-09b3-4f93-ab70-8bdb1ca36c7a", "Tyler54@hotmail.com", "Jordi Schmeler", "TYLER54@HOTMAIL.COM", "TYLER54@HOTMAIL.COM", "AQAAAAIAAYagAAAAED0chRPkNJpUn4CoAbcWlHpSxNNwehDSDh3I9e7ywf3QLtoj2NSZiq4fQvNoBQu7YQ==", "47982f72-254b-4f62-8c87-ca740af0b0c2", "Tyler54@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a95037ff-f00f-4c39-9ab8-1361a1b9350e", "Ella_Mohr@gmail.com", "Theodora Klein", "ELLA_MOHR@GMAIL.COM", "ELLA_MOHR@GMAIL.COM", "AQAAAAIAAYagAAAAEFf71bx3q0YAD+DvO4tSaIzRi5sgQhqb3/JeH/a0EM41VYbGu5C3Ln064KAG+wgmvw==", "12a06213-84d9-47ef-93f8-53aa20c890ed", "Ella_Mohr@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1de12dc6-328a-481a-8c9a-905448003e58", "Malika37@hotmail.com", "Hazel Bartell", "MALIKA37@HOTMAIL.COM", "MALIKA37@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDZEOBSdcYIJMhBZaSQngz8BerW5NXzlG7z823bMp0b/aWRsabpN/7nwLgzklv3NaA==", "5ba45538-70e8-4c9e-b728-6331d4cffdae", "Malika37@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b9c91110-699f-4796-8dda-6aac97885a24", "Elwin.Reichert@hotmail.com", "Eugenia Schaden", "ELWIN.REICHERT@HOTMAIL.COM", "ELWIN.REICHERT@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJODgrXTB7/YaJhCez8s+LhEG+18RrJbXv/AVI2cpn7jj9MrYEYjR+MgG9Sc4B1XGg==", "8461b51d-6845-476e-b8bf-731b1c8876bb", "Elwin.Reichert@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5fd553f6-964d-465b-8b41-d25dfdc878b4", "Remington.Adams@yahoo.com", "Lauriane Lehner", "REMINGTON.ADAMS@YAHOO.COM", "REMINGTON.ADAMS@YAHOO.COM", "AQAAAAIAAYagAAAAEDjBa4A0ordzld5PbGZXf1TVjWkSLQ3fy4MPYBjiQojdgyTgWpIrPnSBjSgZvoxqcQ==", "009f5673-4363-44c7-95b1-e4ff01efdb14", "Remington.Adams@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cb616379-0a49-4535-ada3-a9bfd3ea7c33", "Abigayle_Monahan@yahoo.com", "Jedediah Denesik", "ABIGAYLE_MONAHAN@YAHOO.COM", "ABIGAYLE_MONAHAN@YAHOO.COM", "AQAAAAIAAYagAAAAENLBSNMhRyU2V/H192MHG27slI1umHhmNzh+kgr4RcnmqyBrq8GBS4hDz6wkJqvBwA==", "93204320-fbbe-4a6b-944a-37ceea835234", "Abigayle_Monahan@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3b8ec682-f4b8-4834-b896-5cce872405e8", "Edd_Treutel98@hotmail.com", "Lillie Kulas", "EDD_TREUTEL98@HOTMAIL.COM", "EDD_TREUTEL98@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEliOXvpQlHojghLDP20NmUTM29nzURqRB/SmloEbjqXBVY3xd+VqlYWg3Bt4dKXqQ==", "2986ee97-e5d1-4f84-9bd3-44591c23308c", "Edd_Treutel98@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "83412 Orn Trafficway, New Mackenzie, Bolivia", new DateTime(2014, 5, 29, 21, 40, 9, 342, DateTimeKind.Unspecified).AddTicks(4472), true, "Adrain_Konopelski70@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "10955 Kunze Prairie, Lake Angelicamouth, Palestinian Territory", new DateTime(2016, 2, 22, 7, 14, 47, 659, DateTimeKind.Unspecified).AddTicks(2204), "Coby_Zulauf@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "950 Walter Hill, Lake Annamarie, Jamaica", new DateTime(2017, 3, 25, 4, 15, 1, 121, DateTimeKind.Unspecified).AddTicks(3683), "Anabel_Lind9@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "8225 Bayer Shoal, New Alphonsoborough, Belize", new DateTime(2015, 11, 10, 21, 41, 17, 581, DateTimeKind.Unspecified).AddTicks(3269), false, "Tyler54@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "48340 Muller Walks, South Rosalinda, Somalia", new DateTime(2012, 10, 12, 20, 55, 35, 304, DateTimeKind.Unspecified).AddTicks(2135), "Ella_Mohr@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "4979 Sadie Turnpike, Port Wilmerside, French Southern Territories", new DateTime(2016, 1, 5, 21, 7, 9, 418, DateTimeKind.Unspecified).AddTicks(4804), "Malika37@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "3158 Candelario Rest, Burleyview, Iraq", new DateTime(2012, 3, 21, 1, 58, 57, 887, DateTimeKind.Unspecified).AddTicks(3092), "Elwin.Reichert@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "336 Ernser Place, East Clementside, Anguilla", new DateTime(2017, 10, 18, 13, 46, 11, 70, DateTimeKind.Unspecified).AddTicks(9176), false, "Remington.Adams@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "36022 Lowe Underpass, Lake Benny, Guinea-Bissau", new DateTime(2016, 5, 4, 20, 45, 52, 168, DateTimeKind.Unspecified).AddTicks(8904), "Abigayle_Monahan@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "4010 Kamren Court, Ullrichburgh, Lebanon", new DateTime(2016, 7, 27, 20, 2, 48, 297, DateTimeKind.Unspecified).AddTicks(3659), true, "Edd_Treutel98@hotmail.com" });
        }
    }
}
