using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoLaGran7.BD.Migrations
{
    /// <inheritdoc />
    public partial class IndicesReservaNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Reserva_ReservaId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "Usuario_UQ",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "ReservaId",
                table: "Usuarios",
                newName: "ReservaID");

            migrationBuilder.RenameIndex(
                name: "Reserva_UQ",
                table: "Reserva",
                newName: "ReservaId_UQ");

            migrationBuilder.AlterColumn<int>(
                name: "ReservaID",
                table: "Usuarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 4);

            migrationBuilder.AddColumn<int>(
                name: "IdReserva",
                table: "Usuarios",
                type: "int",
                maxLength: 4,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Usuarios",
                type: "int",
                maxLength: 4,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "metodoPago",
                table: "Pago",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaPago",
                table: "Pago",
                type: "datetime2",
                maxLength: 30,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPago",
                table: "Pago",
                type: "int",
                maxLength: 4,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Ubicaciòn",
                table: "Cancha",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Cancha",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Cancha",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCancha",
                table: "Cancha",
                type: "int",
                maxLength: 2,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ReservaID",
                table: "Usuarios",
                column: "ReservaID");

            migrationBuilder.CreateIndex(
                name: "UsuarioId_UQ",
                table: "Usuarios",
                column: "IdUsuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IdPago_UQ",
                table: "Pago",
                column: "IdPago",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Monto_FechaPago_MétodoPago",
                table: "Pago",
                columns: new[] { "Monto", "FechaPago", "metodoPago" });

            migrationBuilder.CreateIndex(
                name: "Cancha_UQ",
                table: "Cancha",
                column: "IdCancha",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Nombre_Ubicación_Estado",
                table: "Cancha",
                columns: new[] { "Nombre", "Ubicaciòn", "Estado" });

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Reserva_ReservaID",
                table: "Usuarios",
                column: "ReservaID",
                principalTable: "Reserva",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Reserva_ReservaID",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_ReservaID",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "UsuarioId_UQ",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IdPago_UQ",
                table: "Pago");

            migrationBuilder.DropIndex(
                name: "Monto_FechaPago_MétodoPago",
                table: "Pago");

            migrationBuilder.DropIndex(
                name: "Cancha_UQ",
                table: "Cancha");

            migrationBuilder.DropIndex(
                name: "Nombre_Ubicación_Estado",
                table: "Cancha");

            migrationBuilder.DropColumn(
                name: "IdReserva",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IdPago",
                table: "Pago");

            migrationBuilder.DropColumn(
                name: "IdCancha",
                table: "Cancha");

            migrationBuilder.RenameColumn(
                name: "ReservaID",
                table: "Usuarios",
                newName: "ReservaId");

            migrationBuilder.RenameIndex(
                name: "ReservaId_UQ",
                table: "Reserva",
                newName: "Reserva_UQ");

            migrationBuilder.AlterColumn<int>(
                name: "ReservaId",
                table: "Usuarios",
                type: "int",
                maxLength: 4,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "metodoPago",
                table: "Pago",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaPago",
                table: "Pago",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Ubicaciòn",
                table: "Cancha",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Cancha",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Cancha",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "Usuario_UQ",
                table: "Usuarios",
                column: "ReservaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Reserva_ReservaId",
                table: "Usuarios",
                column: "ReservaId",
                principalTable: "Reserva",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
