using Microsoft.EntityFrameworkCore.Migrations;

namespace DiwanModels.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PostEmployees_PostId",
                schema: "Diwan",
                table: "PostEmployees",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostEmployees_Posts_PostId",
                schema: "Diwan",
                table: "PostEmployees",
                column: "PostId",
                principalSchema: "Diwan",
                principalTable: "Posts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostEmployees_Posts_PostId",
                schema: "Diwan",
                table: "PostEmployees");

            migrationBuilder.DropIndex(
                name: "IX_PostEmployees_PostId",
                schema: "Diwan",
                table: "PostEmployees");
        }
    }
}
