using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1VacationSite.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToTrip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Trips");
        }
    }
}
