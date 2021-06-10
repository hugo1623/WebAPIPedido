using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPIPedido.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    IdPedido = table.Column<int>(type: "int", nullable: false),
                    Fecha_Pedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Espera = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Entrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detalle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
