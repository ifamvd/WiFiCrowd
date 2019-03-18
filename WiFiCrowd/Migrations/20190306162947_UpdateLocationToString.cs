using Microsoft.EntityFrameworkCore.Migrations;

namespace WiFiCrowd.Migrations
{
    public partial class UpdateLocationToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lat",
                table: "Markers");

            migrationBuilder.DropColumn(
                name: "Lng",
                table: "Markers");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Markers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Markers");

            migrationBuilder.AddColumn<double>(
                name: "Lat",
                table: "Markers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Lng",
                table: "Markers",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
