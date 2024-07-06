using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoLaGran7.BD.Migrations
{
    /// <inheritdoc />
    public partial class IndicesReserva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "fechaReserva_HoraInicio_HoraFin_Estado",
                table: "Reserva",
                columns: new[] { "fechaReserva", "HoraInicio", "HoraFin", "Estado" });

            migrationBuilder.CreateIndex(
                name: "Reserva_UQ",
                table: "Reserva",
                column: "IdReserva",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "fechaReserva_HoraInicio_HoraFin_Estado",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "Reserva_UQ",
                table: "Reserva");
        }
    }
}
