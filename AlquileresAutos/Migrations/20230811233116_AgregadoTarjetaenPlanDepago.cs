using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlquileresAutos.Migrations
{
    /// <inheritdoc />
    public partial class AgregadoTarjetaenPlanDepago : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TarjetaID",
                table: "PlanesDePagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PlanesDePagos_TarjetaID",
                table: "PlanesDePagos",
                column: "TarjetaID");

            migrationBuilder.AddForeignKey(
                name: "FK_PlanesDePagos_Tarjetas_TarjetaID",
                table: "PlanesDePagos",
                column: "TarjetaID",
                principalTable: "Tarjetas",
                principalColumn: "TarjetaID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlanesDePagos_Tarjetas_TarjetaID",
                table: "PlanesDePagos");

            migrationBuilder.DropIndex(
                name: "IX_PlanesDePagos_TarjetaID",
                table: "PlanesDePagos");

            migrationBuilder.DropColumn(
                name: "TarjetaID",
                table: "PlanesDePagos");
        }
    }
}
