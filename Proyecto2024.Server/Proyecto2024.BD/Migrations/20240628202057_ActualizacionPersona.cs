using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto2024.BD.Migrations
{
    /// <inheritdoc />
    public partial class ActualizacionPersona : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumDoc",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "NumDoc",
                table: "Persona");
        }
    }
}
