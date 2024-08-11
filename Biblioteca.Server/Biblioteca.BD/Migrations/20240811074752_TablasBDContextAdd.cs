using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.BD.Migrations
{
    /// <inheritdoc />
    public partial class TablasBDContextAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Columnas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    columnaNumero = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Columnas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estanterias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estanterias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneroNombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Localidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreLocalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Localidad_CP = table.Column<int>(type: "int", nullable: true),
                    ProvinciaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ubicacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UbicacionNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEstanteria = table.Column<int>(type: "int", nullable: false),
                    EstanteriaId = table.Column<int>(type: "int", nullable: true),
                    ColumnasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ubicacion_Columnas_ColumnasId",
                        column: x => x.ColumnasId,
                        principalTable: "Columnas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ubicacion_Estanterias_EstanteriaId",
                        column: x => x.EstanteriaId,
                        principalTable: "Estanterias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Biblioteca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domicilio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdLocalidad = table.Column<int>(type: "int", nullable: false),
                    LocalidadesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biblioteca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Biblioteca_Localidades_LocalidadesId",
                        column: x => x.LocalidadesId,
                        principalTable: "Localidades",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinciaNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalidadesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provincias_Localidades_LocalidadesId",
                        column: x => x.LocalidadesId,
                        principalTable: "Localidades",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Filas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilaNumero = table.Column<int>(type: "int", nullable: false),
                    UbicacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filas_Ubicacion_UbicacionId",
                        column: x => x.UbicacionId,
                        principalTable: "Ubicacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Paginas = table.Column<int>(type: "int", nullable: false),
                    AnioPublicacion = table.Column<int>(type: "int", nullable: false),
                    IdBiblioteca = table.Column<int>(type: "int", nullable: false),
                    IdAutor = table.Column<int>(type: "int", nullable: false),
                    IdGenero = table.Column<int>(type: "int", nullable: false),
                    IdEditorial = table.Column<int>(type: "int", nullable: false),
                    IdUbicacion = table.Column<int>(type: "int", nullable: false),
                    LibroId = table.Column<int>(type: "int", nullable: true),
                    UbicacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Libros_Libros_LibroId",
                        column: x => x.LibroId,
                        principalTable: "Libros",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Libros_Ubicacion_UbicacionId",
                        column: x => x.UbicacionId,
                        principalTable: "Ubicacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LibrosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Autores_Libros_LibrosId",
                        column: x => x.LibrosId,
                        principalTable: "Libros",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEditorial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail_Editorial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono_Editorial = table.Column<int>(type: "int", nullable: true),
                    Domicilio_Editorial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalidadId = table.Column<int>(type: "int", nullable: false),
                    LibroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Libros_LibroId",
                        column: x => x.LibroId,
                        principalTable: "Libros",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autores_LibrosId",
                table: "Autores",
                column: "LibrosId");

            migrationBuilder.CreateIndex(
                name: "IX_Biblioteca_LocalidadesId",
                table: "Biblioteca",
                column: "LocalidadesId");

            migrationBuilder.CreateIndex(
                name: "IX_Filas_UbicacionId",
                table: "Filas",
                column: "UbicacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_LibroId",
                table: "Libros",
                column: "LibroId");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_UbicacionId",
                table: "Libros",
                column: "UbicacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_LocalidadesId",
                table: "Provincias",
                column: "LocalidadesId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicacion_ColumnasId",
                table: "Ubicacion",
                column: "ColumnasId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicacion_EstanteriaId",
                table: "Ubicacion",
                column: "EstanteriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_LibroId",
                table: "Usuarios",
                column: "LibroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Biblioteca");

            migrationBuilder.DropTable(
                name: "Filas");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Localidades");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Ubicacion");

            migrationBuilder.DropTable(
                name: "Columnas");

            migrationBuilder.DropTable(
                name: "Estanterias");
        }
    }
}
