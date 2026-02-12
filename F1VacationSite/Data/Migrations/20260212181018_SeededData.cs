using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace F1VacationSite.Migrations
{
    /// <inheritdoc />
    public partial class SeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "City", "Name", "Stars" },
                values: new object[,]
                {
                    { 1, "Melbourne", "Albert Park Hotel", 4 },
                    { 2, "Monte Carlo", "Monte Carlo Palace", 5 },
                    { 3, "Towcester", "Silverstone Inn", 3 },
                    { 4, "Monza", "Hotel Monza", 4 },
                    { 5, "Stavelot", "Spa Resort", 4 },
                    { 6, "Austin", "Austin Grand Hotel", 4 },
                    { 7, "Suzuka", "Suzuka Hotel & Suites", 4 },
                    { 8, "Montreal", "Gilles Village Hotel", 3 }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, "Albert Park", "Australia", new DateTime(2026, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australian Grand Prix", new DateTime(2026, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Monte Carlo", "Monaco", new DateTime(2026, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monaco Grand Prix", new DateTime(2026, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Silverstone", "United Kingdom", new DateTime(2026, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "British Grand Prix", new DateTime(2026, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Monza", "Italy", new DateTime(2026, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italian Grand Prix", new DateTime(2026, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Spa-Francorchamps", "Belgium", new DateTime(2026, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belgian Grand Prix", new DateTime(2026, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Circuit of The Americas", "United States", new DateTime(2026, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States Grand Prix", new DateTime(2026, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Suzuka", "Japan", new DateTime(2026, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japanese Grand Prix", new DateTime(2026, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Circuit Gilles Villeneuve", "Canada", new DateTime(2026, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canadian Grand Prix", new DateTime(2026, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
