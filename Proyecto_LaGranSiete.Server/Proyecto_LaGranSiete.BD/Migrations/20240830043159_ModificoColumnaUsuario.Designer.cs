﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_LaGranSiete.BD.Data;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240830043159_ModificoColumnaUsuario")]
    partial class ModificoColumnaUsuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Cancha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CanchasId")
                        .HasColumnType("int");

                    b.Property<int?>("Disponibilidad")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("NombreCancha")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ReservaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReservaId");

                    b.HasIndex(new[] { "CanchasId" }, "CanchasId")
                        .IsUnique();

                    b.HasIndex(new[] { "NombreCancha", "Disponibilidad" }, "NombreCancha_Disponibilidad");

                    b.ToTable("Canchas");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int>("Integrantes")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<string>("NombreEquipos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "EquipoId" }, "EquipoId")
                        .IsUnique();

                    b.HasIndex(new[] { "NombreEquipos", "Integrantes" }, "NombreEquipos_Integrantes");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.EquipoDos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipoDosId")
                        .HasColumnType("int");

                    b.Property<string>("NombreEquipoDos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PartidoId")
                        .HasColumnType("int");

                    b.Property<int>("ReservaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PartidoId");

                    b.HasIndex("ReservaId");

                    b.HasIndex(new[] { "EquipoDosId" }, "EquipoDosId")
                        .IsUnique();

                    b.HasIndex(new[] { "NombreEquipoDos" }, "NombreEquipoDos");

                    b.ToTable("EquipoDos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.EquipoUno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipoUnoId")
                        .HasColumnType("int");

                    b.Property<string>("NombreEquipoUno")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PartidoId")
                        .HasColumnType("int");

                    b.Property<int>("ReservaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PartidoId");

                    b.HasIndex("ReservaId");

                    b.HasIndex(new[] { "EquipoUnoId" }, "EquipoUnoId")
                        .IsUnique();

                    b.HasIndex(new[] { "NombreEquipoUno" }, "NombreEquipoUno");

                    b.ToTable("EquipoUno");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CanchaId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoDosId")
                        .HasColumnType("int");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoUnoId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaPago")
                        .HasColumnType("date");

                    b.Property<string>("MetodoPagado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Monto")
                        .HasColumnType("int");

                    b.Property<double?>("Monto_Pago")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("float");

                    b.Property<int>("PagoId")
                        .HasColumnType("int");

                    b.Property<int>("PartidoId")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("fechaHora")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("CanchaId");

                    b.HasIndex("EquipoDosId");

                    b.HasIndex("EquipoId");

                    b.HasIndex("EquipoUnoId");

                    b.HasIndex("PartidoId");

                    b.HasIndex(new[] { "Monto_Pago", "FechaPago" }, "Monto_Pago_FechaPago");

                    b.HasIndex(new[] { "PagoId" }, "PagoId")
                        .IsUnique();

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Partido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CanchaId")
                        .HasColumnType("int");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<TimeOnly?>("FechaHoraPartidos")
                        .IsRequired()
                        .HasColumnType("time");

                    b.Property<int>("PartidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CanchaId");

                    b.HasIndex("EquipoId");

                    b.HasIndex(new[] { "FechaHoraPartidos" }, "FechaHoraPartidos");

                    b.HasIndex(new[] { "PartidoId" }, "PartidosId")
                        .IsUnique();

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DuracionAlquiler")
                        .HasColumnType("int");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("EstadoReserva")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHoraReserva")
                        .HasColumnType("datetime2");

                    b.Property<string>("MetodoPago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PagoId")
                        .HasColumnType("int");

                    b.Property<int>("PartidoId")
                        .HasColumnType("int");

                    b.Property<int>("ReservaId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.HasIndex("PagoId");

                    b.HasIndex("PartidoId");

                    b.HasIndex("ReservaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Parentesco")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Telefono")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Nombre", "Apellido", "UsuarioId" }, "UsuarioId_UQ")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Cancha", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.EquipoDos", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Partido", "Partidos")
                        .WithMany()
                        .HasForeignKey("PartidoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Partidos");

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.EquipoUno", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Partido", "Partidos")
                        .WithMany()
                        .HasForeignKey("PartidoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Partidos");

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Pago", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Cancha", "Canchas")
                        .WithMany()
                        .HasForeignKey("CanchaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.EquipoDos", null)
                        .WithMany("Pagos")
                        .HasForeignKey("EquipoDosId");

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Equipo", "Equipos")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.EquipoUno", null)
                        .WithMany("Pagos")
                        .HasForeignKey("EquipoUnoId");

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Partido", "Partidos")
                        .WithMany()
                        .HasForeignKey("PartidoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Canchas");

                    b.Navigation("Equipos");

                    b.Navigation("Partidos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Partido", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Cancha", "Canchas")
                        .WithMany()
                        .HasForeignKey("CanchaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Equipo", "Equipos")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Canchas");

                    b.Navigation("Equipos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Reserva", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Equipo", "Equipos")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Pago", "Pagos")
                        .WithMany()
                        .HasForeignKey("PagoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Partido", "Partidos")
                        .WithMany()
                        .HasForeignKey("PartidoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Reserva", null)
                        .WithMany("Reservas")
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Usuario", "Usuarios")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Equipos");

                    b.Navigation("Pagos");

                    b.Navigation("Partidos");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.EquipoDos", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.EquipoUno", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Reserva", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
