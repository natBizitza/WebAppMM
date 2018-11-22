using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMM.Data.Migrations
{
    public partial class viewmodel13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_Users_UserID",
                table: "Places");

            migrationBuilder.DropForeignKey(
                name: "FK_ViewModel_Places_PlaceID",
                table: "ViewModel");

            migrationBuilder.DropIndex(
                name: "IX_ViewModel_PlaceID",
                table: "ViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Places_UserID",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "PlaceID",
                table: "ViewModel");

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
                name: "PlaceID",
                table: "ViewModel",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Places",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ViewModel_PlaceID",
                table: "ViewModel",
                column: "PlaceID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ViewModel_Places_PlaceID",
                table: "ViewModel",
                column: "PlaceID",
                principalTable: "Places",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
