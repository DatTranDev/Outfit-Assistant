using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutfitAssistant.Migrations
{
    public partial class MigrationsName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AppUsers_AppUserID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_AppUserID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_AppUserID",
                table: "Products",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AppUsers_AppUserID",
                table: "Products",
                column: "AppUserID",
                principalTable: "AppUsers",
                principalColumn: "ID");
        }
    }
}
