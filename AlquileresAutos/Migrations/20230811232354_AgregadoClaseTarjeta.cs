using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlquileresAutos.Migrations
{
    /// <inheritdoc />
    public partial class AgregadoClaseTarjeta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarjetas",
                columns: table => new
                {
                    TarjetaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroTarjeta = table.Column<int>(type: "int", nullable: false),
                    TitularTarjeta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DniTitularTarjeta = table.Column<int>(type: "int", nullable: false),
                    MesVencimientoTarjeta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnioVencimientoTarjeta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjetas", x => x.TarjetaID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarjetas");
        }
    }
}
