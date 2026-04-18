using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace F1VacationSite.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Nights", "Price", "RaceId" },
                values: new object[] { "Пакетът включва престой в сърцето на Мелбърн с директен изглед към Albert Park. Идеален за феновете, търсещи комфорт и близост до пистата.", 5, 3200m, 3 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Nights", "Price", "RaceId" },
                values: new object[] { "Петзвездно изживяване в легендарното Monte Carlo. Хотелът се намира на метри от пистата — усети магията на Monaco GP от първа ръка.", 5, 4800m, 7 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { "Miami GP с престой в един от най-стилните хотели на South Beach. Съчетай Формула 1 с плажния живот на Маями.", 4, 4, 3500m, 5 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { "Singapore GP е единственото нощно състезание в календара. Marina Bay Sands предлага невероятна гледка към градските светлини и пистата.", 16, 4, 3800m, 16 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { "British GP в Silverstone е едно от най-емблематичните събития в спорта. Whittlebury Hall е само минути от пистата сред английската провинция.", 9, 5, 2700m, 11 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { "Italian GP в Monza — домът на тифозите. Почувствай страстта на италианските фенове сред историческия парк.", 13, 4, 2500m, 15 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { "Las Vegas GP е най-екстравагантното събитие в календара. The Venetian предлага луксозно изживяване в центъра на Strip-а.", 20, 4, 4200m, 21 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { "Azerbaijan GP на улиците на Баку е едно от най-непредсказуемите състезания. Four Seasons е само на крачка от пистата.", 15, 4, 2900m, 4 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "HotelId", "Price", "RaceId" },
                values: new object[] { "Hungarian GP в Будапеща съчетава страхотно състезание с богата култура. Kempinski е в самия център на столицата.", 11, 2300m, 12 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { "Финалното състезание на сезона в Abu Dhabi е незабравимо. Emirates Palace е един от най-луксозните хотели в света.", 22, 5, 3600m, 22 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { "Spanish GP в Барселона е класика от Формула 1 календара. Hotel Arts предлага панорамна гледка към Средиземно море.", 7, 4, 2100m, 8 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { "Japanese GP в Suzuka е любимото на истинските фенове. Suzuka Circuit Hotel е буквално в рамките на пистата.", 3, 5, 2800m, 17 });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "HotelId", "ImageUrl", "Nights", "Price", "RaceId" },
                values: new object[,]
                {
                    { 13, "Belgian GP в Spa-Francorchamps е едно от най-красивите и предизвикателни трасета в света. Radisson Blu е в сърцето на Spa.", 10, null, 4, 2000m, 13 },
                    { 14, "Canadian GP в Монреал съчетава вълнуващо състезание с космополитния чар на града. Fairmont Queen Elizabeth е иконата на Монреал.", 5, null, 5, 2600m, 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Nights", "Price", "RaceId" },
                values: new object[] { null, 3, 1299.99m, 1 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Nights", "Price", "RaceId" },
                values: new object[] { null, 4, 2499.00m, 2 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { null, 1, 3, 1399.50m, 3 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { null, 6, 5, 3499.00m, 7 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { null, 5, 2, 899.99m, 9 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { null, 9, 2, 799.00m, 11 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { null, 10, 3, 1199.00m, 13 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { null, 13, 3, 1099.50m, 15 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "HotelId", "Price", "RaceId" },
                values: new object[] { null, 16, 1899.99m, 16 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { null, 3, 3, 1299.00m, 17 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { null, 17, 2, 999.99m, 18 });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "HotelId", "Nights", "Price", "RaceId" },
                values: new object[] { null, 22, 4, 2299.00m, 22 });
        }
    }
}
