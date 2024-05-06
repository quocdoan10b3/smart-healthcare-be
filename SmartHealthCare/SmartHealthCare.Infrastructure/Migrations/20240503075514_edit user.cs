using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edituser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvatarUrl",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e0dbdb1-4b1e-4bbb-819a-66e1f2224d2e", "AQAAAAIAAYagAAAAELTpCy6STTKW6bhMoF80EfjIAOBO6gCA2PKr8ELL1w7kd7X2hqbuIszQyx19i7enVA==", "58404d0f-397f-47f1-865b-465a0f41dbc4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvatarUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "30bd88b2-bb00-484f-b0cf-5709f7f9b399", "AQAAAAIAAYagAAAAEJRRi31ikeezDQOZo8qwMeaIg4K1JpHouaI1yS4kD+0eLehOBKwoFg0fXgYaTQOTHQ==", "ecad3238-230e-405f-86a5-ee5cedd9e766" });
        }
    }
}
