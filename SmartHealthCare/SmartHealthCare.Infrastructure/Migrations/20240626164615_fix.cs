using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "HealthRecords",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "Height",
                table: "HealthRecords",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38749468-0522-447e-8331-cb03f7c2c640", "AQAAAAIAAYagAAAAEAghMLXJlB5Qx4PgrNDQ2inoTqhZYDNI9MHq7zZfkZpxkyzQMCNuvsGcVQlSsvaUOw==", "1a9af773-fc02-4b5f-a71f-3fe4239994ba" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Weight",
                table: "HealthRecords",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Height",
                table: "HealthRecords",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59e61952-09b2-4ca5-a7da-7f3a0bb83d18", "AQAAAAIAAYagAAAAELD81XkKvIxylE+N3hA1Qk1bEndd0wfSVg0dc83tvH33qlfb4txKBWBrzSMfkw5J7g==", "11e4c9bd-9e55-40dc-9cfc-7b2ae5de284d" });
        }
    }
}
