using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraRelacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservaId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservasId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ReservasId",
                table: "Usuarios",
                column: "ReservasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Reservas_ReservasId",
                table: "Usuarios",
                column: "ReservasId",
                principalTable: "Reservas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Reservas_ReservasId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_ReservasId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ReservaId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ReservasId",
                table: "Usuarios");
        }
    }
}
