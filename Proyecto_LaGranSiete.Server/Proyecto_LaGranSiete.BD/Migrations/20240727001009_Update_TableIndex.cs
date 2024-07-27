using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "FechaHoraPartidos",
                table: "Partidos",
                column: "FechaHoraPartidos");

            migrationBuilder.CreateIndex(
                name: "IdPartidos",
                table: "Partidos",
                column: "IdPartidos",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IdPago",
                table: "Pagos",
                column: "IdPago",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Monto_Pago_FechaPago",
                table: "Pagos",
                columns: new[] { "Monto_Pago", "FechaPago" });

            migrationBuilder.CreateIndex(
                name: "IdEquipos",
                table: "Equipos",
                column: "IdEquipos",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NombreEquipos_Integrantes",
                table: "Equipos",
                columns: new[] { "NombreEquipos", "Integrantes" });

            migrationBuilder.CreateIndex(
                name: "IdCanchas",
                table: "Canchas",
                column: "IdCanchas",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "NombreCancha_Disponibilidad",
                table: "Canchas",
                columns: new[] { "NombreCancha", "Disponibilidad" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "FechaHoraPartidos",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "IdPartidos",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "IdPago",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "Monto_Pago_FechaPago",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IdEquipos",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "NombreEquipos_Integrantes",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IdCanchas",
                table: "Canchas");

            migrationBuilder.DropIndex(
                name: "NombreCancha_Disponibilidad",
                table: "Canchas");
        }
    }
}
