using Microsoft.EntityFrameworkCore.Migrations;

namespace WiFiCrowd.Migrations
{
    public partial class LatLngUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Markers",
                newName: "Lng");

            migrationBuilder.AddColumn<string>(
                name: "Lat",
                table: "Markers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lat",
                table: "Markers");

            migrationBuilder.RenameColumn(
                name: "Lng",
                table: "Markers",
                newName: "Location");
        }
    }
}
