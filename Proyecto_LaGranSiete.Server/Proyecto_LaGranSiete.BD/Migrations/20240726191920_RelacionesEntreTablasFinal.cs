using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class RelacionesEntreTablasFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PagoId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagosId",
                table: "Reservas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartidosId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CanchasId",
                table: "Partidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CanchasId",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartidosId",
                table: "Equipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_PagosId",
                table: "Reservas",
                column: "PagosId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_PartidosId",
                table: "Reservas",
                column: "PartidosId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_CanchasId",
                table: "Partidos",
                column: "CanchasId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_CanchasId",
                table: "Pagos",
                column: "CanchasId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_PartidosId",
                table: "Equipos",
                column: "PartidosId");

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
                name: "FK_Reservas_Pagos_PagosId",
                table: "Reservas",
                column: "PagosId",
                principalTable: "Pagos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Partidos_PartidosId",
                table: "Reservas",
                column: "PartidosId",
                principalTable: "Partidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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
                name: "FK_Reservas_Pagos_PagosId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Partidos_PartidosId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_PagosId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_PartidosId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Partidos_CanchasId",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_CanchasId",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_PartidosId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "PagoId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "PagosId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "PartidosId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "CanchasId",
                table: "Partidos");

            migrationBuilder.DropColumn(
                name: "CanchasId",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "PartidosId",
                table: "Equipos");
        }
    }
}
