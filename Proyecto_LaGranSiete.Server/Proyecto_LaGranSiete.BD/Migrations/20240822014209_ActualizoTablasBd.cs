using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class ActualizoTablasBd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Partidos_PartidosId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Canchas_CanchasId",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Canchas_CanchasId",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Equipos_EquiposId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Pagos_PagosId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Partidos_PartidosId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Reservas_ReservasId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Reservas_ReservasId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_EquiposId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_PagosId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_PartidosId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_ReservasId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "ReservaId_UQ",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IdPartidos",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "IX_Partidos_CanchasId",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "IdEquipos",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_PartidosId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "EquiposId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "IdEquipos",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "PagosId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "ReservasId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "CanchasId",
                table: "Partidos");

            migrationBuilder.DropColumn(
                name: "IdEquipoDos",
                table: "Partidos");

            migrationBuilder.DropColumn(
                name: "MetodoPago",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "IdEquipos",
                table: "Equipos");

            migrationBuilder.RenameColumn(
                name: "ReservasId",
                table: "Usuarios",
                newName: "EquipoUnoId");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Usuarios",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_ReservasId",
                table: "Usuarios",
                newName: "IX_Usuarios_EquipoUnoId");

            migrationBuilder.RenameColumn(
                name: "PartidosId",
                table: "Reservas",
                newName: "ReservaId");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Reservas",
                newName: "PartidoId");

            migrationBuilder.RenameColumn(
                name: "IdReserva",
                table: "Reservas",
                newName: "EquipoId");

            migrationBuilder.RenameColumn(
                name: "IdReserva",
                table: "Partidos",
                newName: "PartidoId");

            migrationBuilder.RenameColumn(
                name: "IdPartidos",
                table: "Partidos",
                newName: "EquipoId");

            migrationBuilder.RenameColumn(
                name: "IdEquipoUno",
                table: "Partidos",
                newName: "CanchaId");

            migrationBuilder.RenameColumn(
                name: "IdReserva",
                table: "Pagos",
                newName: "PartidoId");

            migrationBuilder.RenameColumn(
                name: "IdPago",
                table: "Pagos",
                newName: "PagoId");

            migrationBuilder.RenameColumn(
                name: "CanchasId",
                table: "Pagos",
                newName: "EquipoId");

            migrationBuilder.RenameIndex(
                name: "IX_Pagos_CanchasId",
                table: "Pagos",
                newName: "IX_Pagos_EquipoId");

            migrationBuilder.RenameIndex(
                name: "IdPago",
                table: "Pagos",
                newName: "PagoId");

            migrationBuilder.RenameColumn(
                name: "PartidosId",
                table: "Equipos",
                newName: "EquipoId");

            migrationBuilder.RenameColumn(
                name: "IdCanchas",
                table: "Canchas",
                newName: "CanchasId");

            migrationBuilder.RenameIndex(
                name: "IdCanchas",
                table: "Canchas",
                newName: "CanchasId");

            migrationBuilder.AlterColumn<int>(
                name: "Telefono",
                table: "Usuarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddColumn<int>(
                name: "EquipoDosId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Monto",
                table: "Reservas",
                type: "decimal(18,2)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "MetodoPago",
                table: "Reservas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<bool>(
                name: "EstadoReserva",
                table: "Reservas",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<int>(
                name: "DuracionAlquiler",
                table: "Reservas",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<decimal>(
                name: "Monto",
                table: "Pagos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "EquipoDosId",
                table: "Pagos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipoUnoId",
                table: "Pagos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetodoPagado",
                table: "Pagos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "NombreEquipos",
                table: "Equipos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<int>(
                name: "Disponibilidad",
                table: "Canchas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.CreateTable(
                name: "EquipoDos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipoDosId = table.Column<int>(type: "int", nullable: false),
                    NombreEquipoDos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PartidoId = table.Column<int>(type: "int", nullable: false),
                    ReservaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipoDos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipoDos_Partidos_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Partidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EquipoDos_Reservas_ReservaId",
                        column: x => x.ReservaId,
                        principalTable: "Reservas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquipoUno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipoUnoId = table.Column<int>(type: "int", nullable: false),
                    NombreEquipoUno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PartidoId = table.Column<int>(type: "int", nullable: false),
                    ReservaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipoUno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipoUno_Partidos_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Partidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EquipoUno_Reservas_ReservaId",
                        column: x => x.ReservaId,
                        principalTable: "Reservas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EquipoDosId",
                table: "Usuarios",
                column: "EquipoDosId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ReservaId",
                table: "Usuarios",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_EquipoId",
                table: "Reservas",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_PagoId",
                table: "Reservas",
                column: "PagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_PartidoId",
                table: "Reservas",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "ReservaId_UQ",
                table: "Reservas",
                column: "ReservaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_CanchaId",
                table: "Partidos",
                column: "CanchaId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_EquipoId",
                table: "Partidos",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "PartidosId",
                table: "Partidos",
                column: "PartidoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_EquipoDosId",
                table: "Pagos",
                column: "EquipoDosId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_EquipoUnoId",
                table: "Pagos",
                column: "EquipoUnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_PartidoId",
                table: "Pagos",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "EquipoId",
                table: "Equipos",
                column: "EquipoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "EquipoDosId",
                table: "EquipoDos",
                column: "EquipoDosId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EquipoDos_PartidoId",
                table: "EquipoDos",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipoDos_ReservaId",
                table: "EquipoDos",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "NombreEquipoDos",
                table: "EquipoDos",
                column: "NombreEquipoDos");

            migrationBuilder.CreateIndex(
                name: "EquipoUnoId",
                table: "EquipoUno",
                column: "EquipoUnoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EquipoUno_PartidoId",
                table: "EquipoUno",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipoUno_ReservaId",
                table: "EquipoUno",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "NombreEquipoUno",
                table: "EquipoUno",
                column: "NombreEquipoUno");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_EquipoDos_EquipoDosId",
                table: "Pagos",
                column: "EquipoDosId",
                principalTable: "EquipoDos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_EquipoUno_EquipoUnoId",
                table: "Pagos",
                column: "EquipoUnoId",
                principalTable: "EquipoUno",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Equipos_EquipoId",
                table: "Pagos",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Partidos_PartidoId",
                table: "Pagos",
                column: "PartidoId",
                principalTable: "Partidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Canchas_CanchaId",
                table: "Partidos",
                column: "CanchaId",
                principalTable: "Canchas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Equipos_EquipoId",
                table: "Partidos",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Equipos_EquipoId",
                table: "Reservas",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Pagos_PagoId",
                table: "Reservas",
                column: "PagoId",
                principalTable: "Pagos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Partidos_PartidoId",
                table: "Reservas",
                column: "PartidoId",
                principalTable: "Partidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Reservas_ReservaId",
                table: "Reservas",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_EquipoDos_EquipoDosId",
                table: "Usuarios",
                column: "EquipoDosId",
                principalTable: "EquipoDos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_EquipoUno_EquipoUnoId",
                table: "Usuarios",
                column: "EquipoUnoId",
                principalTable: "EquipoUno",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Reservas_ReservaId",
                table: "Usuarios",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_EquipoDos_EquipoDosId",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_EquipoUno_EquipoUnoId",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Equipos_EquipoId",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Partidos_PartidoId",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Canchas_CanchaId",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Equipos_EquipoId",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Equipos_EquipoId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Pagos_PagoId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Partidos_PartidoId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Reservas_ReservaId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_EquipoDos_EquipoDosId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_EquipoUno_EquipoUnoId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Reservas_ReservaId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "EquipoDos");

            migrationBuilder.DropTable(
                name: "EquipoUno");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_EquipoDosId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_ReservaId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_EquipoId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_PagoId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_PartidoId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "ReservaId_UQ",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Partidos_CanchaId",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "IX_Partidos_EquipoId",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "PartidosId",
                table: "Partidos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_EquipoDosId",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_EquipoUnoId",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_PartidoId",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "EquipoId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "EquipoDosId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EquipoDosId",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "EquipoUnoId",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "MetodoPagado",
                table: "Pagos");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Usuarios",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "EquipoUnoId",
                table: "Usuarios",
                newName: "ReservasId");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_EquipoUnoId",
                table: "Usuarios",
                newName: "IX_Usuarios_ReservasId");

            migrationBuilder.RenameColumn(
                name: "ReservaId",
                table: "Reservas",
                newName: "PartidosId");

            migrationBuilder.RenameColumn(
                name: "PartidoId",
                table: "Reservas",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "EquipoId",
                table: "Reservas",
                newName: "IdReserva");

            migrationBuilder.RenameColumn(
                name: "PartidoId",
                table: "Partidos",
                newName: "IdReserva");

            migrationBuilder.RenameColumn(
                name: "EquipoId",
                table: "Partidos",
                newName: "IdPartidos");

            migrationBuilder.RenameColumn(
                name: "CanchaId",
                table: "Partidos",
                newName: "IdEquipoUno");

            migrationBuilder.RenameColumn(
                name: "PartidoId",
                table: "Pagos",
                newName: "IdReserva");

            migrationBuilder.RenameColumn(
                name: "PagoId",
                table: "Pagos",
                newName: "IdPago");

            migrationBuilder.RenameColumn(
                name: "EquipoId",
                table: "Pagos",
                newName: "CanchasId");

            migrationBuilder.RenameIndex(
                name: "PagoId",
                table: "Pagos",
                newName: "IdPago");

            migrationBuilder.RenameIndex(
                name: "IX_Pagos_EquipoId",
                table: "Pagos",
                newName: "IX_Pagos_CanchasId");

            migrationBuilder.RenameColumn(
                name: "EquipoId",
                table: "Equipos",
                newName: "PartidosId");

            migrationBuilder.RenameColumn(
                name: "CanchasId",
                table: "Canchas",
                newName: "IdCanchas");

            migrationBuilder.RenameIndex(
                name: "CanchasId",
                table: "Canchas",
                newName: "IdCanchas");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Usuarios",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Monto",
                table: "Reservas",
                type: "real",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "MetodoPago",
                table: "Reservas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "EstadoReserva",
                table: "Reservas",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DuracionAlquiler",
                table: "Reservas",
                type: "datetime2",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddColumn<int>(
                name: "PagosId",
                table: "Reservas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservasId",
                table: "Reservas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CanchasId",
                table: "Partidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEquipoDos",
                table: "Partidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<float>(
                name: "Monto",
                table: "Pagos",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "MetodoPago",
                table: "Pagos",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "NombreEquipos",
                table: "Equipos",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "IdEquipos",
                table: "Equipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Disponibilidad",
                table: "Canchas",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_EquiposId",
                table: "Reservas",
                column: "EquiposId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_PagosId",
                table: "Reservas",
                column: "PagosId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_PartidosId",
                table: "Reservas",
                column: "PartidosId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ReservasId",
                table: "Reservas",
                column: "ReservasId");

            migrationBuilder.CreateIndex(
                name: "ReservaId_UQ",
                table: "Reservas",
                column: "IdReserva",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IdPartidos",
                table: "Partidos",
                column: "IdPartidos",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_CanchasId",
                table: "Partidos",
                column: "CanchasId");

            migrationBuilder.CreateIndex(
                name: "IdEquipos",
                table: "Equipos",
                column: "IdEquipos",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_PartidosId",
                table: "Equipos",
                column: "PartidosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Partidos_PartidosId",
                table: "Equipos",
                column: "PartidosId",
                principalTable: "Partidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Canchas_CanchasId",
                table: "Pagos",
                column: "CanchasId",
                principalTable: "Canchas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Canchas_CanchasId",
                table: "Partidos",
                column: "CanchasId",
                principalTable: "Canchas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Equipos_EquiposId",
                table: "Reservas",
                column: "EquiposId",
                principalTable: "Equipos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Pagos_PagosId",
                table: "Reservas",
                column: "PagosId",
                principalTable: "Pagos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Partidos_PartidosId",
                table: "Reservas",
                column: "PartidosId",
                principalTable: "Partidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Reservas_ReservasId",
                table: "Reservas",
                column: "ReservasId",
                principalTable: "Reservas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Reservas_ReservasId",
                table: "Usuarios",
                column: "ReservasId",
                principalTable: "Reservas",
                principalColumn: "Id");
        }
    }
}
