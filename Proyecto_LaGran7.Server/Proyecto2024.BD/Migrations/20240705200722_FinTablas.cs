using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoLaGran7.BD.Migrations
{
    /// <inheritdoc />
    public partial class FinTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contrasenia",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rol",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Reserva",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HoraFin",
                table: "Reserva",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HoraInicio",
                table: "Reserva",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCancha",
                table: "Reserva",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdReserva",
                table: "Reserva",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Reserva",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaReserva",
                table: "Reserva",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaPago",
                table: "Pago",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdReserva",
                table: "Pago",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Monto",
                table: "Pago",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "metodoPago",
                table: "Pago",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contrasenia",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Rol",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "HoraFin",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "HoraInicio",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "IdCancha",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "IdReserva",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "fechaReserva",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "FechaPago",
                table: "Pago");

            migrationBuilder.DropColumn(
                name: "IdReserva",
                table: "Pago");

            migrationBuilder.DropColumn(
                name: "Monto",
                table: "Pago");

            migrationBuilder.DropColumn(
                name: "metodoPago",
                table: "Pago");
        }
    }
}
