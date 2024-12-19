using Microsoft.EntityFrameworkCore.Migrations;

namespace DiwanModels.Migrations
{
    public partial class numberOfPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Number",
                schema: "Diwan",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                schema: "Diwan",
                table: "Posts");
        }
    }
}
