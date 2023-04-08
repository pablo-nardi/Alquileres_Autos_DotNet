﻿// <auto-generated />
using System;
using AlquileresAutos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AlquileresAutos.Migrations
{
    [DbContext(typeof(AlquileresAutosContext))]
    [Migration("20230408004420_ArmadoAbmComplejo2")]
    partial class ArmadoAbmComplejo2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AlquileresAutos.Models.Auto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<float>("CapacidadTanque")
                        .HasColumnType("real");

                    b.Property<string>("Detalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<float>("Kilometraje")
                        .HasColumnType("real");

                    b.Property<int?>("ModeloID")
                        .HasColumnType("int");

                    b.Property<string>("Patente")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ModeloID");

                    b.ToTable("Auto", (string)null);
                });

            modelBuilder.Entity("AlquileresAutos.Models.Modelo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("AireAcondicionado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CantEquipajeChico")
                        .HasColumnType("int");

                    b.Property<int>("CantEquipajeGrande")
                        .HasColumnType("int");

                    b.Property<int>("CantPasajeros")
                        .HasColumnType("int");

                    b.Property<string>("Denominacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PrecioPorDia")
                        .HasColumnType("real");

                    b.Property<int?>("TipoAutoID")
                        .HasColumnType("int");

                    b.Property<string>("Transmision")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("TipoAutoID");

                    b.ToTable("Modelo", (string)null);
                });

            modelBuilder.Entity("AlquileresAutos.Models.TipoAuto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("NombreTipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TipoAuto", (string)null);
                });

            modelBuilder.Entity("AlquileresAutos.Models.Auto", b =>
                {
                    b.HasOne("AlquileresAutos.Models.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloID");

                    b.Navigation("Modelo");
                });

            modelBuilder.Entity("AlquileresAutos.Models.Modelo", b =>
                {
                    b.HasOne("AlquileresAutos.Models.TipoAuto", "tipoAuto")
                        .WithMany()
                        .HasForeignKey("TipoAutoID");

                    b.Navigation("tipoAuto");
                });
#pragma warning restore 612, 618
        }
    }
}