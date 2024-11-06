using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SysAcopioDeRL.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CambioNombreDeColumnaEstadoSolicitud : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "activo",
                table: "Solicitud",
                newName: "estado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Solicitud",
                newName: "activo");
        }
    }
}
