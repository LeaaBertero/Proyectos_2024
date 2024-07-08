using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoLaGran7.BD.Migrations
{
    /// <inheritdoc />
    public partial class RelacionTablaUsuarios_Pago : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPago",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagoID",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PagoID",
                table: "Usuarios",
                column: "PagoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Pago_PagoID",
                table: "Usuarios",
                column: "PagoID",
                principalTable: "Pago",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Pago_PagoID",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_PagoID",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IdPago",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PagoID",
                table: "Usuarios");
        }
    }
}
