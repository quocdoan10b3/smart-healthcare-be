using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "ecbdf251-9a1b-49f0-b75d-425aceb03c69", "AQAAAAIAAYagAAAAEHk0bPz9r6ymxyfodXKHqZSLiiB7y+Mk98bksuOgkqx4gbgYKsEF7LvGEPRj57LrYg==", "4a20a733-2088-427c-bedc-3859c3c43eb3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
