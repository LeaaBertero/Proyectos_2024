using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoLaGran7.BD.Migrations
{
    /// <inheritdoc />
    public partial class ActualizoTablaPagos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PagoID",
                table: "Pago",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pago_PagoID",
                table: "Pago",
                column: "PagoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pago_Pago_PagoID",
                table: "Pago",
                column: "PagoID",
                principalTable: "Pago",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pago_Pago_PagoID",
                table: "Pago");

            migrationBuilder.DropIndex(
                name: "IX_Pago_PagoID",
                table: "Pago");

            migrationBuilder.DropColumn(
                name: "PagoID",
                table: "Pago");
        }
    }
}
