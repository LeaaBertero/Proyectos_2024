using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class ActualizoTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioID",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservaID",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioID",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EquipoDosID",
                table: "Partidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EquipoUnoID",
                table: "Partidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartidoID",
                table: "Partidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservaID",
                table: "Partidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagoID",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservaID",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EquipoUnoID",
                table: "EquipoUno",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservaID",
                table: "EquipoUno",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioID",
                table: "EquipoUno",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EquipoID",
                table: "Equipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EquipoDosID",
                table: "EquipoDos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservaID",
                table: "EquipoDos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CanchaID",
                table: "Canchas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ReservaID",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "EquipoDosID",
                table: "Partidos");

            migrationBuilder.DropColumn(
                name: "EquipoUnoID",
                table: "Partidos");

            migrationBuilder.DropColumn(
                name: "PartidoID",
                table: "Partidos");

            migrationBuilder.DropColumn(
                name: "ReservaID",
                table: "Partidos");

            migrationBuilder.DropColumn(
                name: "PagoID",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "ReservaID",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "EquipoUnoID",
                table: "EquipoUno");

            migrationBuilder.DropColumn(
                name: "ReservaID",
                table: "EquipoUno");

            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "EquipoUno");

            migrationBuilder.DropColumn(
                name: "EquipoID",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "EquipoDosID",
                table: "EquipoDos");

            migrationBuilder.DropColumn(
                name: "ReservaID",
                table: "EquipoDos");

            migrationBuilder.DropColumn(
                name: "CanchaID",
                table: "Canchas");
        }
    }
}
