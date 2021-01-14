using Microsoft.EntityFrameworkCore.Migrations;

namespace Nemes_Bianca_Proiect2.Migrations
{
    public partial class Movement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Movement",
                table: "Artwork",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Movement",
                table: "Artwork");
        }
    }
}
