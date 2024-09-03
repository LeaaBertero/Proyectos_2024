using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class ActualizoIndices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservas_ReservaId",
                table: "Reservas");

            migrationBuilder.AlterColumn<string>(
                name: "MetodoPago",
                table: "Reservas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EstadoReserva",
                table: "Reservas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva",
                table: "Reservas",
                columns: new[] { "FechaHoraReserva", "DuracionAlquiler", "Monto", "MetodoPago", "EstadoReserva" });

            migrationBuilder.CreateIndex(
                name: "ReservaId",
                table: "Reservas",
                column: "ReservaId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "ReservaId",
                table: "Reservas");

            migrationBuilder.AlterColumn<string>(
                name: "MetodoPago",
                table: "Reservas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "EstadoReserva",
                table: "Reservas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ReservaId",
                table: "Reservas",
                column: "ReservaId");
        }
    }
}
