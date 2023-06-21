using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlquileresAutos.Migrations
{
    /// <inheritdoc />
    public partial class ModificandoFechasSucursales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Auto_SucursalID",
                table: "Auto",
                column: "SucursalID");

            migrationBuilder.AddForeignKey(
                name: "FK_Auto_Sucursal_SucursalID",
                table: "Auto",
                column: "SucursalID",
                principalTable: "Sucursal",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auto_Sucursal_SucursalID",
                table: "Auto");

            migrationBuilder.DropIndex(
                name: "IX_Auto_SucursalID",
                table: "Auto");
        }
    }
}
