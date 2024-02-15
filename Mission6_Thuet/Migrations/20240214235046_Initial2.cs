using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission6_Thuet.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Movies",
                newName: "Director");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "Director",
                table: "Movies",
                newName: "Genre");
        }
    }
}
