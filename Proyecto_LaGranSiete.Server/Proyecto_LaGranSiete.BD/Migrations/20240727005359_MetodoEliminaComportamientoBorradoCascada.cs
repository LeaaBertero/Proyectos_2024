using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class MetodoEliminaComportamientoBorradoCascada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Partidos_PartidosId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Canchas_CanchasId",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Canchas_CanchasId",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Partidos_PartidosId",
                table: "Reservas");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Partidos_PartidosId",
                table: "Equipos",
                column: "PartidosId",
                principalTable: "Partidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Canchas_CanchasId",
                table: "Pagos",
                column: "CanchasId",
                principalTable: "Canchas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Canchas_CanchasId",
                table: "Partidos",
                column: "CanchasId",
                principalTable: "Canchas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Partidos_PartidosId",
                table: "Reservas",
                column: "PartidosId",
                principalTable: "Partidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Partidos_PartidosId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Canchas_CanchasId",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Canchas_CanchasId",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Partidos_PartidosId",
                table: "Reservas");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Partidos_PartidosId",
                table: "Equipos",
                column: "PartidosId",
                principalTable: "Partidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Canchas_CanchasId",
                table: "Pagos",
                column: "CanchasId",
                principalTable: "Canchas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Canchas_CanchasId",
                table: "Partidos",
                column: "CanchasId",
                principalTable: "Canchas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Partidos_PartidosId",
                table: "Reservas",
                column: "PartidosId",
                principalTable: "Partidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
