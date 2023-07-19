using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlquileresAutos.Migrations
{
    /// <inheritdoc />
    public partial class AgregadoDeClasesSobreMedioDePago : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntidadesCrediticias",
                columns: table => new
                {
                    EntidadCrediticiaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreEntidadCrediticia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcionEntidadCrediticia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadesCrediticias", x => x.EntidadCrediticiaID);
                });

            migrationBuilder.CreateTable(
                name: "MediosDePagos",
                columns: table => new
                {
                    MedioDePagoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreMedioDePago = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcionMedioDePago = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediosDePagos", x => x.MedioDePagoID);
                });

            migrationBuilder.CreateTable(
                name: "PlanesDePagos",
                columns: table => new
                {
                    PlanDePagoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePlanDePago = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DescripcionPlanDePago = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDEntidadCrediticia = table.Column<int>(type: "int", nullable: false),
                    EntidadCrediticiaID = table.Column<int>(type: "int", nullable: true),
                    IDMedioDePago = table.Column<int>(type: "int", nullable: false),
                    MedioDePagoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanesDePagos", x => x.PlanDePagoID);
                    table.ForeignKey(
                        name: "FK_PlanesDePagos_EntidadesCrediticias_EntidadCrediticiaID",
                        column: x => x.EntidadCrediticiaID,
                        principalTable: "EntidadesCrediticias",
                        principalColumn: "EntidadCrediticiaID");
                    table.ForeignKey(
                        name: "FK_PlanesDePagos_MediosDePagos_MedioDePagoID",
                        column: x => x.MedioDePagoID,
                        principalTable: "MediosDePagos",
                        principalColumn: "MedioDePagoID");
                });

            migrationBuilder.CreateTable(
                name: "Alquileres",
                columns: table => new
                {
                    AlquilerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImporteAcordadoConCliente = table.Column<float>(type: "real", nullable: false),
                    CostoPorDaños = table.Column<float>(type: "real", nullable: false),
                    CostoPorDevolucionTardia = table.Column<float>(type: "real", nullable: false),
                    PrecioDiario = table.Column<float>(type: "real", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    FechaHoraRetiroPrevista = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaHoraDevolucionPrevista = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaHoraRetiroReal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaHoraDevolucionReal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDAuto = table.Column<int>(type: "int", nullable: false),
                    IDEntidadCrediticia = table.Column<int>(type: "int", nullable: false),
                    IDMedioDePago = table.Column<int>(type: "int", nullable: false),
                    IDModelo = table.Column<int>(type: "int", nullable: false),
                    IDPlanDePago = table.Column<int>(type: "int", nullable: false),
                    IDSucursal = table.Column<int>(type: "int", nullable: false),
                    IDTipoAuto = table.Column<int>(type: "int", nullable: false),
                    AutoID = table.Column<int>(type: "int", nullable: true),
                    ModeloID = table.Column<int>(type: "int", nullable: true),
                    TipoAutoID = table.Column<int>(type: "int", nullable: true),
                    EntidadCrediticiaID = table.Column<int>(type: "int", nullable: true),
                    MedioDePagoID = table.Column<int>(type: "int", nullable: true),
                    PlanDePagoID = table.Column<int>(type: "int", nullable: true),
                    SucursalID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquileres", x => x.AlquilerID);
                    table.ForeignKey(
                        name: "FK_Alquileres_Auto_AutoID",
                        column: x => x.AutoID,
                        principalTable: "Auto",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Alquileres_EntidadesCrediticias_EntidadCrediticiaID",
                        column: x => x.EntidadCrediticiaID,
                        principalTable: "EntidadesCrediticias",
                        principalColumn: "EntidadCrediticiaID");
                    table.ForeignKey(
                        name: "FK_Alquileres_MediosDePagos_MedioDePagoID",
                        column: x => x.MedioDePagoID,
                        principalTable: "MediosDePagos",
                        principalColumn: "MedioDePagoID");
                    table.ForeignKey(
                        name: "FK_Alquileres_Modelo_ModeloID",
                        column: x => x.ModeloID,
                        principalTable: "Modelo",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Alquileres_PlanesDePagos_PlanDePagoID",
                        column: x => x.PlanDePagoID,
                        principalTable: "PlanesDePagos",
                        principalColumn: "PlanDePagoID");
                    table.ForeignKey(
                        name: "FK_Alquileres_Sucursal_SucursalID",
                        column: x => x.SucursalID,
                        principalTable: "Sucursal",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Alquileres_TipoAuto_TipoAutoID",
                        column: x => x.TipoAutoID,
                        principalTable: "TipoAuto",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alquileres_AutoID",
                table: "Alquileres",
                column: "AutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Alquileres_EntidadCrediticiaID",
                table: "Alquileres",
                column: "EntidadCrediticiaID");

            migrationBuilder.CreateIndex(
                name: "IX_Alquileres_MedioDePagoID",
                table: "Alquileres",
                column: "MedioDePagoID");

            migrationBuilder.CreateIndex(
                name: "IX_Alquileres_ModeloID",
                table: "Alquileres",
                column: "ModeloID");

            migrationBuilder.CreateIndex(
                name: "IX_Alquileres_PlanDePagoID",
                table: "Alquileres",
                column: "PlanDePagoID");

            migrationBuilder.CreateIndex(
                name: "IX_Alquileres_SucursalID",
                table: "Alquileres",
                column: "SucursalID");

            migrationBuilder.CreateIndex(
                name: "IX_Alquileres_TipoAutoID",
                table: "Alquileres",
                column: "TipoAutoID");

            migrationBuilder.CreateIndex(
                name: "IX_PlanesDePagos_EntidadCrediticiaID",
                table: "PlanesDePagos",
                column: "EntidadCrediticiaID");

            migrationBuilder.CreateIndex(
                name: "IX_PlanesDePagos_MedioDePagoID",
                table: "PlanesDePagos",
                column: "MedioDePagoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alquileres");

            migrationBuilder.DropTable(
                name: "PlanesDePagos");

            migrationBuilder.DropTable(
                name: "EntidadesCrediticias");

            migrationBuilder.DropTable(
                name: "MediosDePagos");
        }
    }
}
