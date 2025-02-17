using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UnitConversionApi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UnitCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Length" },
                    { 2, "Weight" },
                    { 3, "Temperature" }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Factor", "MainReference", "Name", "UnitCategoryId" },
                values: new object[,]
                {
                    { 1, 1.0, true, "meter", 1 },
                    { 2, 1000.0, false, "kilometer", 1 },
                    { 3, 1609.3399999999999, false, "mile", 1 },
                    { 4, 1.0, true, "kilogram", 2 },
                    { 5, 0.001, false, "gram", 2 },
                    { 6, 1.0, true, "celsius", 3 },
                    { 7, 0.0, false, "fahrenheit", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UnitCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UnitCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UnitCategories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
