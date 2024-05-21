using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EditPropertyMedicine : Migration
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
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "48340 Muller Walks, South Rosalinda, Somalia", new DateTime(2012, 10, 12, 20, 55, 35, 304, DateTimeKind.Unspecified).AddTicks(2135), false, "Ella_Mohr@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "4979 Sadie Turnpike, Port Wilmerside, French Southern Territories", new DateTime(2016, 1, 5, 21, 7, 9, 418, DateTimeKind.Unspecified).AddTicks(4804), false, "Malika37@hotmail.com" });

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
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "336 Ernser Place, East Clementside, Anguilla", new DateTime(2017, 10, 18, 13, 46, 11, 70, DateTimeKind.Unspecified).AddTicks(9176), "Remington.Adams@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "36022 Lowe Underpass, Lake Benny, Guinea-Bissau", new DateTime(2016, 5, 4, 20, 45, 52, 168, DateTimeKind.Unspecified).AddTicks(8904), true, "Abigayle_Monahan@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "4010 Kamren Court, Ullrichburgh, Lebanon", new DateTime(2016, 7, 27, 20, 2, 48, 297, DateTimeKind.Unspecified).AddTicks(3659), "Edd_Treutel98@hotmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "44e1b308-58ca-402e-9415-4f6092de3e2e", "AQAAAAIAAYagAAAAECflVOOkowVxNDPgR2BmTUBRr6vSSdRjmMH81AnZjckc8oa7V74uZklV312iU+EDnA==", "f03d8c8d-b65b-4012-ad64-a5ca14aa7358" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e7b02217-e67a-4659-b70a-5e9948a14632", "Titus.Turner69@yahoo.com", "Burdette Wolff", "TITUS.TURNER69@YAHOO.COM", "TITUS.TURNER69@YAHOO.COM", "AQAAAAIAAYagAAAAEPkPnuUpGawMljAS8FaxV4iVd21PLm6He+RJLRoygRVPXvqynhtKMxQB18xR7htMOA==", "e630537f-7382-4acf-abcd-316035f21c3f", "Titus.Turner69@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "143a4bd3-53ed-4b75-bed5-02d2f7fa122e", "Tremayne15@hotmail.com", "June Dooley", "TREMAYNE15@HOTMAIL.COM", "TREMAYNE15@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFaCs6CFzSI2U1R2RMl7pV0AWCkOJDvZDaaTafiUmL2iXvHenCRh/bIgBjgE23VlpQ==", "ad7a3f50-1458-4f9a-a74d-2860748aba6f", "Tremayne15@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c8e7fef1-e23f-4836-9edf-557c992aef85", "Elyse_Feil1@hotmail.com", "Madge Reichert", "ELYSE_FEIL1@HOTMAIL.COM", "ELYSE_FEIL1@HOTMAIL.COM", "AQAAAAIAAYagAAAAEM6TY5sKIhF/qBHGh2ZI2ujgia3koBbkPona5eJnFRFwKoyeAasmaDu1CaeZVajJfA==", "f408ca08-a3be-48db-95b8-f5c3774d78fb", "Elyse_Feil1@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8335d09d-ccbe-4384-aa8a-a35b4c08d472", "Katarina_Sawayn@yahoo.com", "Paige Bradtke", "KATARINA_SAWAYN@YAHOO.COM", "KATARINA_SAWAYN@YAHOO.COM", "AQAAAAIAAYagAAAAEODLGZf9TZ8LxDnt84RC9Lli2VYHwSkvv29NIeeeiTHyjHY7/NCCnbsn0C35q+4BrQ==", "634aa401-595e-471b-93a2-84b3b4f20503", "Katarina_Sawayn@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2425f948-a16f-4c3b-96e6-96a2444c2e4c", "Claire91@hotmail.com", "Vance Bergnaum", "CLAIRE91@HOTMAIL.COM", "CLAIRE91@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMcwLt4GSluTFkdFZzQ41JFIm2s28nUSSlJZkgLCZwdboWx1I51FwcAK5rQssaB4Nw==", "bafa1a12-71db-445e-aa1e-7e0daf18125f", "Claire91@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "dbbc8f4c-05ef-4ea8-abd2-4b535276e647", "Russel_Bechtelar7@hotmail.com", "Gail Schuppe", "RUSSEL_BECHTELAR7@HOTMAIL.COM", "RUSSEL_BECHTELAR7@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMAFlSEUd14kZJK9Oc4fGsJtCMoRYH+16rH3O15TVXY3mw+gzwNY3bDm1k8wA7UgRA==", "772e0a1b-8e6b-4b8b-a7d0-477df4b8b451", "Russel_Bechtelar7@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4b4796bf-c632-4c11-96d9-109335bc3bee", "Davon.Stamm@yahoo.com", "Selina Douglas", "DAVON.STAMM@YAHOO.COM", "DAVON.STAMM@YAHOO.COM", "AQAAAAIAAYagAAAAEOs7b+zjiFBvqjk2DWOQ1xtmycBPlkkzEhf4T9l0ZfdjRlv9fYLmELd4utkPfTBbpQ==", "a9ee2b63-b2d6-43bf-84e9-4c1e7c1bee1d", "Davon.Stamm@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f320139b-c3a5-4519-9a84-35cf58439391", "Elenora_Daniel@gmail.com", "Orrin Lubowitz", "ELENORA_DANIEL@GMAIL.COM", "ELENORA_DANIEL@GMAIL.COM", "AQAAAAIAAYagAAAAEH4fiOKOQUYCdNLV44ojcqgQ3JDr27OFQ/q0mzP5+b/moDRWCO5rRsuJjnKKSvDBrA==", "a7278284-b3dd-498c-9560-a35dc0cc09dd", "Elenora_Daniel@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f3e73758-3d98-4731-a582-9999f1b3e17c", "Nelda14@gmail.com", "Lily Russel", "NELDA14@GMAIL.COM", "NELDA14@GMAIL.COM", "AQAAAAIAAYagAAAAEDZU+cVMpG8Tpbl7NIZL3MU2OVX1C32GsmZr0xuJMzcdegFRZT4vb8j8tRvGU73v+Q==", "fb6355f3-33eb-4f63-abf8-01cd00ce4998", "Nelda14@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1e1eb12c-65cb-446d-a22d-91cb6de55022", "Krista.Leffler@gmail.com", "Ulices Leuschke", "KRISTA.LEFFLER@GMAIL.COM", "KRISTA.LEFFLER@GMAIL.COM", "AQAAAAIAAYagAAAAEJR+i6VYYD0V3yMJpiHfrHGiOLuEX7F/ozTikpqfIEyu2jLf+pXWZfavJwX1HtmvXw==", "8993f7db-63a6-4066-8571-123e4c2b3b1a", "Krista.Leffler@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "97895 Alysson Highway, North Idella, Belarus", new DateTime(2012, 1, 14, 10, 3, 6, 318, DateTimeKind.Unspecified).AddTicks(7516), false, "Titus.Turner69@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "9646 Velma Ferry, Shieldsfurt, Bhutan", new DateTime(2009, 5, 7, 16, 45, 24, 305, DateTimeKind.Unspecified).AddTicks(6732), "Tremayne15@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "73794 Flo Well, Marielaside, Benin", new DateTime(2016, 2, 7, 16, 30, 0, 19, DateTimeKind.Unspecified).AddTicks(196), "Elyse_Feil1@hotmail.com" });

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
                columns: new[] { "Address", "Date", "Gender", "StudentCode" },
                values: new object[] { "318 Bernadine Green, Lake Joshua, Holy See (Vatican City State)", new DateTime(2009, 4, 10, 6, 0, 31, 518, DateTimeKind.Unspecified).AddTicks(1642), true, "Claire91@hotmail.com" });

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
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "6366 Krystal Key, Skilestown, Congo", new DateTime(2017, 8, 3, 16, 46, 10, 371, DateTimeKind.Unspecified).AddTicks(1572), "Elenora_Daniel@gmail.com" });

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
                columns: new[] { "Address", "Date", "StudentCode" },
                values: new object[] { "3327 Morissette Ridge, Lake Vicky, Turks and Caicos Islands", new DateTime(2010, 12, 9, 12, 41, 37, 494, DateTimeKind.Unspecified).AddTicks(5284), "Krista.Leffler@gmail.com" });
        }
    }
}
