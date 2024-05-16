﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto2024.BD.Migrations
{
    /// <inheritdoc />
    public partial class Inicio2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TDocumento",
                table: "TDocumento");

            migrationBuilder.RenameTable(
                name: "TDocumento",
                newName: "TDocumentos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TDocumentos",
                table: "TDocumentos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumDoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_TDocumentoId",
                table: "Personas",
                column: "TDocumentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TDocumentos",
                table: "TDocumentos");

            migrationBuilder.RenameTable(
                name: "TDocumentos",
                newName: "TDocumento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TDocumento",
                table: "TDocumento",
                column: "Id");
        }
    }
}
