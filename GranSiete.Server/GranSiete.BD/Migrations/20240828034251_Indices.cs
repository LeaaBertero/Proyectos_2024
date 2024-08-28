using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GranSiete.BD.Migrations
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
                name: "Reserva_Monto_MetodoPago_EstadoReserva",
                table: "Reservas",
                columns: new[] { "Monto", "MetodoPago", "EstadoReserva" });

            migrationBuilder.CreateIndex(
                name: "Reserva_UQ",
                table: "Reservas",
                columns: new[] { "UsuarioID", "EstadoReserva" },
                unique: true,
                filter: "[EstadoReserva] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Usuarios_UsuarioID",
                table: "Reservas",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Usuarios_UsuarioID",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "Reserva_Monto_MetodoPago_EstadoReserva",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "Reserva_UQ",
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
