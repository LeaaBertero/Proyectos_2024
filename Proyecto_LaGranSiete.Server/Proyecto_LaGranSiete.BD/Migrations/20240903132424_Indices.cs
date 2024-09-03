using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class Indices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UsuarioId_UQ",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_UsuarioId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "ReservaId",
                table: "Reservas");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ReservaId",
                table: "Reservas",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "UsuarioId_UQ",
                table: "Reservas",
                column: "UsuarioId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservas_ReservaId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "UsuarioId_UQ",
                table: "Reservas");

            migrationBuilder.CreateIndex(
                name: "UsuarioId_UQ",
                table: "Usuarios",
                columns: new[] { "Nombre", "Apellido", "UsuarioId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_UsuarioId",
                table: "Reservas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "ReservaId",
                table: "Reservas",
                column: "ReservaId",
                unique: true);
        }
    }
}
