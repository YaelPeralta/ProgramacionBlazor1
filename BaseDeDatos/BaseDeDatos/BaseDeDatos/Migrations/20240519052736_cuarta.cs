using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseDeDatos.Migrations
{
    /// <inheritdoc />
    public partial class cuarta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ticketes",
                newName: "TicketId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Sucursales",
                newName: "SucursalId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Productos",
                newName: "ProductoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Ticketes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SucursalId",
                table: "Sucursales",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "Productos",
                newName: "Id");
        }
    }
}
