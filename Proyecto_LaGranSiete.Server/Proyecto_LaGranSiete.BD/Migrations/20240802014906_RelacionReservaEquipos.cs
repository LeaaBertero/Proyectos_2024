using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class RelacionReservaEquipos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EquiposId",
                table: "Reservas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdEquipos",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_EquiposId",
                table: "Reservas",
                column: "EquiposId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Equipos_EquiposId",
                table: "Reservas",
                column: "EquiposId",
                principalTable: "Equipos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Equipos_EquiposId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_EquiposId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "EquiposId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "IdEquipos",
                table: "Reservas");
        }
    }
}
