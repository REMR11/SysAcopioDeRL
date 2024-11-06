using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SysAcopioDeRL.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NuevoCampoIsCancelSolicitud : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_cancel",
                table: "Solicitud",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_cancel",
                table: "Solicitud");
        }
    }
}
