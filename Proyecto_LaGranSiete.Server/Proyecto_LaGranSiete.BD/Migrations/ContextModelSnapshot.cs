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
                        .HasColumnType("bit");

                    b.Property<int>("IdCanchas")
                        .HasColumnType("int");

                    b.Property<string>("NombreCancha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

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
                        .HasColumnType("int");

                    b.Property<string>("NombreEquipos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartidosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PartidosId");

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
                        .HasColumnType("date");

                    b.Property<int>("IdPago")
                        .HasColumnType("int");

                    b.Property<int>("IdReserva")
                        .HasColumnType("int");

                    b.Property<float?>("Monto_Pago")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CanchasId");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parentesco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReservaId")
                        .HasColumnType("int");

                    b.Property<int?>("ReservasId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReservasId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Equipos", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Partidos", "Partidos")
                        .WithMany()
                        .HasForeignKey("PartidosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Partidos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Pagos", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Canchas", "Canchas")
                        .WithMany()
                        .HasForeignKey("CanchasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Canchas");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Partidos", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Canchas", "Canchas")
                        .WithMany()
                        .HasForeignKey("CanchasId")
                        .OnDelete(DeleteBehavior.Cascade)
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
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pagos");

                    b.Navigation("Partidos");
                });

            modelBuilder.Entity("Proyecto_LaGranSiete.BD.Data.Entity.Usuarios", b =>
                {
                    b.HasOne("Proyecto_LaGranSiete.BD.Data.Entity.Reservas", "Reservas")
                        .WithMany()
                        .HasForeignKey("ReservasId");

                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
