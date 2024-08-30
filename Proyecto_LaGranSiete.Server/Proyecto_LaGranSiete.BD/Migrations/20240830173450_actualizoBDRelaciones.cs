using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class actualizoBDRelaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipoDos_Reservas_ReservaId",
                table: "EquipoDos");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipoUno_Reservas_ReservaId",
                table: "EquipoUno");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Equipos_EquipoId",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "IX_Partidos_EquipoId",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "IX_EquipoUno_ReservaId",
                table: "EquipoUno");

            migrationBuilder.DropIndex(
                name: "IX_EquipoDos_ReservaId",
                table: "EquipoDos");

            migrationBuilder.DropColumn(
                name: "EquipoId",
                table: "Partidos");

            migrationBuilder.DropColumn(
                name: "ReservaId",
                table: "EquipoUno");

            migrationBuilder.DropColumn(
                name: "ReservaId",
                table: "EquipoDos");

            migrationBuilder.AddColumn<int>(
                name: "ReservaId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipoDosId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EquipoUnoId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartidoId",
                table: "Equipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ReservaId",
                table: "Usuarios",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_EquipoDosId",
                table: "Reservas",
                column: "EquipoDosId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_EquipoUnoId",
                table: "Reservas",
                column: "EquipoUnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_PartidoId",
                table: "Equipos",
                column: "PartidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Partidos_PartidoId",
                table: "Equipos",
                column: "PartidoId",
                principalTable: "Partidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_EquipoDos_EquipoDosId",
                table: "Reservas",
                column: "EquipoDosId",
                principalTable: "EquipoDos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_EquipoUno_EquipoUnoId",
                table: "Reservas",
                column: "EquipoUnoId",
                principalTable: "EquipoUno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Reservas_ReservaId",
                table: "Usuarios",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Partidos_PartidoId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_EquipoDos_EquipoDosId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_EquipoUno_EquipoUnoId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Reservas_ReservaId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_ReservaId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_EquipoDosId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_EquipoUnoId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_PartidoId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "ReservaId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EquipoDosId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "EquipoUnoId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "PartidoId",
                table: "Equipos");

            migrationBuilder.AddColumn<int>(
                name: "EquipoId",
                table: "Partidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservaId",
                table: "EquipoUno",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservaId",
                table: "EquipoDos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_EquipoId",
                table: "Partidos",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipoUno_ReservaId",
                table: "EquipoUno",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipoDos_ReservaId",
                table: "EquipoDos",
                column: "ReservaId");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipoDos_Reservas_ReservaId",
                table: "EquipoDos",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipoUno_Reservas_ReservaId",
                table: "EquipoUno",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Equipos_EquipoId",
                table: "Partidos",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
