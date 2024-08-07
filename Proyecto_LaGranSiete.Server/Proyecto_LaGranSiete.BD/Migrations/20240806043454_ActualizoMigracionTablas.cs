﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class ActualizoMigracionTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaHoraPartidos",
                table: "Partidos",
                type: "datetime2",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldMaxLength: 30);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "FechaHoraPartidos",
                table: "Partidos",
                type: "date",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 30);
        }
    }
}
