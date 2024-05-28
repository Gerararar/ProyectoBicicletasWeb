using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_Bicicletas_Web.Migrations
{
    /// <inheritdoc />
    public partial class productos2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "Productos");
        }
    }
}
