using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlquileresAutos.Migrations
{
    /// <inheritdoc />
    public partial class armadoabmsimples : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auto_Modelo_modeloID",
                table: "Auto");

            migrationBuilder.RenameColumn(
                name: "nombreTipo",
                table: "TipoAuto",
                newName: "NombreTipo");

            migrationBuilder.RenameColumn(
                name: "transmision",
                table: "Modelo",
                newName: "Transmision");

            migrationBuilder.RenameColumn(
                name: "precioPorDia",
                table: "Modelo",
                newName: "PrecioPorDia");

            migrationBuilder.RenameColumn(
                name: "denominacion",
                table: "Modelo",
                newName: "Denominacion");

            migrationBuilder.RenameColumn(
                name: "cantPasajeros",
                table: "Modelo",
                newName: "CantPasajeros");

            migrationBuilder.RenameColumn(
                name: "cantEquipajeGrande",
                table: "Modelo",
                newName: "CantEquipajeGrande");

            migrationBuilder.RenameColumn(
                name: "cantEquipajeChico",
                table: "Modelo",
                newName: "CantEquipajeChico");

            migrationBuilder.RenameColumn(
                name: "aireAcondicionado",
                table: "Modelo",
                newName: "AireAcondicionado");

            migrationBuilder.RenameColumn(
                name: "modeloID",
                table: "Auto",
                newName: "ModeloID");

            migrationBuilder.RenameColumn(
                name: "kilometraje",
                table: "Auto",
                newName: "Kilometraje");

            migrationBuilder.RenameColumn(
                name: "fechaCompra",
                table: "Auto",
                newName: "FechaCompra");

            migrationBuilder.RenameColumn(
                name: "detalle",
                table: "Auto",
                newName: "Detalle");

            migrationBuilder.RenameColumn(
                name: "capacidadTanque",
                table: "Auto",
                newName: "CapacidadTanque");

            migrationBuilder.RenameIndex(
                name: "IX_Auto_modeloID",
                table: "Auto",
                newName: "IX_Auto_ModeloID");

            migrationBuilder.AddForeignKey(
                name: "FK_Auto_Modelo_ModeloID",
                table: "Auto",
                column: "ModeloID",
                principalTable: "Modelo",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auto_Modelo_ModeloID",
                table: "Auto");

            migrationBuilder.RenameColumn(
                name: "NombreTipo",
                table: "TipoAuto",
                newName: "nombreTipo");

            migrationBuilder.RenameColumn(
                name: "Transmision",
                table: "Modelo",
                newName: "transmision");

            migrationBuilder.RenameColumn(
                name: "PrecioPorDia",
                table: "Modelo",
                newName: "precioPorDia");

            migrationBuilder.RenameColumn(
                name: "Denominacion",
                table: "Modelo",
                newName: "denominacion");

            migrationBuilder.RenameColumn(
                name: "CantPasajeros",
                table: "Modelo",
                newName: "cantPasajeros");

            migrationBuilder.RenameColumn(
                name: "CantEquipajeGrande",
                table: "Modelo",
                newName: "cantEquipajeGrande");

            migrationBuilder.RenameColumn(
                name: "CantEquipajeChico",
                table: "Modelo",
                newName: "cantEquipajeChico");

            migrationBuilder.RenameColumn(
                name: "AireAcondicionado",
                table: "Modelo",
                newName: "aireAcondicionado");

            migrationBuilder.RenameColumn(
                name: "ModeloID",
                table: "Auto",
                newName: "modeloID");

            migrationBuilder.RenameColumn(
                name: "Kilometraje",
                table: "Auto",
                newName: "kilometraje");

            migrationBuilder.RenameColumn(
                name: "FechaCompra",
                table: "Auto",
                newName: "fechaCompra");

            migrationBuilder.RenameColumn(
                name: "Detalle",
                table: "Auto",
                newName: "detalle");

            migrationBuilder.RenameColumn(
                name: "CapacidadTanque",
                table: "Auto",
                newName: "capacidadTanque");

            migrationBuilder.RenameIndex(
                name: "IX_Auto_ModeloID",
                table: "Auto",
                newName: "IX_Auto_modeloID");

            migrationBuilder.AddForeignKey(
                name: "FK_Auto_Modelo_modeloID",
                table: "Auto",
                column: "modeloID",
                principalTable: "Modelo",
                principalColumn: "ID");
        }
    }
}
