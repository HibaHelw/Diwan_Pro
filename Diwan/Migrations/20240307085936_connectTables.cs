using Microsoft.EntityFrameworkCore.Migrations;

namespace DiwanModels.Migrations
{
    public partial class connectTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostStateId",
                schema: "Diwan",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PostTypeId",
                schema: "Diwan",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SenderId",
                schema: "Diwan",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PostID",
                schema: "Diwan",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostStateId",
                schema: "Diwan",
                table: "Posts",
                column: "PostStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostTypeId",
                schema: "Diwan",
                table: "Posts",
                column: "PostTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_SenderId",
                schema: "Diwan",
                table: "Posts",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PostID",
                schema: "Diwan",
                table: "Employees",
                column: "PostID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Posts_PostID",
                schema: "Diwan",
                table: "Employees",
                column: "PostID",
                principalSchema: "Diwan",
                principalTable: "Posts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Employees_SenderId",
                schema: "Diwan",
                table: "Posts",
                column: "SenderId",
                principalSchema: "Diwan",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_PostStates_PostStateId",
                schema: "Diwan",
                table: "Posts",
                column: "PostStateId",
                principalSchema: "Diwan",
                principalTable: "PostStates",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_PostTypes_PostTypeId",
                schema: "Diwan",
                table: "Posts",
                column: "PostTypeId",
                principalSchema: "Diwan",
                principalTable: "PostTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Posts_PostID",
                schema: "Diwan",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Employees_SenderId",
                schema: "Diwan",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostStates_PostStateId",
                schema: "Diwan",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostTypes_PostTypeId",
                schema: "Diwan",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostStateId",
                schema: "Diwan",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostTypeId",
                schema: "Diwan",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_SenderId",
                schema: "Diwan",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PostID",
                schema: "Diwan",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PostStateId",
                schema: "Diwan",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostTypeId",
                schema: "Diwan",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "SenderId",
                schema: "Diwan",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostID",
                schema: "Diwan",
                table: "Employees");
        }
    }
}
