﻿// <auto-generated />
using System;
using GranSiete.BD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GranSiete.BD.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240828034251_Indices")]
    partial class Indices
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GranSiete.BD.Data.Entity.Cancha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CanchaID")
                        .HasColumnType("int");

                    b.Property<string>("Disponibilidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCancha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Canchas");
                });

            modelBuilder.Entity("GranSiete.BD.Data.Entity.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipoID")
                        .HasColumnType("int");

                    b.Property<string>("Integrantes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEquipos")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("GranSiete.BD.Data.Entity.EquipoDos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipoDosID")
                        .HasColumnType("int");

                    b.Property<string>("NombreEquipoDos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReservaID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EquipoDos");
                });

            modelBuilder.Entity("GranSiete.BD.Data.Entity.EquipoUno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipoUnoID")
                        .HasColumnType("int");

                    b.Property<string>("NombreEquipoUno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReservaID")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EquipoUno");
                });

            modelBuilder.Entity("GranSiete.BD.Data.Entity.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("FechaPagado")
                        .HasColumnType("datetime2");

                    b.Property<string>("MetodoPagado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MontoPagado")
                        .HasColumnType("int");

                    b.Property<int>("PagoID")
                        .HasColumnType("int");

                    b.Property<int>("ReservaID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("GranSiete.BD.Data.Entity.Partido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipoDosID")
                        .HasColumnType("int");

                    b.Property<int>("EquipoUnoID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaHoraPartidos")
                        .HasColumnType("datetime2");

                    b.Property<int>("PartidoID")
                        .HasColumnType("int");

                    b.Property<int>("ReservaID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("GranSiete.BD.Data.Entity.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DuracionAlquiler")
                        .HasColumnType("datetime2");

                    b.Property<string>("EstadoReserva")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("FechaHoraReserva")
                        .HasColumnType("datetime2");

                    b.Property<string>("MetodoPago")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Monto")
                        .HasColumnType("int");

                    b.Property<int>("ReservaID")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Monto", "MetodoPago", "EstadoReserva" }, "Reserva_Monto_MetodoPago_EstadoReserva");

                    b.HasIndex(new[] { "UsuarioID", "EstadoReserva" }, "Reserva_UQ")
                        .IsUnique()
                        .HasFilter("[EstadoReserva] IS NOT NULL");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("GranSiete.BD.Data.Entity.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parentesco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("GranSiete.BD.Data.Entity.Reserva", b =>
                {
                    b.HasOne("GranSiete.BD.Data.Entity.Usuario", "Usuarios")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
