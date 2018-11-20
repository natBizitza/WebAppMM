using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMM.Data.Migrations
{
    public partial class updateView2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Places_PlaceIDPlace",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_ViewModel_ViewModelID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PlaceIDPlace",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ViewModelID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PlaceIDPlace",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ViewModelID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "IDUser",
                table: "Users",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "IDPlace",
                table: "Places",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "ViewModel",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Places",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ViewModel_UserID",
                table: "ViewModel",
                column: "UserID");

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
                name: "FK_ViewModel_Users_UserID",
                table: "ViewModel",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_Users_UserID",
                table: "Places");

            migrationBuilder.DropForeignKey(
                name: "FK_ViewModel_Users_UserID",
                table: "ViewModel");

            migrationBuilder.DropIndex(
                name: "IX_ViewModel_UserID",
                table: "ViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Places_UserID",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "ViewModel");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Places");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Users",
                newName: "IDUser");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Places",
                newName: "IDPlace");

            migrationBuilder.AddColumn<int>(
                name: "PlaceIDPlace",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ViewModelID",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PlaceIDPlace",
                table: "Users",
                column: "PlaceIDPlace");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ViewModelID",
                table: "Users",
                column: "ViewModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Places_PlaceIDPlace",
                table: "Users",
                column: "PlaceIDPlace",
                principalTable: "Places",
                principalColumn: "IDPlace",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ViewModel_ViewModelID",
                table: "Users",
                column: "ViewModelID",
                principalTable: "ViewModel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
