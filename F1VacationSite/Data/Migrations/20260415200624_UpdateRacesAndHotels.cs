using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace F1VacationSite.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRacesAndHotels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Stars" },
                values: new object[] { "Crown Towers Melbourne", 5 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Name" },
                values: new object[] { "Shanghai", "The Ritz-Carlton Shanghai" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Name", "Stars" },
                values: new object[] { "Suzuka", "Suzuka Circuit Hotel", 4 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Name", "Stars" },
                values: new object[] { "Miami", "1 Hotel South Beach", 5 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Name" },
                values: new object[] { "Montreal", "Fairmont The Queen Elizabeth" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Name", "Stars" },
                values: new object[] { "Monte Carlo", "Hotel de Paris Monte-Carlo", 5 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Name", "Stars" },
                values: new object[] { "Barcelona", "Hotel Arts Barcelona", 5 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Name", "Stars" },
                values: new object[] { "Spielberg", "Falkensteiner Hotel Schladming", 4 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "City", "Name", "Stars" },
                values: new object[,]
                {
                    { 9, "Towcester", "Whittlebury Hall Hotel", 4 },
                    { 10, "Spa", "Radisson Blu Palace Hotel Spa", 4 },
                    { 11, "Budapest", "Kempinski Hotel Corvinus", 5 },
                    { 12, "Zandvoort", "NH Zandvoort", 4 },
                    { 13, "Monza", "Hotel de la Ville Monza", 5 },
                    { 14, "Madrid", "Gran Melia Palacio de los Duques", 5 },
                    { 15, "Baku", "Four Seasons Hotel Baku", 5 },
                    { 16, "Singapore", "Marina Bay Sands", 5 },
                    { 17, "Austin", "JW Marriott Austin", 4 },
                    { 18, "Mexico City", "Four Seasons Mexico City", 5 },
                    { 19, "Sao Paulo", "Hotel Unique Sao Paulo", 5 },
                    { 20, "Las Vegas", "The Venetian Las Vegas", 5 },
                    { 21, "Doha", "The Ned Doha", 5 },
                    { 22, "Abu Dhabi", "Emirates Palace Abu Dhabi", 5 }
                });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[] { "Bahrain International Circuit", "Bahrain", new DateTime(2026, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bahrain Grand Prix", new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[] { "Jeddah Corniche Circuit", "Saudi Arabia", new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saudi Arabian Grand Prix", new DateTime(2026, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[] { "Albert Park", "Australia", new DateTime(2026, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australian Grand Prix", new DateTime(2026, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[] { "Baku City Circuit", "Azerbaijan", new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azerbaijan Grand Prix", new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[] { "Miami International Autodrome", "United States", new DateTime(2026, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miami Grand Prix", new DateTime(2026, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[] { "Imola", "Italy", new DateTime(2026, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emilia Romagna Grand Prix", new DateTime(2026, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[] { "Monte Carlo", "Monaco", new DateTime(2026, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monaco Grand Prix", new DateTime(2026, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[] { "Circuit de Barcelona-Catalunya", "Spain", new DateTime(2026, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spanish Grand Prix", new DateTime(2026, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 9, "Circuit Gilles Villeneuve", "Canada", new DateTime(2026, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canadian Grand Prix", new DateTime(2026, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Red Bull Ring", "Austria", new DateTime(2026, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Austrian Grand Prix", new DateTime(2026, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Silverstone", "United Kingdom", new DateTime(2026, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "British Grand Prix", new DateTime(2026, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Hungaroring", "Hungary", new DateTime(2026, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hungarian Grand Prix", new DateTime(2026, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Spa-Francorchamps", "Belgium", new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belgian Grand Prix", new DateTime(2026, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Zandvoort", "Netherlands", new DateTime(2026, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dutch Grand Prix", new DateTime(2026, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Monza", "Italy", new DateTime(2026, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italian Grand Prix", new DateTime(2026, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Marina Bay Street Circuit", "Singapore", new DateTime(2026, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Singapore Grand Prix", new DateTime(2026, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Suzuka", "Japan", new DateTime(2026, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japanese Grand Prix", new DateTime(2026, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Circuit of The Americas", "United States", new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States Grand Prix", new DateTime(2026, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "Autódromo Hermanos Rodríguez", "Mexico", new DateTime(2026, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico City Grand Prix", new DateTime(2026, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "Interlagos", "Brazil", new DateTime(2026, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brazilian Grand Prix", new DateTime(2026, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Las Vegas Street Circuit", "United States", new DateTime(2026, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Las Vegas Grand Prix", new DateTime(2026, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "Yas Marina Circuit", "United Arab Emirates", new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abu Dhabi Grand Prix", new DateTime(2026, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Stars" },
                values: new object[] { "Albert Park Hotel", 4 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Name" },
                values: new object[] { "Monte Carlo", "Monte Carlo Palace" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Name", "Stars" },
                values: new object[] { "Towcester", "Silverstone Inn", 3 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Name", "Stars" },
                values: new object[] { "Monza", "Hotel Monza", 4 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Name" },
                values: new object[] { "Stavelot", "Spa Resort" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Name", "Stars" },
                values: new object[] { "Austin", "Austin Grand Hotel", 4 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Name", "Stars" },
                values: new object[] { "Suzuka", "Suzuka Hotel & Suites", 4 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Name", "Stars" },
                values: new object[] { "Montreal", "Gilles Village Hotel", 3 });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[] { "Albert Park", "Australia", new DateTime(2026, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australian Grand Prix", new DateTime(2026, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[] { "Monte Carlo", "Monaco", new DateTime(2026, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monaco Grand Prix", new DateTime(2026, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[] { "Silverstone", "United Kingdom", new DateTime(2026, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "British Grand Prix", new DateTime(2026, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[] { "Monza", "Italy", new DateTime(2026, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italian Grand Prix", new DateTime(2026, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[] { "Spa-Francorchamps", "Belgium", new DateTime(2026, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belgian Grand Prix", new DateTime(2026, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[] { "Circuit of The Americas", "United States", new DateTime(2026, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States Grand Prix", new DateTime(2026, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[] { "Suzuka", "Japan", new DateTime(2026, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japanese Grand Prix", new DateTime(2026, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Circuit", "Country", "EndDate", "Name", "StartDate" },
                values: new object[] { "Circuit Gilles Villeneuve", "Canada", new DateTime(2026, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canadian Grand Prix", new DateTime(2026, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
