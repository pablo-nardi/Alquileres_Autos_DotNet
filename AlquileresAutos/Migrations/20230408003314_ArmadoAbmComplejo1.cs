using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlquileresAutos.Migrations
{
    /// <inheritdoc />
    public partial class ArmadoAbmComplejo1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "tipoAutoID",
                table: "Modelo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modelo_tipoAutoID",
                table: "Modelo",
                column: "tipoAutoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Modelo_TipoAuto_tipoAutoID",
                table: "Modelo",
                column: "tipoAutoID",
                principalTable: "TipoAuto",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modelo_TipoAuto_tipoAutoID",
                table: "Modelo");

            migrationBuilder.DropIndex(
                name: "IX_Modelo_tipoAutoID",
                table: "Modelo");

            migrationBuilder.DropColumn(
                name: "tipoAutoID",
                table: "Modelo");
        }
    }
}
