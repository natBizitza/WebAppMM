using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMM.Data.Migrations
{
    public partial class identityhalftry2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         


            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        FirstName = table.Column<string>(nullable: true),
            //        LastName = table.Column<string>(nullable: true),
            //        Gender = table.Column<string>(nullable: false),
            //        BirthDate = table.Column<DateTime>(nullable: false),
            //        PhoneNumber = table.Column<string>(nullable: true),
            //        Email = table.Column<string>(nullable: true),
            //        LanguagePreferred = table.Column<string>(nullable: true),
            //        Currency = table.Column<string>(nullable: true),
            //        AboutMe = table.Column<string>(nullable: true),
            //        DateOfRegistration = table.Column<DateTime>(nullable: false),
            //        PlaceID = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_Users_Places_PlaceID",
            //            column: x => x.PlaceID,
            //            principalTable: "Places",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_PlaceID",
            //    table: "Users",
            //    column: "PlaceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.AddColumn<string>(
                name: "AboutMe",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LanguagePreferred",
                table: "AspNetUsers",
                nullable: true);
        }
    }
}
