using Microsoft.EntityFrameworkCore.Migrations;

namespace MastersClass_MVC.Migrations
{
    public partial class newwatchcount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "turkishwatch",
                table: "users",
                newName: "turkishlevel3");

            migrationBuilder.RenameColumn(
                name: "italianwatch",
                table: "users",
                newName: "turkishlevel2");

            migrationBuilder.RenameColumn(
                name: "fareastwatch",
                table: "users",
                newName: "turkishlevel1");

            migrationBuilder.AddColumn<int>(
                name: "fareastlevel1",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fareastlevel2",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fareastlevel3",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "italianlevel1",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "italianlevel2",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "italianlevel3",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fareastlevel1",
                table: "users");

            migrationBuilder.DropColumn(
                name: "fareastlevel2",
                table: "users");

            migrationBuilder.DropColumn(
                name: "fareastlevel3",
                table: "users");

            migrationBuilder.DropColumn(
                name: "italianlevel1",
                table: "users");

            migrationBuilder.DropColumn(
                name: "italianlevel2",
                table: "users");

            migrationBuilder.DropColumn(
                name: "italianlevel3",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "turkishlevel3",
                table: "users",
                newName: "turkishwatch");

            migrationBuilder.RenameColumn(
                name: "turkishlevel2",
                table: "users",
                newName: "italianwatch");

            migrationBuilder.RenameColumn(
                name: "turkishlevel1",
                table: "users",
                newName: "fareastwatch");
        }
    }
}
