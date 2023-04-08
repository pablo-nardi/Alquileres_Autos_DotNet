using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlquileresAutos.Migrations
{
    /// <inheritdoc />
    public partial class ArmadoAbmComplejo2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modelo_TipoAuto_tipoAutoID",
                table: "Modelo");

            migrationBuilder.RenameColumn(
                name: "tipoAutoID",
                table: "Modelo",
                newName: "TipoAutoID");

            migrationBuilder.RenameIndex(
                name: "IX_Modelo_tipoAutoID",
                table: "Modelo",
                newName: "IX_Modelo_TipoAutoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Modelo_TipoAuto_TipoAutoID",
                table: "Modelo",
                column: "TipoAutoID",
                principalTable: "TipoAuto",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modelo_TipoAuto_TipoAutoID",
                table: "Modelo");

            migrationBuilder.RenameColumn(
                name: "TipoAutoID",
                table: "Modelo",
                newName: "tipoAutoID");

            migrationBuilder.RenameIndex(
                name: "IX_Modelo_TipoAutoID",
                table: "Modelo",
                newName: "IX_Modelo_tipoAutoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Modelo_TipoAuto_tipoAutoID",
                table: "Modelo",
                column: "tipoAutoID",
                principalTable: "TipoAuto",
                principalColumn: "ID");
        }
    }
}
