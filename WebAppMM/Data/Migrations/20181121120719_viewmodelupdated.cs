using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMM.Data.Migrations
{
    public partial class viewmodelupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlaceID",
                table: "ViewModel",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ViewModel_PlaceID",
                table: "ViewModel",
                column: "PlaceID");

            migrationBuilder.AddForeignKey(
                name: "FK_ViewModel_Places_PlaceID",
                table: "ViewModel",
                column: "PlaceID",
                principalTable: "Places",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ViewModel_Places_PlaceID",
                table: "ViewModel");

            migrationBuilder.DropIndex(
                name: "IX_ViewModel_PlaceID",
                table: "ViewModel");

            migrationBuilder.DropColumn(
                name: "PlaceID",
                table: "ViewModel");
        }
    }
}
