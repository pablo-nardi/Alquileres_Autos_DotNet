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
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AlquileresAutos.Models.Alquiler", b =>
                {
                    b.Property<int>("AlquilerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlquilerID"));

                    b.Property<int?>("AutoID")
                        .HasColumnType("int");

                    b.Property<float>("CostoPorDaños")
                        .HasColumnType("real");

                    b.Property<float>("CostoPorDevolucionTardia")
                        .HasColumnType("real");

                    b.Property<int?>("EntidadCrediticiaID")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHoraDevolucionPrevista")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaHoraDevolucionReal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaHoraRetiroPrevista")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaHoraRetiroReal")
                        .HasColumnType("datetime2");

                    b.Property<int>("IDAuto")
                        .HasColumnType("int");

                    b.Property<int>("IDEntidadCrediticia")
                        .HasColumnType("int");

                    b.Property<int>("IDMedioDePago")
                        .HasColumnType("int");

                    b.Property<int>("IDModelo")
                        .HasColumnType("int");

                    b.Property<int>("IDPlanDePago")
                        .HasColumnType("int");

                    b.Property<int>("IDSucursal")
                        .HasColumnType("int");

                    b.Property<int>("IDTipoAuto")
                        .HasColumnType("int");

                    b.Property<float>("ImporteAcordadoConCliente")
                        .HasColumnType("real");

                    b.Property<int?>("MedioDePagoID")
                        .HasColumnType("int");

                    b.Property<int?>("ModeloID")
                        .HasColumnType("int");

                    b.Property<int?>("PlanDePagoID")
                        .HasColumnType("int");

                    b.Property<float>("PrecioDiario")
                        .HasColumnType("real");

                    b.Property<int?>("SucursalID")
                        .HasColumnType("int");

                    b.Property<int?>("TipoAutoID")
                        .HasColumnType("int");

                    b.HasKey("AlquilerID");

                    b.HasIndex("AutoID");

                    b.HasIndex("EntidadCrediticiaID");

                    b.HasIndex("MedioDePagoID");

                    b.HasIndex("ModeloID");

                    b.HasIndex("PlanDePagoID");

                    b.HasIndex("SucursalID");

                    b.HasIndex("TipoAutoID");

                    b.ToTable("Alquileres");
                });

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

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<float>("Kilometraje")
                        .HasColumnType("real");

                    b.Property<int>("ModeloID")
                        .HasColumnType("int");

                    b.Property<string>("Patente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SucursalID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ModeloID");

                    b.HasIndex("Patente")
                        .IsUnique();

                    b.HasIndex("SucursalID");

                    b.ToTable("Auto", (string)null);
                });

            modelBuilder.Entity("AlquileresAutos.Models.EntidadCrediticia", b =>
                {
                    b.Property<int>("EntidadCrediticiaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EntidadCrediticiaID"));

                    b.Property<string>("descripcionEntidadCrediticia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreEntidadCrediticia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EntidadCrediticiaID");

                    b.ToTable("EntidadesCrediticias");
                });

            modelBuilder.Entity("AlquileresAutos.Models.Localidad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Denominacion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProvinciaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProvinciaID");

                    b.ToTable("Localidad");
                });

            modelBuilder.Entity("AlquileresAutos.Models.MedioDePago", b =>
                {
                    b.Property<int>("MedioDePagoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedioDePagoID"));

                    b.Property<string>("descripcionMedioDePago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreMedioDePago")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MedioDePagoID");

                    b.ToTable("MediosDePagos");
                });

            modelBuilder.Entity("AlquileresAutos.Models.Modelo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("AireAcondicionado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CantEquipajeChico")
                        .HasColumnType("int");

                    b.Property<int>("CantEquipajeGrande")
                        .HasColumnType("int");

                    b.Property<int>("CantPasajeros")
                        .HasColumnType("int");

                    b.Property<string>("Denominacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PrecioPorDia")
                        .HasColumnType("real");

                    b.Property<int?>("TipoAutoID")
                        .HasColumnType("int");

                    b.Property<string>("Transmision")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("TipoAutoID");

                    b.ToTable("Modelo", (string)null);
                });

            modelBuilder.Entity("AlquileresAutos.Models.PlanDePago", b =>
                {
                    b.Property<int>("PlanDePagoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlanDePagoID"));

                    b.Property<int>("CantidadCuotasPagas")
                        .HasColumnType("int");

                    b.Property<int>("CantidadDeCuotas")
                        .HasColumnType("int");

                    b.Property<string>("DescripcionPlanDePago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EntidadCrediticiaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaInicioPlan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaUltimoPago")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedioDePagoID")
                        .HasColumnType("int");

                    b.Property<string>("NombrePlanDePago")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("PrecioPorCuota")
                        .HasColumnType("real");

                    b.Property<float>("TotalAPagar")
                        .HasColumnType("real");

                    b.HasKey("PlanDePagoID");

                    b.HasIndex("EntidadCrediticiaID");

                    b.HasIndex("MedioDePagoID");

                    b.ToTable("PlanesDePagos");
                });

            modelBuilder.Entity("AlquileresAutos.Models.Provincia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Denominacion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("AlquileresAutos.Models.Sucursal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Denominacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoraApertura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoraCierre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocalidadID")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("LocalidadID");

                    b.ToTable("Sucursal");
                });

            modelBuilder.Entity("AlquileresAutos.Models.TipoAuto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("NombreTipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TipoAuto", (string)null);
                });

            modelBuilder.Entity("AlquileresAutos.Models.Alquiler", b =>
                {
                    b.HasOne("AlquileresAutos.Models.Auto", "Auto")
                        .WithMany()
                        .HasForeignKey("AutoID");

                    b.HasOne("AlquileresAutos.Models.EntidadCrediticia", "EntidadCrediticia")
                        .WithMany()
                        .HasForeignKey("EntidadCrediticiaID");

                    b.HasOne("AlquileresAutos.Models.MedioDePago", "MedioDePago")
                        .WithMany()
                        .HasForeignKey("MedioDePagoID");

                    b.HasOne("AlquileresAutos.Models.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloID");

                    b.HasOne("AlquileresAutos.Models.PlanDePago", "PlanDePago")
                        .WithMany()
                        .HasForeignKey("PlanDePagoID");

                    b.HasOne("AlquileresAutos.Models.Sucursal", "Sucursal")
                        .WithMany()
                        .HasForeignKey("SucursalID");

                    b.HasOne("AlquileresAutos.Models.TipoAuto", "TipoAuto")
                        .WithMany()
                        .HasForeignKey("TipoAutoID");

                    b.Navigation("Auto");

                    b.Navigation("EntidadCrediticia");

                    b.Navigation("MedioDePago");

                    b.Navigation("Modelo");

                    b.Navigation("PlanDePago");

                    b.Navigation("Sucursal");

                    b.Navigation("TipoAuto");
                });

            modelBuilder.Entity("AlquileresAutos.Models.Auto", b =>
                {
                    b.HasOne("AlquileresAutos.Models.Modelo", "Modelo")
                        .WithMany("Autos")
                        .HasForeignKey("ModeloID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlquileresAutos.Models.Sucursal", "Sucursal")
                        .WithMany("Autos")
                        .HasForeignKey("SucursalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modelo");

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("AlquileresAutos.Models.Localidad", b =>
                {
                    b.HasOne("AlquileresAutos.Models.Provincia", "Provincia")
                        .WithMany("Localidades")
                        .HasForeignKey("ProvinciaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provincia");
                });

            modelBuilder.Entity("AlquileresAutos.Models.Modelo", b =>
                {
                    b.HasOne("AlquileresAutos.Models.TipoAuto", "tipoAuto")
                        .WithMany("Modelos")
                        .HasForeignKey("TipoAutoID");

                    b.Navigation("tipoAuto");
                });

            modelBuilder.Entity("AlquileresAutos.Models.PlanDePago", b =>
                {
                    b.HasOne("AlquileresAutos.Models.EntidadCrediticia", "EntidadCrediticia")
                        .WithMany("PlanesDePago")
                        .HasForeignKey("EntidadCrediticiaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlquileresAutos.Models.MedioDePago", "MedioDePago")
                        .WithMany("PlanesDePago")
                        .HasForeignKey("MedioDePagoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntidadCrediticia");

                    b.Navigation("MedioDePago");
                });

            modelBuilder.Entity("AlquileresAutos.Models.Sucursal", b =>
                {
                    b.HasOne("AlquileresAutos.Models.Localidad", "Localidad")
                        .WithMany("Sucursales")
                        .HasForeignKey("LocalidadID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Localidad");
                });

            modelBuilder.Entity("AlquileresAutos.Models.EntidadCrediticia", b =>
                {
                    b.Navigation("PlanesDePago");
                });

            modelBuilder.Entity("AlquileresAutos.Models.Localidad", b =>
                {
                    b.Navigation("Sucursales");
                });

            modelBuilder.Entity("AlquileresAutos.Models.MedioDePago", b =>
                {
                    b.Navigation("PlanesDePago");
                });

            modelBuilder.Entity("AlquileresAutos.Models.Modelo", b =>
                {
                    b.Navigation("Autos");
                });

            modelBuilder.Entity("AlquileresAutos.Models.Provincia", b =>
                {
                    b.Navigation("Localidades");
                });

            modelBuilder.Entity("AlquileresAutos.Models.Sucursal", b =>
                {
                    b.Navigation("Autos");
                });

            modelBuilder.Entity("AlquileresAutos.Models.TipoAuto", b =>
                {
                    b.Navigation("Modelos");
                });
#pragma warning restore 612, 618
        }
    }
}
