﻿// <auto-generated />
using System;
using AlquileresAutos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AlquileresAutos.Migrations
{
    [DbContext(typeof(AlquileresAutosContext))]
    partial class AlquileresAutosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Patente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("capacidadTanque")
                        .HasColumnType("real");

                    b.Property<string>("detalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<float>("kilometraje")
                        .HasColumnType("real");

                    b.Property<int?>("modeloID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("modeloID");

                    b.ToTable("Auto", (string)null);
                });

            modelBuilder.Entity("AlquileresAutos.Models.Modelo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("aireAcondicionado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cantEquipajeChico")
                        .HasColumnType("int");

                    b.Property<int>("cantEquipajeGrande")
                        .HasColumnType("int");

                    b.Property<int>("cantPasajeros")
                        .HasColumnType("int");

                    b.Property<string>("denominacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("precioPorDia")
                        .HasColumnType("real");

                    b.Property<string>("transmision")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Modelo", (string)null);
                });

            modelBuilder.Entity("AlquileresAutos.Models.TipoAuto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("nombreTipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TipoAuto", (string)null);
                });

            modelBuilder.Entity("AlquileresAutos.Models.Auto", b =>
                {
                    b.HasOne("AlquileresAutos.Models.Modelo", "modelo")
                        .WithMany()
                        .HasForeignKey("modeloID");

                    b.Navigation("modelo");
                });
#pragma warning restore 612, 618
        }
    }
}
