﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto2024.BD.Migrations
{
    /// <inheritdoc />
    public partial class TablasFinales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TDocumentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Titulo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titulo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumDoc = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    TDocumentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_TDocumentos_TDocumentoId",
                        column: x => x.TDocumentoId,
                        principalTable: "TDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Profesiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    TituloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesiones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profesiones_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Profesiones_Titulo_TituloId",
                        column: x => x.TituloId,
                        principalTable: "Titulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "Persona_Apellido_Nombre",
                table: "Personas",
                columns: new[] { "Apellido", "Nombre" });

            migrationBuilder.CreateIndex(
                name: "Persona_UQ",
                table: "Personas",
                columns: new[] { "TDocumentoId", "NumDoc" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profesiones_PersonaId",
                table: "Profesiones",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Profesiones_TituloId",
                table: "Profesiones",
                column: "TituloId");

            migrationBuilder.CreateIndex(
                name: "TDocumento_UQ",
                table: "TDocumentos",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Titulo_UQ",
                table: "Titulo",
                column: "Codigo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profesiones");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Titulo");

            migrationBuilder.DropTable(
                name: "TDocumentos");
        }
    }
}