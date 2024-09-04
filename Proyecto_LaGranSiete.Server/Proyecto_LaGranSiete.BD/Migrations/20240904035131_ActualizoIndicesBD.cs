using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class ActualizoIndicesBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva",
                table: "Reservas",
                newName: "Reserva_FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva");

            migrationBuilder.RenameIndex(
                name: "FechaHoraPartidos",
                table: "Partidos",
                newName: "Partido_FechaHoraPartidos");

            migrationBuilder.RenameIndex(
                name: "Monto_Pago_FechaPago",
                table: "Pagos",
                newName: "Pago_Monto_Pago_FechaPago");

            migrationBuilder.RenameIndex(
                name: "NombreEquipoUno",
                table: "EquipoUno",
                newName: "EquipoUno_NombreEquipoUno");

            migrationBuilder.RenameIndex(
                name: "NombreEquipos_Integrantes",
                table: "Equipos",
                newName: "Equipo_NombreEquipos_Integrantes");

            migrationBuilder.RenameIndex(
                name: "NombreEquipoDos",
                table: "EquipoDos",
                newName: "EquipoDos_NombreEquipoDos");

            migrationBuilder.RenameIndex(
                name: "NombreCancha_Disponibilidad",
                table: "Canchas",
                newName: "Cancha_NombreCancha_Disponibilidad");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "Reserva_FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva",
                table: "Reservas",
                newName: "FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva");

            migrationBuilder.RenameIndex(
                name: "Partido_FechaHoraPartidos",
                table: "Partidos",
                newName: "FechaHoraPartidos");

            migrationBuilder.RenameIndex(
                name: "Pago_Monto_Pago_FechaPago",
                table: "Pagos",
                newName: "Monto_Pago_FechaPago");

            migrationBuilder.RenameIndex(
                name: "EquipoUno_NombreEquipoUno",
                table: "EquipoUno",
                newName: "NombreEquipoUno");

            migrationBuilder.RenameIndex(
                name: "Equipo_NombreEquipos_Integrantes",
                table: "Equipos",
                newName: "NombreEquipos_Integrantes");

            migrationBuilder.RenameIndex(
                name: "EquipoDos_NombreEquipoDos",
                table: "EquipoDos",
                newName: "NombreEquipoDos");

            migrationBuilder.RenameIndex(
                name: "Cancha_NombreCancha_Disponibilidad",
                table: "Canchas",
                newName: "NombreCancha_Disponibilidad");
        }
    }
}
