using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villlas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa...", new DateTime(2026, 1, 18, 13, 36, 54, 569, DateTimeKind.Local).AddTicks(5479), new DateTime(2026, 1, 18, 13, 36, 54, 569, DateTimeKind.Local).AddTicks(5469), "", 50, "Villa Real", 4, 200.0 },
                    { 2, "", "Detalle de la Villa...", new DateTime(2026, 1, 18, 13, 36, 54, 569, DateTimeKind.Local).AddTicks(5481), new DateTime(2026, 1, 18, 13, 36, 54, 569, DateTimeKind.Local).AddTicks(5481), "", 50, "Premium Vista a la Piscina", 4, 200.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villlas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villlas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
