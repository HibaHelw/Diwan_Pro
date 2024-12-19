using Microsoft.EntityFrameworkCore.Migrations;

namespace DiwanModels.Migrations
{
    public partial class employeeInformations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                schema: "Diwan",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone1",
                schema: "Diwan",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone2",
                schema: "Diwan",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                schema: "Diwan",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                schema: "Diwan",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Phone1",
                schema: "Diwan",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Phone2",
                schema: "Diwan",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Position",
                schema: "Diwan",
                table: "Employees");
        }
    }
}
