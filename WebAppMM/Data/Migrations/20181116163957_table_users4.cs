using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMM.Data.Migrations
{
    public partial class table_users4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_Users_UserID",
                table: "Places");

            migrationBuilder.DropIndex(
                name: "IX_Places_UserID",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Places");

            migrationBuilder.AddColumn<int>(
                name: "PlaceID",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PlaceID",
                table: "Users",
                column: "PlaceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Places_PlaceID",
                table: "Users",
                column: "PlaceID",
                principalTable: "Places",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Places_PlaceID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PlaceID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PlaceID",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Places",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Places_UserID",
                table: "Places",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Users_UserID",
                table: "Places",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
