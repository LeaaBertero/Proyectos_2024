using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoLaGran7.BD.Migrations
{
    /// <inheritdoc />
    public partial class ActaulizoListaReservaUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservaID",
                table: "Reserva",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuariosID",
                table: "Reserva",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_ReservaID",
                table: "Reserva",
                column: "ReservaID");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_UsuariosID",
                table: "Reserva",
                column: "UsuariosID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Reserva_ReservaID",
                table: "Reserva",
                column: "ReservaID",
                principalTable: "Reserva",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Usuarios_UsuariosID",
                table: "Reserva",
                column: "UsuariosID",
                principalTable: "Usuarios",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Reserva_ReservaID",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Usuarios_UsuariosID",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_ReservaID",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_UsuariosID",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "ReservaID",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "UsuariosID",
                table: "Reserva");
        }
    }
}
