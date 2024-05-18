using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPropertyAvatarUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvatarUrl",
                table: "AspNetUsers",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "44e1b308-58ca-402e-9415-4f6092de3e2e", "AQAAAAIAAYagAAAAECflVOOkowVxNDPgR2BmTUBRr6vSSdRjmMH81AnZjckc8oa7V74uZklV312iU+EDnA==", "f03d8c8d-b65b-4012-ad64-a5ca14aa7358" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { null, "e7b02217-e67a-4659-b70a-5e9948a14632", "Titus.Turner69@yahoo.com", "Burdette Wolff", "TITUS.TURNER69@YAHOO.COM", "TITUS.TURNER69@YAHOO.COM", "AQAAAAIAAYagAAAAEPkPnuUpGawMljAS8FaxV4iVd21PLm6He+RJLRoygRVPXvqynhtKMxQB18xR7htMOA==", "e630537f-7382-4acf-abcd-316035f21c3f", "Titus.Turner69@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { null, "143a4bd3-53ed-4b75-bed5-02d2f7fa122e", "Tremayne15@hotmail.com", "June Dooley", "TREMAYNE15@HOTMAIL.COM", "TREMAYNE15@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFaCs6CFzSI2U1R2RMl7pV0AWCkOJDvZDaaTafiUmL2iXvHenCRh/bIgBjgE23VlpQ==", "ad7a3f50-1458-4f9a-a74d-2860748aba6f", "Tremayne15@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { null, "c8e7fef1-e23f-4836-9edf-557c992aef85", "Elyse_Feil1@hotmail.com", "Madge Reichert", "ELYSE_FEIL1@HOTMAIL.COM", "ELYSE_FEIL1@HOTMAIL.COM", "AQAAAAIAAYagAAAAEM6TY5sKIhF/qBHGh2ZI2ujgia3koBbkPona5eJnFRFwKoyeAasmaDu1CaeZVajJfA==", "f408ca08-a3be-48db-95b8-f5c3774d78fb", "Elyse_Feil1@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { null, "8335d09d-ccbe-4384-aa8a-a35b4c08d472", "Katarina_Sawayn@yahoo.com", "Paige Bradtke", "KATARINA_SAWAYN@YAHOO.COM", "KATARINA_SAWAYN@YAHOO.COM", "AQAAAAIAAYagAAAAEODLGZf9TZ8LxDnt84RC9Lli2VYHwSkvv29NIeeeiTHyjHY7/NCCnbsn0C35q+4BrQ==", "634aa401-595e-471b-93a2-84b3b4f20503", "Katarina_Sawayn@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { null, "2425f948-a16f-4c3b-96e6-96a2444c2e4c", "Claire91@hotmail.com", "Vance Bergnaum", "CLAIRE91@HOTMAIL.COM", "CLAIRE91@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMcwLt4GSluTFkdFZzQ41JFIm2s28nUSSlJZkgLCZwdboWx1I51FwcAK5rQssaB4Nw==", "bafa1a12-71db-445e-aa1e-7e0daf18125f", "Claire91@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { null, "dbbc8f4c-05ef-4ea8-abd2-4b535276e647", "Russel_Bechtelar7@hotmail.com", "Gail Schuppe", "RUSSEL_BECHTELAR7@HOTMAIL.COM", "RUSSEL_BECHTELAR7@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMAFlSEUd14kZJK9Oc4fGsJtCMoRYH+16rH3O15TVXY3mw+gzwNY3bDm1k8wA7UgRA==", "772e0a1b-8e6b-4b8b-a7d0-477df4b8b451", "Russel_Bechtelar7@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { null, "4b4796bf-c632-4c11-96d9-109335bc3bee", "Davon.Stamm@yahoo.com", "Selina Douglas", "DAVON.STAMM@YAHOO.COM", "DAVON.STAMM@YAHOO.COM", "AQAAAAIAAYagAAAAEOs7b+zjiFBvqjk2DWOQ1xtmycBPlkkzEhf4T9l0ZfdjRlv9fYLmELd4utkPfTBbpQ==", "a9ee2b63-b2d6-43bf-84e9-4c1e7c1bee1d", "Davon.Stamm@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { null, "f320139b-c3a5-4519-9a84-35cf58439391", "Elenora_Daniel@gmail.com", "Orrin Lubowitz", "ELENORA_DANIEL@GMAIL.COM", "ELENORA_DANIEL@GMAIL.COM", "AQAAAAIAAYagAAAAEH4fiOKOQUYCdNLV44ojcqgQ3JDr27OFQ/q0mzP5+b/moDRWCO5rRsuJjnKKSvDBrA==", "a7278284-b3dd-498c-9560-a35dc0cc09dd", "Elenora_Daniel@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { null, "f3e73758-3d98-4731-a582-9999f1b3e17c", "Nelda14@gmail.com", "Lily Russel", "NELDA14@GMAIL.COM", "NELDA14@GMAIL.COM", "AQAAAAIAAYagAAAAEDZU+cVMpG8Tpbl7NIZL3MU2OVX1C32GsmZr0xuJMzcdegFRZT4vb8j8tRvGU73v+Q==", "fb6355f3-33eb-4f63-abf8-01cd00ce4998", "Nelda14@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { null, "1e1eb12c-65cb-446d-a22d-91cb6de55022", "Krista.Leffler@gmail.com", "Ulices Leuschke", "KRISTA.LEFFLER@GMAIL.COM", "KRISTA.LEFFLER@GMAIL.COM", "AQAAAAIAAYagAAAAEJR+i6VYYD0V3yMJpiHfrHGiOLuEX7F/ozTikpqfIEyu2jLf+pXWZfavJwX1HtmvXw==", "8993f7db-63a6-4066-8571-123e4c2b3b1a", "Krista.Leffler@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "97895 Alysson Highway, North Idella, Belarus", new DateTime(2012, 1, 14, 10, 3, 6, 318, DateTimeKind.Unspecified).AddTicks(7516), "Titus.Turner69@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "9646 Velma Ferry, Shieldsfurt, Bhutan", new DateTime(2009, 5, 7, 16, 45, 24, 305, DateTimeKind.Unspecified).AddTicks(6732), false, "Tremayne15@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "73794 Flo Well, Marielaside, Benin", new DateTime(2016, 2, 7, 16, 30, 0, 19, DateTimeKind.Unspecified).AddTicks(196), false, "Elyse_Feil1@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "1770 Willard Cliffs, Ricestad, Palau", new DateTime(2015, 8, 29, 4, 1, 54, 261, DateTimeKind.Unspecified).AddTicks(2529), true, "Katarina_Sawayn@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "318 Bernadine Green, Lake Joshua, Holy See (Vatican City State)", new DateTime(2009, 4, 10, 6, 0, 31, 518, DateTimeKind.Unspecified).AddTicks(1642), "Claire91@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "8960 Kreiger Mission, Leoramouth, Azerbaijan", new DateTime(2015, 9, 4, 3, 51, 47, 600, DateTimeKind.Unspecified).AddTicks(80), true, "Russel_Bechtelar7@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "3566 Schmitt Motorway, Kautzerport, French Polynesia", new DateTime(2011, 7, 2, 18, 43, 45, 619, DateTimeKind.Unspecified).AddTicks(9924), "Davon.Stamm@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "6366 Krystal Key, Skilestown, Congo", new DateTime(2017, 8, 3, 16, 46, 10, 371, DateTimeKind.Unspecified).AddTicks(1572), false, "Elenora_Daniel@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "26555 Tromp Parks, Ellaberg, Martinique", new DateTime(2011, 3, 21, 18, 19, 31, 964, DateTimeKind.Unspecified).AddTicks(2531), false, "Nelda14@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "3327 Morissette Ridge, Lake Vicky, Turks and Caicos Islands", new DateTime(2010, 12, 9, 12, 41, 37, 494, DateTimeKind.Unspecified).AddTicks(5284), true, "Krista.Leffler@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvatarUrl",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2641074e-7b4e-467f-b509-24c735930212", "AQAAAAIAAYagAAAAENVmiKGQ2H+/7sCita++Kwldl6T63Lpm13bIoxA4GjS3aj4QKxoK2Py9HbRGot6+Cg==", "82c9feb7-5346-43c5-9888-dacc90b6b50e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7ce241b0-ee18-499f-8e60-7e030d7fb9d3", "Raleigh_Cummerata35@hotmail.com", "Kameron Schowalter", "RALEIGH_CUMMERATA35@HOTMAIL.COM", "RALEIGH_CUMMERATA35@HOTMAIL.COM", "AQAAAAIAAYagAAAAEI5dYYIpLtXCczu0y20Rn7ncpeZ1QqsIXJFHItaxnQwUGcw3Q12twJO45Dz73dMvTw==", "8b526ad7-4e92-418d-aa30-536c2f9738fb", "Raleigh_Cummerata35@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e307e7d4-2712-4ad3-8d23-e8d7b63ebf7a", "Tyrell.Gislason@yahoo.com", "Toby Schamberger", "TYRELL.GISLASON@YAHOO.COM", "TYRELL.GISLASON@YAHOO.COM", "AQAAAAIAAYagAAAAENe7vk+PkgdNJtYb5qhqenRpc59JYiUKlrlPq4EhQSjqC+wgYGH4z0Ip5mK94CS0rA==", "4cb65477-5fed-49a6-a3fd-691b5d3c81d5", "Tyrell.Gislason@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8ed30601-d850-4a08-9439-32fd8f1e8dd9", "Corrine49@yahoo.com", "Percival Collins", "CORRINE49@YAHOO.COM", "CORRINE49@YAHOO.COM", "AQAAAAIAAYagAAAAEDvrUu0wz9Ei69t58/H8X7cLF/HBYnHtruJ6L3JgdlgpksCWt8CjR9lhv8SReFHckw==", "2c29193e-7a9e-4094-bd56-59860a9907bc", "Corrine49@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e405250a-e38e-41a7-843a-590b83528b90", "Jules.Labadie@gmail.com", "Tiffany Maggio", "JULES.LABADIE@GMAIL.COM", "JULES.LABADIE@GMAIL.COM", "AQAAAAIAAYagAAAAEJ/ESaLxhxE8zJkHbPSsgoLXJPDwZvIoo37/ySfLCWk+xYc8OLh6FGBSO77Fi95/Xw==", "6bcb5487-f66e-4f95-8b5a-39b24d89190a", "Jules.Labadie@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8c82b043-1f36-4d4b-91d8-eb61ba3f0870", "Agustina_Schamberger37@gmail.com", "Christiana Homenick", "AGUSTINA_SCHAMBERGER37@GMAIL.COM", "AGUSTINA_SCHAMBERGER37@GMAIL.COM", "AQAAAAIAAYagAAAAEIklceEiXd/kx/0UhUYp3gI7t77PUvuA69K7a+fzNNcyHAXUWj/lCu4gDMzZ67xjzQ==", "f33704c4-1dee-434f-b26d-8bcb88491d10", "Agustina_Schamberger37@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "20efacda-d72e-4a5b-8692-1dbbbe473fe6", "Mose_Green@gmail.com", "Howard Kihn", "MOSE_GREEN@GMAIL.COM", "MOSE_GREEN@GMAIL.COM", "AQAAAAIAAYagAAAAEEBhqKIVYKeep9kv1ACJ0BMRIjA5cm/oqZbdfZvQQoN+ZFHb8+pl5+rEpgTD3ubJtQ==", "d44dce38-dc71-4675-861c-6200224d2be3", "Mose_Green@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4c15100e-a6da-4cdf-9162-8f1eccdee39b", "Jazmin_Hayes@hotmail.com", "Alvera Jerde", "JAZMIN_HAYES@HOTMAIL.COM", "JAZMIN_HAYES@HOTMAIL.COM", "AQAAAAIAAYagAAAAEN8y1zGuKgQy6uUQ7iZA9+NYE01ruPVi2xe7DEtybm6UX5yiT83E3SKBt72zyo27Ng==", "420ee887-b8d8-472d-ab04-483b244d45ae", "Jazmin_Hayes@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "19416cab-cf1f-40ec-b98b-1117df8bd609", "Orville_Predovic@yahoo.com", "Serena Koelpin", "ORVILLE_PREDOVIC@YAHOO.COM", "ORVILLE_PREDOVIC@YAHOO.COM", "AQAAAAIAAYagAAAAECD/iAajTjwTcttj/0ro1K/OgvmpCdzt51vc9vw+t/zm01BjZzb0XlO7ERSl06N4Sg==", "89710e99-91fe-45a9-a3e0-6886423b1ced", "Orville_Predovic@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "321b088d-9358-4d8a-af21-24253e536cf3", "Adah.Hoeger@gmail.com", "Euna Wolf", "ADAH.HOEGER@GMAIL.COM", "ADAH.HOEGER@GMAIL.COM", "AQAAAAIAAYagAAAAENIlpyE3mnRjgONZvT7nYdmVfn6pSQiCxww5kcaz0/RNAtD3bemVu6fikuwTV/dMPQ==", "63d73237-e84a-4392-a58f-f0b367df70db", "Adah.Hoeger@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "aba2c43b-eef2-4220-9234-ed0f47d0f942", "Bernadette67@yahoo.com", "Ruby Gorczany", "BERNADETTE67@YAHOO.COM", "BERNADETTE67@YAHOO.COM", "AQAAAAIAAYagAAAAEIw2Fsympsj8O5QktYMrQMexrO6J+Y9nsDT7014Qm3B7kSIVHk24B3A/C+o4T8KxCw==", "dc107a26-3df2-4019-ae30-9a90c0955a24", "Bernadette67@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "38534 Schaefer Wells, Rebekahfurt, Australia", new DateTime(2014, 7, 23, 2, 34, 2, 944, DateTimeKind.Unspecified).AddTicks(7932), "Raleigh_Cummerata35@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "592 Mortimer Spur, Borisland, United States of America", new DateTime(2013, 8, 9, 10, 39, 31, 754, DateTimeKind.Unspecified).AddTicks(7745), true, "Tyrell.Gislason@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "6193 Manley Camp, North Dan, Turkey", new DateTime(2008, 6, 11, 9, 35, 18, 723, DateTimeKind.Unspecified).AddTicks(9313), true, "Corrine49@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "18605 Scarlett Cliffs, Adahmouth, Serbia", new DateTime(2011, 12, 2, 17, 22, 37, 473, DateTimeKind.Unspecified).AddTicks(1517), false, "Jules.Labadie@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "6970 Adam Mill, Beckermouth, Puerto Rico", new DateTime(2011, 5, 23, 10, 13, 28, 547, DateTimeKind.Unspecified).AddTicks(3875), "Agustina_Schamberger37@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "1985 Erling Rue, North Janisfort, Bermuda", new DateTime(2016, 7, 13, 15, 5, 42, 345, DateTimeKind.Unspecified).AddTicks(9021), false, "Mose_Green@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "006 Aufderhar Mountains, Russelbury, Bangladesh", new DateTime(2018, 11, 13, 3, 30, 56, 474, DateTimeKind.Unspecified).AddTicks(5274), "Jazmin_Hayes@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "7296 Ole Union, Bradtkefort, Malta", new DateTime(2014, 5, 7, 23, 17, 56, 653, DateTimeKind.Unspecified).AddTicks(2514), true, "Orville_Predovic@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "090 Schoen Forks, Eastonland, Belgium", new DateTime(2009, 1, 11, 5, 9, 39, 126, DateTimeKind.Unspecified).AddTicks(3390), true, "Adah.Hoeger@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "951 Alda Grove, Lake Murphyside, Uzbekistan", new DateTime(2012, 4, 22, 17, 46, 50, 189, DateTimeKind.Unspecified).AddTicks(2570), false, "Bernadette67@yahoo.com" });
        }
    }
}
