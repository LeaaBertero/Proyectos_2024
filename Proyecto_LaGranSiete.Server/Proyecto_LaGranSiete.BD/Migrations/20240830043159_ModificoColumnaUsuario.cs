using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class ModificoColumnaUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_EquipoDos_EquipoDosId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_EquipoUno_EquipoUnoId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Reservas_ReservaId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_EquipoDosId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_EquipoUnoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_ReservaId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EquipoDosId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EquipoUnoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ReservaId",
                table: "Usuarios");

            migrationBuilder.AlterColumn<decimal>(
                name: "Monto",
                table: "Reservas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.CreateIndex(
                name: "UsuarioId_UQ",
                table: "Usuarios",
                columns: new[] { "Nombre", "Apellido", "UsuarioId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_UsuarioId",
                table: "Reservas",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Usuarios_UsuarioId",
                table: "Reservas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Usuarios_UsuarioId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "UsuarioId_UQ",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_UsuarioId",
                table: "Reservas");

            migrationBuilder.AddColumn<int>(
                name: "EquipoDosId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EquipoUnoId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservaId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Monto",
                table: "Reservas",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EquipoDosId",
                table: "Usuarios",
                column: "EquipoDosId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EquipoUnoId",
                table: "Usuarios",
                column: "EquipoUnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ReservaId",
                table: "Usuarios",
                column: "ReservaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_EquipoDos_EquipoDosId",
                table: "Usuarios",
                column: "EquipoDosId",
                principalTable: "EquipoDos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_EquipoUno_EquipoUnoId",
                table: "Usuarios",
                column: "EquipoUnoId",
                principalTable: "EquipoUno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Reservas_ReservaId",
                table: "Usuarios",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
