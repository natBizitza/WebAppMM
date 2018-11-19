using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMM.Data.Migrations
{
    public partial class table_viewmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ViewModelID",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ViewModelID",
                table: "Places",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ViewModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewModel", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_ViewModelID",
                table: "Users",
                column: "ViewModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Places_ViewModelID",
                table: "Places",
                column: "ViewModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Places_ViewModel_ViewModelID",
                table: "Places",
                column: "ViewModelID",
                principalTable: "ViewModel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ViewModel_ViewModelID",
                table: "Users",
                column: "ViewModelID",
                principalTable: "ViewModel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_ViewModel_ViewModelID",
                table: "Places");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_ViewModel_ViewModelID",
                table: "Users");

            migrationBuilder.DropTable(
                name: "ViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Users_ViewModelID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Places_ViewModelID",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "ViewModelID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ViewModelID",
                table: "Places");
        }
    }
}
