using Microsoft.EntityFrameworkCore.Migrations;

namespace WiFiCrowd.Migrations
{
    public partial class AddedURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Markers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Markers");
        }
    }
}
