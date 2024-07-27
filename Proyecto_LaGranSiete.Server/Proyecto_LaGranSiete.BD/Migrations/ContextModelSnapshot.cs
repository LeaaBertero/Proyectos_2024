﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_LaGranSiete.BD.Data;

#nullable disable

namespace Proyecto_LaGranSiete.BD.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Canchas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Disponibilidad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("bit");

                    b.Property<int>("IdCanchas")
                        .HasColumnType("int");

                    b.Property<string>("NombreCancha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IdCanchas" }, "IdCanchas")
                        .IsUnique();

                    b.HasIndex(new[] { "NombreCancha", "Disponibilidad" }, "NombreCancha_Disponibilidad");

                    b.ToTable("Canchas");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Equipos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdEquipos")
                        .HasColumnType("int");

                    b.Property<int>("Integrantes")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("NombreEquipos")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("PartidosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PartidosId");

                    b.HasIndex(new[] { "IdEquipos" }, "IdEquipos")
                        .IsUnique();

                    b.HasIndex(new[] { "NombreEquipos", "Integrantes" }, "NombreEquipos_Integrantes");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Pagos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CanchasId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaPago")
                        .HasMaxLength(30)
                        .HasColumnType("date");

                    b.Property<int>("IdPago")
                        .HasColumnType("int");

                    b.Property<int>("IdReserva")
                        .HasColumnType("int");

                    b.Property<float?>("Monto_Pago")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CanchasId");

                    b.HasIndex(new[] { "IdPago" }, "IdPago")
                        .IsUnique();

                    b.HasIndex(new[] { "Monto_Pago", "FechaPago" }, "Monto_Pago_FechaPago");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Partidos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CanchasId")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("FechaHoraPartidos")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("date");

                    b.Property<int>("IdEquipoDos")
                        .HasColumnType("int");

                    b.Property<int>("IdEquipoUno")
                        .HasColumnType("int");

                    b.Property<int>("IdPartidos")
                        .HasColumnType("int");

                    b.Property<int>("IdReserva")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CanchasId");

                    b.HasIndex(new[] { "FechaHoraPartidos" }, "FechaHoraPartidos");

                    b.HasIndex(new[] { "IdPartidos" }, "IdPartidos")
                        .IsUnique();

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Reservas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DuracionAlquiler")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("EstadoReserva")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateOnly>("FechaHoraReserva")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<int>("IdReserva")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("MetodoPago")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<float>("Monto")
                        .HasMaxLength(12)
                        .HasColumnType("real");

                    b.Property<int>("PagoId")
                        .HasColumnType("int");

                    b.Property<int?>("PagosId")
                        .HasColumnType("int");

                    b.Property<int>("PartidosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PagosId");

                    b.HasIndex("PartidosId");

                    b.HasIndex(new[] { "IdReserva" }, "ReservaId_UQ")
                        .IsUnique();

                    b.HasIndex(new[] { "FechaHoraReserva", "DuracionAlquiler", "Monto", "MetodoPago", "EstadoReserva" }, "Reserva_FechaHoraReserva_DuracionAlquiler_Monto_MetodoPago_EstadoReserva");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Usuarios", b =>
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

                    b.Property<DateOnly?>("FechaNacimiento")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("date");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Parentesco")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ReservaId")
                        .HasColumnType("int");

                    b.Property<int?>("ReservasId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("ReservasId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Equipos", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Partidos", "Partidos")
                        .WithMany()
                        .HasForeignKey("PartidosId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Partidos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Pagos", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Canchas", "Canchas")
                        .WithMany()
                        .HasForeignKey("CanchasId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Canchas");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Partidos", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Canchas", "Canchas")
                        .WithMany()
                        .HasForeignKey("CanchasId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Canchas");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Reservas", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Pagos", "Pagos")
                        .WithMany()
                        .HasForeignKey("PagosId");

                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Partidos", "Partidos")
                        .WithMany()
                        .HasForeignKey("PartidosId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pagos");

                    b.Navigation("Partidos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Usuarios", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Reservas", "Reservas")
                        .WithMany("Usuarios")
                        .HasForeignKey("ReservasId");

                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Reservas", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
