using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Luis_Cruz_Aragòn.Migrations
{
    public partial class migracionclientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(maxLength: 100, nullable: false),
                    Direccion = table.Column<string>(maxLength: 200, nullable: false),
                    Telefono = table.Column<string>(maxLength: 12, nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    Cedula = table.Column<string>(maxLength: 16, nullable: false),
                    CreadoPor = table.Column<string>(maxLength: 10, nullable: true),
                    CreadoEl = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.IdCliente);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
