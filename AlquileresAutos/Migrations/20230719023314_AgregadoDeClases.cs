using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlquileresAutos.Migrations
{
    /// <inheritdoc />
    public partial class AgregadoDeClases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modelo_TipoAuto_TipoAutoID",
                table: "Modelo");

            migrationBuilder.AlterColumn<int>(
                name: "TipoAutoID",
                table: "Modelo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AlterColumn<int>(
                name: "TipoAutoID",
                table: "Modelo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Modelo_TipoAuto_TipoAutoID",
                table: "Modelo",
                column: "TipoAutoID",
                principalTable: "TipoAuto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
