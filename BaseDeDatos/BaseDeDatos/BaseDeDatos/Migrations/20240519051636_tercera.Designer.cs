﻿// <auto-generated />
using System;
using BaseDeDatos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaseDeDatos.Migrations
{
    [DbContext(typeof(TiendaDBContext))]
    [Migration("20240519051636_tercera")]
    partial class tercera
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BaseDeDatos.Data.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TicketId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TicketId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("BaseDeDatos.Data.Sucursal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Sucursales");
                });

            modelBuilder.Entity("BaseDeDatos.Data.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("SucursalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SucursalId");

                    b.ToTable("Ticketes");
                });

            modelBuilder.Entity("BaseDeDatos.Data.Producto", b =>
                {
                    b.HasOne("BaseDeDatos.Data.Ticket", null)
                        .WithMany("Productos")
                        .HasForeignKey("TicketId");
                });

            modelBuilder.Entity("BaseDeDatos.Data.Ticket", b =>
                {
                    b.HasOne("BaseDeDatos.Data.Sucursal", "Sucursal")
                        .WithMany()
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("BaseDeDatos.Data.Ticket", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}