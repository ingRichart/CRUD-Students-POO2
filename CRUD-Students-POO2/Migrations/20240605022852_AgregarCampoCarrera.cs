using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_Students_POO2.Migrations
{
    /// <inheritdoc />
    public partial class AgregarCampoCarrera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Carrera",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Carrera",
                table: "Students");
        }
    }
}
