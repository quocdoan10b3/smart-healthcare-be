using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 3, null, "staff", "STAFF" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30bd88b2-bb00-484f-b0cf-5709f7f9b399", "AQAAAAIAAYagAAAAEJRRi31ikeezDQOZo8qwMeaIg4K1JpHouaI1yS4kD+0eLehOBKwoFg0fXgYaTQOTHQ==", "ecad3238-230e-405f-86a5-ee5cedd9e766" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "user", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01e21d79-ce93-4228-80e5-6e289b1d6c3a", "AQAAAAIAAYagAAAAECf8lOlRi2o1UBMvz4ze/D18pGum61/6BgHPTN4rNGjpsqdsJ75FsVrdPffc38iHgA==", "0fa1a377-2087-4022-92c6-e0d979c7ae41" });
        }
    }
}
