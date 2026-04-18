using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace F1VacationSite.Migrations
{
    /// <inheritdoc />
    public partial class FixPendingChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "HotelId", "ImageUrl", "Nights", "Price", "RaceId" },
                values: new object[,]
                {
                    { 1, null, 1, null, 3, 1299.99m, 1 },
                    { 2, null, 6, null, 4, 2499.00m, 2 },
                    { 3, null, 1, null, 3, 1399.50m, 3 },
                    { 4, null, 6, null, 5, 3499.00m, 7 },
                    { 5, null, 5, null, 2, 899.99m, 9 },
                    { 6, null, 9, null, 2, 799.00m, 11 },
                    { 7, null, 10, null, 3, 1199.00m, 13 },
                    { 8, null, 13, null, 3, 1099.50m, 15 },
                    { 9, null, 16, null, 4, 1899.99m, 16 },
                    { 10, null, 3, null, 3, 1299.00m, 17 },
                    { 11, null, 17, null, 2, 999.99m, 18 },
                    { 12, null, 22, null, 4, 2299.00m, 22 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
