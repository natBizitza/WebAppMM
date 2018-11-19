using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMM.Data.Migrations
{
    public partial class table_viewmodel6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Places_PlaceID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "PlaceID",
                table: "Users",
                newName: "PlaceIDPlace");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Users",
                newName: "IDUser");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PlaceID",
                table: "Users",
                newName: "IX_Users_PlaceIDPlace");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Places",
                newName: "IDPlace");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Places_PlaceIDPlace",
                table: "Users",
                column: "PlaceIDPlace",
                principalTable: "Places",
                principalColumn: "IDPlace",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Places_PlaceIDPlace",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "PlaceIDPlace",
                table: "Users",
                newName: "PlaceID");

            migrationBuilder.RenameColumn(
                name: "IDUser",
                table: "Users",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PlaceIDPlace",
                table: "Users",
                newName: "IX_Users_PlaceID");

            migrationBuilder.RenameColumn(
                name: "IDPlace",
                table: "Places",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Places_PlaceID",
                table: "Users",
                column: "PlaceID",
                principalTable: "Places",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
