﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class ModificoRelaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipoDos_Reservas_ReservaID",
                table: "EquipoDos");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipoDos_Usuarios_UsuarioID",
                table: "EquipoDos");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipoUno_Reservas_ReservaID",
                table: "EquipoUno");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipoUno_Usuarios_UsuarioID",
                table: "EquipoUno");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Reservas_ReservaID",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_EquipoDos_EquipoDosID",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_EquipoUno_EquipoUnoID",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Reservas_ReservaID",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Usuarios_UsuarioID",
                table: "Reservas");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipoDos_Reservas_ReservaID",
                table: "EquipoDos",
                column: "ReservaID",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipoDos_Usuarios_UsuarioID",
                table: "EquipoDos",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipoUno_Reservas_ReservaID",
                table: "EquipoUno",
                column: "ReservaID",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipoUno_Usuarios_UsuarioID",
                table: "EquipoUno",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Reservas_ReservaID",
                table: "Pagos",
                column: "ReservaID",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_EquipoDos_EquipoDosID",
                table: "Partidos",
                column: "EquipoDosID",
                principalTable: "EquipoDos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_EquipoUno_EquipoUnoID",
                table: "Partidos",
                column: "EquipoUnoID",
                principalTable: "EquipoUno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Reservas_ReservaID",
                table: "Partidos",
                column: "ReservaID",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Usuarios_UsuarioID",
                table: "Reservas",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipoDos_Reservas_ReservaID",
                table: "EquipoDos");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipoDos_Usuarios_UsuarioID",
                table: "EquipoDos");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipoUno_Reservas_ReservaID",
                table: "EquipoUno");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipoUno_Usuarios_UsuarioID",
                table: "EquipoUno");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Reservas_ReservaID",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_EquipoDos_EquipoDosID",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_EquipoUno_EquipoUnoID",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Reservas_ReservaID",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Usuarios_UsuarioID",
                table: "Reservas");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipoDos_Reservas_ReservaID",
                table: "EquipoDos",
                column: "ReservaID",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipoDos_Usuarios_UsuarioID",
                table: "EquipoDos",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipoUno_Reservas_ReservaID",
                table: "EquipoUno",
                column: "ReservaID",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipoUno_Usuarios_UsuarioID",
                table: "EquipoUno",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Reservas_ReservaID",
                table: "Pagos",
                column: "ReservaID",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_EquipoDos_EquipoDosID",
                table: "Partidos",
                column: "EquipoDosID",
                principalTable: "EquipoDos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_EquipoUno_EquipoUnoID",
                table: "Partidos",
                column: "EquipoUnoID",
                principalTable: "EquipoUno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Reservas_ReservaID",
                table: "Partidos",
                column: "ReservaID",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Usuarios_UsuarioID",
                table: "Reservas",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
