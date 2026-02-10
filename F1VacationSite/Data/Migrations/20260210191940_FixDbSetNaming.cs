using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1VacationSite.Migrations
{
    /// <inheritdoc />
    public partial class FixDbSetNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Rasec_RaceId1",
                table: "Trips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rasec",
                table: "Rasec");

            migrationBuilder.RenameTable(
                name: "Rasec",
                newName: "Races");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Races",
                table: "Races",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Races_RaceId1",
                table: "Trips",
                column: "RaceId1",
                principalTable: "Races",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Races_RaceId1",
                table: "Trips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Races",
                table: "Races");

            migrationBuilder.RenameTable(
                name: "Races",
                newName: "Rasec");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rasec",
                table: "Rasec",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Rasec_RaceId1",
                table: "Trips",
                column: "RaceId1",
                principalTable: "Rasec",
                principalColumn: "Id");
        }
    }
}
