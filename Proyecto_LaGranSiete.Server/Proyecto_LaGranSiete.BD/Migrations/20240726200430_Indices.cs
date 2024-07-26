using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class Indices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MetodoPago",
                table: "Reservas",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EstadoReserva",
                table: "Reservas",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "Reserva_FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva",
                table: "Reservas",
                columns: new[] { "FechaHoraReserva", "DuracionAlquiler", "Monto", "MetodoPago", "EstadoReserva" });

            migrationBuilder.CreateIndex(
                name: "ReservaId_UQ",
                table: "Reservas",
                column: "IdReserva",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "Reserva_FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "ReservaId_UQ",
                table: "Reservas");

            migrationBuilder.AlterColumn<string>(
                name: "MetodoPago",
                table: "Reservas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EstadoReserva",
                table: "Reservas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
