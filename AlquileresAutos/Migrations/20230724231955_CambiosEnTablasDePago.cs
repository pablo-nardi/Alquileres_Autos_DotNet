using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlquileresAutos.Migrations
{
    /// <inheritdoc />
    public partial class CambiosEnTablasDePago : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlanesDePagos_EntidadesCrediticias_EntidadCrediticiaID",
                table: "PlanesDePagos");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanesDePagos_MediosDePagos_MedioDePagoID",
                table: "PlanesDePagos");

            migrationBuilder.DropColumn(
                name: "IDEntidadCrediticia",
                table: "PlanesDePagos");

            migrationBuilder.DropColumn(
                name: "IDMedioDePago",
                table: "PlanesDePagos");

            migrationBuilder.AlterColumn<int>(
                name: "MedioDePagoID",
                table: "PlanesDePagos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EntidadCrediticiaID",
                table: "PlanesDePagos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanesDePagos_EntidadesCrediticias_EntidadCrediticiaID",
                table: "PlanesDePagos",
                column: "EntidadCrediticiaID",
                principalTable: "EntidadesCrediticias",
                principalColumn: "EntidadCrediticiaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanesDePagos_MediosDePagos_MedioDePagoID",
                table: "PlanesDePagos",
                column: "MedioDePagoID",
                principalTable: "MediosDePagos",
                principalColumn: "MedioDePagoID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlanesDePagos_EntidadesCrediticias_EntidadCrediticiaID",
                table: "PlanesDePagos");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanesDePagos_MediosDePagos_MedioDePagoID",
                table: "PlanesDePagos");

            migrationBuilder.AlterColumn<int>(
                name: "MedioDePagoID",
                table: "PlanesDePagos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EntidadCrediticiaID",
                table: "PlanesDePagos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IDEntidadCrediticia",
                table: "PlanesDePagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDMedioDePago",
                table: "PlanesDePagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanesDePagos_EntidadesCrediticias_EntidadCrediticiaID",
                table: "PlanesDePagos",
                column: "EntidadCrediticiaID",
                principalTable: "EntidadesCrediticias",
                principalColumn: "EntidadCrediticiaID");

            migrationBuilder.AddForeignKey(
                name: "FK_PlanesDePagos_MediosDePagos_MedioDePagoID",
                table: "PlanesDePagos",
                column: "MedioDePagoID",
                principalTable: "MediosDePagos",
                principalColumn: "MedioDePagoID");
        }
    }
}
