using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Librarian.Migrations
{
    /// <inheritdoc />
    public partial class fifthMigrationChase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "IsAvailble",
                table: "Books");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
