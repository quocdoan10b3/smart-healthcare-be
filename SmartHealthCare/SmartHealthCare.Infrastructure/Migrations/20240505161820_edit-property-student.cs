using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editpropertystudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsuranceNumber",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6fb2b1b-1d15-4d6c-8a6e-954e9d6254c3", "AQAAAAIAAYagAAAAEI4BCfPbdqs/NYHlAyzChhHDsPv94Qu/EtE9M1zgqBJDPn9artaj315jNFb1kYb0uQ==", "e4ae5a6c-a0b0-4214-8e04-b3038eb55cf2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InsuranceNumber",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e0dbdb1-4b1e-4bbb-819a-66e1f2224d2e", "AQAAAAIAAYagAAAAELTpCy6STTKW6bhMoF80EfjIAOBO6gCA2PKr8ELL1w7kd7X2hqbuIszQyx19i7enVA==", "58404d0f-397f-47f1-865b-465a0f41dbc4" });
        }
    }
}
