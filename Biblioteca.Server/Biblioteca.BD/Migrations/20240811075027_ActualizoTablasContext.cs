using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.BD.Migrations
{
    /// <inheritdoc />
    public partial class ActualizoTablasContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Libros_LibroId",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Editorial");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_LibroId",
                table: "Editorial",
                newName: "IX_Editorial_LibroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Editorial",
                table: "Editorial",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Editorial_Libros_LibroId",
                table: "Editorial",
                column: "LibroId",
                principalTable: "Libros",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Editorial_Libros_LibroId",
                table: "Editorial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Editorial",
                table: "Editorial");

            migrationBuilder.RenameTable(
                name: "Editorial",
                newName: "Usuarios");

            migrationBuilder.RenameIndex(
                name: "IX_Editorial_LibroId",
                table: "Usuarios",
                newName: "IX_Usuarios_LibroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Libros_LibroId",
                table: "Usuarios",
                column: "LibroId",
                principalTable: "Libros",
                principalColumn: "Id");
        }
    }
}
