using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class Relaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioID",
                table: "EquipoDos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_EquipoDosID",
                table: "Partidos",
                column: "EquipoDosID");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_EquipoUnoID",
                table: "Partidos",
                column: "EquipoUnoID");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_ReservaID",
                table: "Partidos",
                column: "ReservaID");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_ReservaID",
                table: "Pagos",
                column: "ReservaID");

            migrationBuilder.CreateIndex(
                name: "IX_EquipoUno_ReservaID",
                table: "EquipoUno",
                column: "ReservaID");

            migrationBuilder.CreateIndex(
                name: "IX_EquipoUno_UsuarioID",
                table: "EquipoUno",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_EquipoDos_ReservaID",
                table: "EquipoDos",
                column: "ReservaID");

            migrationBuilder.CreateIndex(
                name: "IX_EquipoDos_UsuarioID",
                table: "EquipoDos",
                column: "UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipoDos_Reservas_ReservaID",
                table: "EquipoDos",
                column: "ReservaID",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipoDos_Usuarios_UsuarioID",
                table: "EquipoDos",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipoUno_Reservas_ReservaID",
                table: "EquipoUno",
                column: "ReservaID",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipoUno_Usuarios_UsuarioID",
                table: "EquipoUno",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Reservas_ReservaID",
                table: "Pagos",
                column: "ReservaID",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_EquipoDos_EquipoDosID",
                table: "Partidos",
                column: "EquipoDosID",
                principalTable: "EquipoDos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_EquipoUno_EquipoUnoID",
                table: "Partidos",
                column: "EquipoUnoID",
                principalTable: "EquipoUno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Reservas_ReservaID",
                table: "Partidos",
                column: "ReservaID",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipoDos_Reservas_ReservaID",
                table: "EquipoDos");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipoDos_Usuarios_UsuarioID",
                table: "EquipoDos");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipoUno_Reservas_ReservaID",
                table: "EquipoUno");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipoUno_Usuarios_UsuarioID",
                table: "EquipoUno");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Reservas_ReservaID",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_EquipoDos_EquipoDosID",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_EquipoUno_EquipoUnoID",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Reservas_ReservaID",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "IX_Partidos_EquipoDosID",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "IX_Partidos_EquipoUnoID",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "IX_Partidos_ReservaID",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_ReservaID",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_EquipoUno_ReservaID",
                table: "EquipoUno");

            migrationBuilder.DropIndex(
                name: "IX_EquipoUno_UsuarioID",
                table: "EquipoUno");

            migrationBuilder.DropIndex(
                name: "IX_EquipoDos_ReservaID",
                table: "EquipoDos");

            migrationBuilder.DropIndex(
                name: "IX_EquipoDos_UsuarioID",
                table: "EquipoDos");

            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "EquipoDos");
        }
    }
}
