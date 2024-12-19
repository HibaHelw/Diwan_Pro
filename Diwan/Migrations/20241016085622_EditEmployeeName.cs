using Microsoft.EntityFrameworkCore.Migrations;

namespace DiwanModels.Migrations
{
    public partial class EditEmployeeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "Diwan",
                table: "Employees",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                schema: "Diwan",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "Diwan",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FatherName",
                schema: "Diwan",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "Diwan",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "LastName",
                schema: "Diwan",
                table: "Employees",
                newName: "Name");
        }
    }
}
