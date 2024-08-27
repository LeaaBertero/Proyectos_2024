using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class pepe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "Reserva_FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva",
                table: "Reservas",
                newName: "FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaHoraReserva",
                table: "Reservas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "EstadoReserva",
                table: "Reservas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva",
                table: "Reservas",
                newName: "Reserva_FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "FechaHoraReserva",
                table: "Reservas",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "EstadoReserva",
                table: "Reservas",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
