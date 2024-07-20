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
    [Migration("20240720054457_ActualizoListas")]
    partial class ActualizoListas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
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
                        .HasColumnType("int");

                    b.Property<int>("IdPago")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("ReservaId")
                        .HasColumnType("int");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.HasIndex("ReservaId");

                    b.HasIndex(new[] { "IdCancha" }, "Cancha_UQ")
                        .IsUnique();

                    b.HasIndex(new[] { "Nombre", "Ubicacion", "Estado" }, "Nombre_Ubicación_Estado");

                    b.ToTable("Canchas");
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

                    b.Property<int>("IdCancha")
                        .HasColumnType("int");

                    b.Property<int>("IdPago")
                        .HasColumnType("int");

                    b.Property<int>("IdReserva")
                        .HasColumnType("int");

                    b.Property<int>("Monto")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.Property<string>("metodoPago")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.HasIndex("IdCancha")
                        .IsUnique();

                    b.HasIndex(new[] { "IdPago" }, "IdPago_UQ")
                        .IsUnique();

                    b.HasIndex(new[] { "Monto", "FechaPago", "metodoPago" }, "Monto_FechaPago_MétodoPago");

                    b.ToTable("Pagos");
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
                        .HasColumnType("int");

                    b.Property<int?>("IdReserva")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("fechaReserva")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioID");

                    b.HasIndex(new[] { "IdReserva" }, "ReservaId_UQ")
                        .IsUnique()
                        .HasFilter("[IdReserva] IS NOT NULL");

                    b.HasIndex(new[] { "fechaReserva", "HoraInicio", "HoraFin", "Estado" }, "fechaReserva_HoraInicio_HoraFin_Estado");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Usuario", b =>
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
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
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

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Cancha", b =>
                {
                    b.HasOne("ProyectoLaGran7.BD.Data.Entity.Reserva", "Reservas")
                        .WithMany()
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Pago", b =>
                {
                    b.HasOne("ProyectoLaGran7.BD.Data.Entity.Cancha", "Cancha")
                        .WithOne("Pagos")
                        .HasForeignKey("ProyectoLaGran7.BD.Data.Entity.Pago", "IdCancha")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cancha");
                });

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Reserva", b =>
                {
                    b.HasOne("ProyectoLaGran7.BD.Data.Entity.Usuario", null)
                        .WithMany("Reservas")
                        .HasForeignKey("UsuarioID");
                });

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Usuario", b =>
                {
                    b.HasOne("ProyectoLaGran7.BD.Data.Entity.Pago", "Pago")
                        .WithMany("Usuarios")
                        .HasForeignKey("PagoID");

                    b.HasOne("ProyectoLaGran7.BD.Data.Entity.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaID");

                    b.Navigation("Pago");

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Cancha", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Pago", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("ProyectoLaGran7.BD.Data.Entity.Usuario", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
