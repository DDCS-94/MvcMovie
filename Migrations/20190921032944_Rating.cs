using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "price",
                table: "Movie",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "genre",
                table: "Movie",
                newName: "Genre");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Movie",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Movie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Movie",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Movie",
                newName: "genre");

            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");
        }
    }
}
