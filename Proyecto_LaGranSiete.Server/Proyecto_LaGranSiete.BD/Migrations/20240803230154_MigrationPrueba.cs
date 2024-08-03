using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class MigrationPrueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaHoraReserva",
                table: "Reservas",
                type: "datetime2",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "ReservasId",
                table: "Reservas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ReservasId",
                table: "Reservas",
                column: "ReservasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Reservas_ReservasId",
                table: "Reservas",
                column: "ReservasId",
                principalTable: "Reservas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Reservas_ReservasId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_ReservasId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "ReservasId",
                table: "Reservas");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "FechaHoraReserva",
                table: "Reservas",
                type: "date",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 20);
        }
    }
}
