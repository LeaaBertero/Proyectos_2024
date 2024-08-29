using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class ActualioRelacionCanchaPago : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CanchaId",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_CanchaId",
                table: "Pagos",
                column: "CanchaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Canchas_CanchaId",
                table: "Pagos",
                column: "CanchaId",
                principalTable: "Canchas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Canchas_CanchaId",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_CanchaId",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "CanchaId",
                table: "Pagos");
        }
    }
}
