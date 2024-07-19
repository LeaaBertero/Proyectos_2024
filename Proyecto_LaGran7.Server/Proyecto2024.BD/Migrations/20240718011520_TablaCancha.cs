using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoLaGran7.BD.Migrations
{
    /// <inheritdoc />
    public partial class TablaCancha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Canchas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCancha = table.Column<int>(type: "int", nullable: false),
                    IdPago = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canchas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdReserva = table.Column<int>(type: "int", nullable: true),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    IdCancha = table.Column<int>(type: "int", nullable: true),
                    fechaReserva = table.Column<DateTime>(type: "datetime2", maxLength: 150, nullable: false),
                    HoraInicio = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    HoraFin = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPago = table.Column<int>(type: "int", nullable: false),
                    IdCancha = table.Column<int>(type: "int", nullable: false),
                    ReservasID = table.Column<int>(type: "int", nullable: true),
                    IdReserva = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    FechaPago = table.Column<DateTime>(type: "datetime2", maxLength: 30, nullable: false),
                    metodoPago = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pagos_Canchas_IdCancha",
                        column: x => x.IdCancha,
                        principalTable: "Canchas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagos_Reservas_ReservasID",
                        column: x => x.ReservasID,
                        principalTable: "Reservas",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    Rol = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    PagoID = table.Column<int>(type: "int", nullable: true),
                    IdPago = table.Column<int>(type: "int", nullable: false),
                    ReservaID = table.Column<int>(type: "int", nullable: true),
                    IdReserva = table.Column<int>(type: "int", nullable: false),
                    IdCancha = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Usuarios_Pagos_PagoID",
                        column: x => x.PagoID,
                        principalTable: "Pagos",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Usuarios_Reservas_ReservaID",
                        column: x => x.ReservaID,
                        principalTable: "Reservas",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "Cancha_UQ",
                table: "Canchas",
                column: "IdCancha",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Nombre_Ubicación_Estado",
                table: "Canchas",
                columns: new[] { "Nombre", "Ubicacion", "Estado" });

            migrationBuilder.CreateIndex(
                name: "IdPago_UQ",
                table: "Pagos",
                column: "IdPago",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdCancha",
                table: "Pagos",
                column: "IdCancha",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_ReservasID",
                table: "Pagos",
                column: "ReservasID");

            migrationBuilder.CreateIndex(
                name: "Monto_FechaPago_MétodoPago",
                table: "Pagos",
                columns: new[] { "Monto", "FechaPago", "metodoPago" });

            migrationBuilder.CreateIndex(
                name: "fechaReserva_HoraInicio_HoraFin_Estado",
                table: "Reservas",
                columns: new[] { "fechaReserva", "HoraInicio", "HoraFin", "Estado" });

            migrationBuilder.CreateIndex(
                name: "ReservaId_UQ",
                table: "Reservas",
                column: "IdReserva",
                unique: true,
                filter: "[IdReserva] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PagoID",
                table: "Usuarios",
                column: "PagoID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ReservaID",
                table: "Usuarios",
                column: "ReservaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Canchas");

            migrationBuilder.DropTable(
                name: "Reservas");
        }
    }
}
