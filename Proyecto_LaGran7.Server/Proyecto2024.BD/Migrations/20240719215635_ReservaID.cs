using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoLaGran7.BD.Migrations
{
    /// <inheritdoc />
    public partial class ReservaID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Reservas_ReservasID",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_ReservasID",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "IdCancha",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ReservasID",
                table: "Pagos");

            migrationBuilder.AddColumn<int>(
                name: "ReservaId",
                table: "Canchas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Canchas_ReservaId",
                table: "Canchas",
                column: "ReservaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Canchas_Reservas_ReservaId",
                table: "Canchas",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Canchas_Reservas_ReservaId",
                table: "Canchas");

            migrationBuilder.DropIndex(
                name: "IX_Canchas_ReservaId",
                table: "Canchas");

            migrationBuilder.DropColumn(
                name: "ReservaId",
                table: "Canchas");

            migrationBuilder.AddColumn<int>(
                name: "IdCancha",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservasID",
                table: "Pagos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_ReservasID",
                table: "Pagos",
                column: "ReservasID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Reservas_ReservasID",
                table: "Pagos",
                column: "ReservasID",
                principalTable: "Reservas",
                principalColumn: "ID");
        }
    }
}
