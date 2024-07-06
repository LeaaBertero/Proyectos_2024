using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoLaGran7.BD.Migrations
{
    /// <inheritdoc />
    public partial class ActualizoIndice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contrasenia",
                table: "Usuarios",
                newName: "Contraseña");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contraseña",
                table: "Usuarios",
                newName: "Contrasenia");
        }
    }
}
