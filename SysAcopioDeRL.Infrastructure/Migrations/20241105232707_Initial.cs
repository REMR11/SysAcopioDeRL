using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SysAcopioDeRL.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    idproveedor = table.Column<long>(name: "id_proveedor", type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreproveedor = table.Column<string>(name: "nombre_proveedor", type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Proveedo__8D3DFE28F64B4E52", x => x.idproveedor);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    idrol = table.Column<long>(name: "id_rol", type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombrerol = table.Column<string>(name: "nombre_rol", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Rol__6ABCB5E0C6FDA965", x => x.idrol);
                });

            migrationBuilder.CreateTable(
                name: "Solicitud",
                columns: table => new
                {
                    idsolicitud = table.Column<long>(name: "id_solicitud", type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ubicacion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    nombresolicitante = table.Column<string>(name: "nombre_solicitante", type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    urgencia = table.Column<byte>(type: "tinyint", nullable: false),
                    motivo = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Solicitu__5C0C31F365C21C7F", x => x.idsolicitud);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Recurso",
                columns: table => new
                {
                    idtiporecurso = table.Column<long>(name: "id_tipo_recurso", type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombretipo = table.Column<string>(name: "nombre_tipo", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tipo_Rec__F8B8B7CE9E933468", x => x.idtiporecurso);
                });

            migrationBuilder.CreateTable(
                name: "Donacion",
                columns: table => new
                {
                    iddonacion = table.Column<long>(name: "id_donacion", type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idproveedor = table.Column<long>(name: "id_proveedor", type: "bigint", nullable: false),
                    ubicacion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Donacion__931F75CCFCD86B45", x => x.iddonacion);
                    table.ForeignKey(
                        name: "fk_donacion_proveedor",
                        column: x => x.idproveedor,
                        principalTable: "Proveedor",
                        principalColumn: "id_proveedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idusuario = table.Column<long>(name: "id_usuario", type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aliasusuario = table.Column<string>(name: "alias_usuario", type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    nombreusuario = table.Column<string>(name: "nombre_usuario", type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    contrasenia = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    idrol = table.Column<long>(name: "id_rol", type: "bigint", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Usuario__4E3E04AD9CB6F9C2", x => x.idusuario);
                    table.ForeignKey(
                        name: "fk_usuario_rol",
                        column: x => x.idrol,
                        principalTable: "Rol",
                        principalColumn: "id_rol",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recurso",
                columns: table => new
                {
                    idrecurso = table.Column<long>(name: "id_recurso", type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombrerecurso = table.Column<string>(name: "nombre_recurso", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    idtiporecurso = table.Column<long>(name: "id_tipo_recurso", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Recurso__2B386DE4DE783DB2", x => x.idrecurso);
                    table.ForeignKey(
                        name: "fk_recurso_tipo_recurso",
                        column: x => x.idtiporecurso,
                        principalTable: "Tipo_Recurso",
                        principalColumn: "id_tipo_recurso",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recurso_Donacion",
                columns: table => new
                {
                    idrecursodonacion = table.Column<long>(name: "id_recurso_donacion", type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    iddonacion = table.Column<long>(name: "id_donacion", type: "bigint", nullable: false),
                    idrecurso = table.Column<long>(name: "id_recurso", type: "bigint", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Recurso___9565F4178D8C9919", x => x.idrecursodonacion);
                    table.ForeignKey(
                        name: "fk_recurso_donacion_donacion",
                        column: x => x.iddonacion,
                        principalTable: "Donacion",
                        principalColumn: "id_donacion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_recurso_donacion_recurso",
                        column: x => x.idrecurso,
                        principalTable: "Recurso",
                        principalColumn: "id_recurso",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recurso_Solicitud",
                columns: table => new
                {
                    idrecursosolicitud = table.Column<long>(name: "id_recurso_solicitud", type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idrecurso = table.Column<long>(name: "id_recurso", type: "bigint", nullable: false),
                    idsolicitud = table.Column<long>(name: "id_solicitud", type: "bigint", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Recurso___C21795884DFEDF38", x => x.idrecursosolicitud);
                    table.ForeignKey(
                        name: "fk_recurso_solicitud_recurso",
                        column: x => x.idrecurso,
                        principalTable: "Recurso",
                        principalColumn: "id_recurso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_recurso_solicitud_solicitud",
                        column: x => x.idsolicitud,
                        principalTable: "Solicitud",
                        principalColumn: "id_solicitud",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donacion_id_proveedor",
                table: "Donacion",
                column: "id_proveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_id_tipo_recurso",
                table: "Recurso",
                column: "id_tipo_recurso");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_Donacion_id_donacion",
                table: "Recurso_Donacion",
                column: "id_donacion");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_Donacion_id_recurso",
                table: "Recurso_Donacion",
                column: "id_recurso");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_Solicitud_id_recurso",
                table: "Recurso_Solicitud",
                column: "id_recurso");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_Solicitud_id_solicitud",
                table: "Recurso_Solicitud",
                column: "id_solicitud");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_id_rol",
                table: "Usuario",
                column: "id_rol");

            migrationBuilder.CreateIndex(
                name: "UQ__Usuario__9A6188F5DC994E39",
                table: "Usuario",
                column: "alias_usuario",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recurso_Donacion");

            migrationBuilder.DropTable(
                name: "Recurso_Solicitud");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Donacion");

            migrationBuilder.DropTable(
                name: "Recurso");

            migrationBuilder.DropTable(
                name: "Solicitud");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "Tipo_Recurso");
        }
    }
}
