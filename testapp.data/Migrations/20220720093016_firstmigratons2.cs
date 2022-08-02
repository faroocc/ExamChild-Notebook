using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace testapp.data.Migrations
{
    public partial class firstmigratons2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "KpssResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_KpssResults_AppUserId",
                table: "KpssResults",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_KpssResults_AspNetUsers_AppUserId",
                table: "KpssResults",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KpssResults_AspNetUsers_AppUserId",
                table: "KpssResults");

            migrationBuilder.DropIndex(
                name: "IX_KpssResults_AppUserId",
                table: "KpssResults");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "KpssResults");
        }
    }
}
