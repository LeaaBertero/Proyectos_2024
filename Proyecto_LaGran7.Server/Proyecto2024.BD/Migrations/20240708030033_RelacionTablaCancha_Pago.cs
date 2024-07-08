using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoLaGran7.BD.Migrations
{
    /// <inheritdoc />
    public partial class RelacionTablaCancha_Pago : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPago",
                table: "Cancha",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdReserva",
                table: "Cancha",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagoID",
                table: "Cancha",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cancha_PagoID",
                table: "Cancha",
                column: "PagoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cancha_Pago_PagoID",
                table: "Cancha",
                column: "PagoID",
                principalTable: "Pago",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cancha_Pago_PagoID",
                table: "Cancha");

            migrationBuilder.DropIndex(
                name: "IX_Cancha_PagoID",
                table: "Cancha");

            migrationBuilder.DropColumn(
                name: "IdPago",
                table: "Cancha");

            migrationBuilder.DropColumn(
                name: "IdReserva",
                table: "Cancha");

            migrationBuilder.DropColumn(
                name: "PagoID",
                table: "Cancha");
        }
    }
}
