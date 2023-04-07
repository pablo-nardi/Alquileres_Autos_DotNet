using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlquileresAutos.Migrations
{
    /// <inheritdoc />
    public partial class migracion_inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modelo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantEquipajeChico = table.Column<int>(type: "int", nullable: false),
                    cantEquipajeGrande = table.Column<int>(type: "int", nullable: false),
                    cantPasajeros = table.Column<int>(type: "int", nullable: false),
                    precioPorDia = table.Column<float>(type: "real", nullable: false),
                    denominacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transmision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aireAcondicionado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TipoAuto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreTipo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAuto", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Auto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    capacidadTanque = table.Column<float>(type: "real", nullable: false),
                    kilometraje = table.Column<float>(type: "real", nullable: false),
                    fechaCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    detalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modeloID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Auto_Modelo_modeloID",
                        column: x => x.modeloID,
                        principalTable: "Modelo",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auto_modeloID",
                table: "Auto",
                column: "modeloID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auto");

            migrationBuilder.DropTable(
                name: "TipoAuto");

            migrationBuilder.DropTable(
                name: "Modelo");
        }
    }
}
