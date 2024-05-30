using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseDeDatos.Migrations
{
    /// <inheritdoc />
    public partial class relaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Ticketes_TicketId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_TicketId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Productos");

            migrationBuilder.AddColumn<decimal>(
                name: "CostoTotal",
                table: "Ticketes",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "ProductoTicket",
                columns: table => new
                {
                    ProductosProductoId = table.Column<int>(type: "int", nullable: false),
                    TicketsTicketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoTicket", x => new { x.ProductosProductoId, x.TicketsTicketId });
                    table.ForeignKey(
                        name: "FK_ProductoTicket_Productos_ProductosProductoId",
                        column: x => x.ProductosProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoTicket_Ticketes_TicketsTicketId",
                        column: x => x.TicketsTicketId,
                        principalTable: "Ticketes",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductoTicket_TicketsTicketId",
                table: "ProductoTicket",
                column: "TicketsTicketId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoTicket");

            migrationBuilder.DropColumn(
                name: "CostoTotal",
                table: "Ticketes");

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Productos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TicketId",
                table: "Productos",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Ticketes_TicketId",
                table: "Productos",
                column: "TicketId",
                principalTable: "Ticketes",
                principalColumn: "TicketId");
        }
    }
}
