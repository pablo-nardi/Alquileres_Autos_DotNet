using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlquileresAutos.Migrations
{
    /// <inheritdoc />
    public partial class ambcAutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auto_Modelo_ModeloID",
                table: "Auto");

            migrationBuilder.AlterColumn<int>(
                name: "ModeloID",
                table: "Auto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Auto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Auto_Modelo_ModeloID",
                table: "Auto",
                column: "ModeloID",
                principalTable: "Modelo",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auto_Modelo_ModeloID",
                table: "Auto");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Auto");

            migrationBuilder.AlterColumn<int>(
                name: "ModeloID",
                table: "Auto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Auto_Modelo_ModeloID",
                table: "Auto",
                column: "ModeloID",
                principalTable: "Modelo",
                principalColumn: "ID");
        }
    }
}
