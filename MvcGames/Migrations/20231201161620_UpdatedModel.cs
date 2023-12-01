using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcGames.Migrations
{
    public partial class UpdatedModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Developer",
                table: "Games",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Games",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Developer",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Games");
        }
    }
}
