﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto2024.BD.Data;

#nullable disable

namespace ProyectoLaGran7.BD.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240710190938_ActualizoTablaPagos")]
    partial class ActualizoTablaPagos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Cancha", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IdCancha")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<int>("IdPago")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("IdReserva")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("PagoID")
                        .HasColumnType("int");

                    b.Property<string>("Ubicaciòn")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.HasIndex("PagoID");

                    b.HasIndex(new[] { "IdCancha" }, "Cancha_UQ")
                        .IsUnique();

                    b.HasIndex(new[] { "Nombre", "Ubicaciòn", "Estado" }, "Nombre_Ubicación_Estado");

                    b.ToTable("Cancha");
                });

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Pago", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("FechaPago")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("datetime2");

                    b.Property<int>("IdPago")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<int>("IdReserva")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<int>("Monto")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.Property<int?>("PagoID")
                        .HasColumnType("int");

                    b.Property<string>("metodoPago")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.HasIndex("PagoID");

                    b.HasIndex(new[] { "IdPago" }, "IdPago_UQ")
                        .IsUnique();

                    b.HasIndex(new[] { "Monto", "FechaPago", "metodoPago" }, "Monto_FechaPago_MétodoPago");

                    b.ToTable("Pago");
                });

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Reserva", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("HoraFin")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HoraInicio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdCancha")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<int?>("IdReserva")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("int");

                    b.Property<DateTime?>("fechaReserva")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex(new[] { "IdReserva" }, "ReservaId_UQ")
                        .IsUnique();

                    b.HasIndex(new[] { "fechaReserva", "HoraInicio", "HoraFin", "Estado" }, "fechaReserva_HoraInicio_HoraFin_Estado");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Usuarios", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("nvarchar(180)");

                    b.Property<int>("IdPago")
                        .HasColumnType("int");

                    b.Property<int>("IdReserva")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("PagoID")
                        .HasColumnType("int");

                    b.Property<int?>("ReservaID")
                        .HasColumnType("int");

                    b.Property<int?>("Rol")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PagoID");

                    b.HasIndex("ReservaID");

                    b.HasIndex(new[] { "Nombre", "Mail", "Contraseña", "Rol" }, "Persona_Nombre_Mail_Rol");

                    b.HasIndex(new[] { "IdUsuario" }, "UsuarioId_UQ")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Cancha", b =>
                {
                    b.HasOne("ProyectoLaGran7.BD.Data.Entity.Pago", "Pago")
                        .WithMany()
                        .HasForeignKey("PagoID");

                    b.Navigation("Pago");
                });

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Pago", b =>
                {
                    b.HasOne("ProyectoLaGran7.BD.Data.Entity.Pago", null)
                        .WithMany("FechaPagoList")
                        .HasForeignKey("PagoID");
                });

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Usuarios", b =>
                {
                    b.HasOne("ProyectoLaGran7.BD.Data.Entity.Pago", "Pago")
                        .WithMany()
                        .HasForeignKey("PagoID");

                    b.HasOne("ProyectoLaGran7.BD.Data.Entity.Reserva", "Reserva")
                        .WithMany("Usuarios")
                        .HasForeignKey("ReservaID");

                    b.Navigation("Pago");

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Pago", b =>
                {
                    b.Navigation("FechaPagoList");
                });

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Reserva", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
