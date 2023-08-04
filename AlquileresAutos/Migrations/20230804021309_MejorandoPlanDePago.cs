using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlquileresAutos.Migrations
{
    /// <inheritdoc />
    public partial class MejorandoPlanDePago : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CantidadCuotasPagas",
                table: "PlanesDePagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CantidadDeCuotas",
                table: "PlanesDePagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInicioPlan",
                table: "PlanesDePagos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaUltimoPago",
                table: "PlanesDePagos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "PrecioPorCuota",
                table: "PlanesDePagos",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalAPagar",
                table: "PlanesDePagos",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadCuotasPagas",
                table: "PlanesDePagos");

            migrationBuilder.DropColumn(
                name: "CantidadDeCuotas",
                table: "PlanesDePagos");

            migrationBuilder.DropColumn(
                name: "FechaInicioPlan",
                table: "PlanesDePagos");

            migrationBuilder.DropColumn(
                name: "FechaUltimoPago",
                table: "PlanesDePagos");

            migrationBuilder.DropColumn(
                name: "PrecioPorCuota",
                table: "PlanesDePagos");

            migrationBuilder.DropColumn(
                name: "TotalAPagar",
                table: "PlanesDePagos");
        }
    }
}
