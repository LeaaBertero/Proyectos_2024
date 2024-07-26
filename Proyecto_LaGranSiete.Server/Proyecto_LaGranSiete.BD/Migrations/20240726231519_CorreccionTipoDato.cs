using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionTipoDato : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Monto",
                table: "Reservas",
                type: "real",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<float>(
                name: "Monto_Pago",
                table: "Pagos",
                type: "real",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Monto",
                table: "Reservas",
                type: "decimal(18,2)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<decimal>(
                name: "Monto_Pago",
                table: "Pagos",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);
        }
    }
}
