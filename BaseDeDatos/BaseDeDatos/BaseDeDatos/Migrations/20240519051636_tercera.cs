using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseDeDatos.Migrations
{
    /// <inheritdoc />
    public partial class tercera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Productos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ticketes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SucursalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticketes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticketes_Sucursales_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TicketId",
                table: "Productos",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticketes_SucursalId",
                table: "Ticketes",
                column: "SucursalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Ticketes_TicketId",
                table: "Productos",
                column: "TicketId",
                principalTable: "Ticketes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Ticketes_TicketId",
                table: "Productos");

            migrationBuilder.DropTable(
                name: "Ticketes");

            migrationBuilder.DropIndex(
                name: "IX_Productos_TicketId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Productos");
        }
    }
}
