using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edit_propery_feedback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ResponseDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e034f538-687b-4b78-a8ec-49a8c8522a47", "AQAAAAIAAYagAAAAELzZnz2fDQNFN7eFzv5ynnd1RIu2ndxfGYiRSPhHIGVTMGsJjhXwHiyL1CXzUI8qVA==", "d8b64a3d-efc6-4468-899f-2c5005360620" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "23860e39-9a95-4a15-a058-743e676d374a", "Karli.Kihn12@gmail.com", "Holden Jaskolski", "KARLI.KIHN12@GMAIL.COM", "KARLI.KIHN12@GMAIL.COM", "AQAAAAIAAYagAAAAEBEiVKw7KW69IYRrqKYra198pfO29Stinw+j3Hq1O6/bjwyv3IGHMesRq924vlo97g==", "accfad42-6e34-4dca-b7a1-7aa061808bc9", "Karli.Kihn12@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7af4c030-b212-4cf6-8d6c-f6426f0b30aa", "Tyreek72@yahoo.com", "Brown Trantow", "TYREEK72@YAHOO.COM", "TYREEK72@YAHOO.COM", "AQAAAAIAAYagAAAAEEGmaLLP6r7FsbiRhskDv+ff8WLWT/0oVvFJfwWEVx+JH4i32/+c29ysSjXQcJRJgg==", "d0481bf8-7d5d-48c3-9aa9-60e221e1bef5", "Tyreek72@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cd061678-efc9-48c5-9823-02180d0c4493", "Garland_Wisozk@yahoo.com", "Adelia Braun", "GARLAND_WISOZK@YAHOO.COM", "GARLAND_WISOZK@YAHOO.COM", "AQAAAAIAAYagAAAAEAFfCjsxonX4BDiuhG/18knBCwInv9tInXLHt924t4JvhrVJD28qDg0cnSC+izgtCA==", "1a5f7bea-a9ae-47c1-ad7b-ee6ddd9138e1", "Garland_Wisozk@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8cdbb427-98ef-466b-a684-68925582570c", "Pearline.Hegmann@gmail.com", "Milton Olson", "PEARLINE.HEGMANN@GMAIL.COM", "PEARLINE.HEGMANN@GMAIL.COM", "AQAAAAIAAYagAAAAEGfLHIOxtrKhDDZg8QCnXC9cndCMKu/D2Pi2ZNA81xrI8/ktPdG1FcwrJGHOFqwJ5g==", "013d4f96-67ec-44b2-84db-fef162c01ea6", "Pearline.Hegmann@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d9b4eb3d-0442-4daa-9316-068b21b976f2", "Ricky_Swift45@yahoo.com", "Lexus Paucek", "RICKY_SWIFT45@YAHOO.COM", "RICKY_SWIFT45@YAHOO.COM", "AQAAAAIAAYagAAAAEAE06B0BL5l/9e8tYTgPQz7nUG38juOtyMZCavAkHWczntHZCZ2L+SAV8SEp8BguyA==", "02f8fc31-e762-4bb8-a16a-b6885f924ec7", "Ricky_Swift45@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1cb03ce4-1817-4e50-88d3-94aa4e229283", "Kristian.Schuster@gmail.com", "Priscilla Bins", "KRISTIAN.SCHUSTER@GMAIL.COM", "KRISTIAN.SCHUSTER@GMAIL.COM", "AQAAAAIAAYagAAAAELxecAZwtQ9zTvflD4Io04v91kgiLQBrVl4Ydy+v4InZfQGP+1asjSEThVYi3RmTFg==", "e4b59872-1846-4689-bee9-c4d0a1f92d77", "Kristian.Schuster@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e3af4bc5-712c-4beb-9a69-fcc2a846ee8f", "Harry_Yundt@gmail.com", "Tressa Wunsch", "HARRY_YUNDT@GMAIL.COM", "HARRY_YUNDT@GMAIL.COM", "AQAAAAIAAYagAAAAEIiTPjvHivtDbyv1vk+Qr2rewe1V/tYiTnaRr3NuMvzgAOputpavD0SsyG/gNJK6ZA==", "ad4cfbba-65f1-48d1-b98f-bb953da8bc95", "Harry_Yundt@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "75b6f563-6918-457c-b138-4b86232eb385", "Howard38@yahoo.com", "Retha Bartell", "HOWARD38@YAHOO.COM", "HOWARD38@YAHOO.COM", "AQAAAAIAAYagAAAAEA16CDDHEPdB+Lsk6kUURt/aUM/ZJB1ziMxtoJEasY2FfuHK5p9ytzHHUysFmPLq4A==", "1d498f94-501d-4264-a956-cab5380c1ba2", "Howard38@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "806dea1c-be4c-4ac2-8140-5239a3260cb1", "Cheyanne.Wiegand36@yahoo.com", "Monty Daugherty", "CHEYANNE.WIEGAND36@YAHOO.COM", "CHEYANNE.WIEGAND36@YAHOO.COM", "AQAAAAIAAYagAAAAEELIqhTnW/J5Pn7RxIatFVwabod6TqkyAffpvgdszuCOBgU8qc30S79inKM73eCl9A==", "0747a3ad-0125-4f0c-ae5c-27839fe24805", "Cheyanne.Wiegand36@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "832805bd-ed4e-4e4b-b6dd-ee1064784b89", "Kaylie46@yahoo.com", "Allen Treutel", "KAYLIE46@YAHOO.COM", "KAYLIE46@YAHOO.COM", "AQAAAAIAAYagAAAAEIchFjWGS/jsvs3qO30a2g4qQCMCoM6xsHWGOejC4rFCM++SXo/MWRq6KClRb4Wxeg==", "0d64cf91-bbca-45a0-bbff-2df00052ae09", "Kaylie46@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "5671 Jacobi Course, New Noemi, Sudan", new DateTime(2009, 1, 19, 18, 18, 5, 335, DateTimeKind.Unspecified).AddTicks(5450), true, "Karli.Kihn12@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "9472 Kohler Plaza, South Tito, Niue", new DateTime(2014, 9, 6, 18, 35, 32, 904, DateTimeKind.Unspecified).AddTicks(5299), true, "Tyreek72@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "918 Samara Divide, Lake Gonzalo, Guinea-Bissau", new DateTime(2011, 6, 4, 14, 12, 25, 343, DateTimeKind.Unspecified).AddTicks(50), "Garland_Wisozk@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "431 Bergstrom Points, East Madisyn, Guatemala", new DateTime(2008, 2, 5, 7, 52, 21, 820, DateTimeKind.Unspecified).AddTicks(8416), "Pearline.Hegmann@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "2813 Camden Tunnel, Gulgowskiport, Bhutan", new DateTime(2009, 5, 28, 21, 32, 33, 914, DateTimeKind.Unspecified).AddTicks(6900), "Ricky_Swift45@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "133 Gladys Course, Lake Ole, Lithuania", new DateTime(2011, 4, 25, 16, 2, 54, 659, DateTimeKind.Unspecified).AddTicks(9251), true, "Kristian.Schuster@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "19374 Stracke Station, West Sofiaville, Saint Barthelemy", new DateTime(2012, 3, 1, 2, 58, 53, 783, DateTimeKind.Unspecified).AddTicks(6622), "Harry_Yundt@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "964 Elisha Mountains, Lake Ruthieshire, Tonga", new DateTime(2008, 2, 21, 11, 31, 22, 304, DateTimeKind.Unspecified).AddTicks(6703), "Howard38@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "830 Darryl Ways, Mitchellberg, Ukraine", new DateTime(2010, 9, 24, 13, 12, 58, 659, DateTimeKind.Unspecified).AddTicks(2485), false, "Cheyanne.Wiegand36@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "36192 Flo Lodge, South Everardomouth, Canada", new DateTime(2009, 1, 5, 21, 37, 22, 326, DateTimeKind.Unspecified).AddTicks(4578), "Kaylie46@yahoo.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ResponseDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "620 Bayer Track, Geovannyside, Lao People's Democratic Republic", new DateTime(2009, 9, 20, 18, 23, 48, 256, DateTimeKind.Unspecified).AddTicks(672), false, "Rowan_Lindgren@hotmail.com" });

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
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "0019 King Pass, South Leolafort, Bouvet Island (Bouvetoya)", new DateTime(2010, 6, 29, 8, 4, 32, 44, DateTimeKind.Unspecified).AddTicks(8043), "Name.Dickens@gmail.com" });

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
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "3976 Schoen Estates, West Lura, Netherlands Antilles", new DateTime(2012, 11, 13, 17, 51, 32, 941, DateTimeKind.Unspecified).AddTicks(3342), false, "Lance50@yahoo.com" });

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
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "832 Verda Freeway, Port Morton, Bahamas", new DateTime(2009, 10, 9, 6, 24, 27, 313, DateTimeKind.Unspecified).AddTicks(6050), "Ayana_Lowe0@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "6141 Strosin Mall, Hailieton, Romania", new DateTime(2009, 4, 1, 22, 45, 9, 392, DateTimeKind.Unspecified).AddTicks(8808), true, "Jaclyn_Jenkins@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "006 Morris Loop, Jarodchester, Guinea-Bissau", new DateTime(2016, 2, 17, 16, 31, 59, 999, DateTimeKind.Unspecified).AddTicks(7361), "Rickey32@yahoo.com" });
        }
    }
}
