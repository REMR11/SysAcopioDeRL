﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SysAcopioDeRL.Infrastructure;

#nullable disable

namespace SysAcopioDeRL.Infrastructure.Migrations
{
    [DbContext(typeof(DbacopioDeRlContext))]
    [Migration("20241106133128_CambioNombreDeColumnaEstadoSolicitud")]
    partial class CambioNombreDeColumnaEstadoSolicitud
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SysAcopioDeRL.Entities.Donacion", b =>
                {
                    b.Property<long>("IdDonacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_donacion");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdDonacion"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha");

                    b.Property<long>("IdProveedor")
                        .HasColumnType("bigint")
                        .HasColumnName("id_proveedor");

                    b.Property<string>("Ubicacion")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("ubicacion");

                    b.HasKey("IdDonacion")
                        .HasName("PK__Donacion__931F75CCFCD86B45");

                    b.HasIndex("IdProveedor");

                    b.ToTable("Donacion");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.Proveedor", b =>
                {
                    b.Property<long>("IdProveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_proveedor");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdProveedor"));

                    b.Property<bool>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.Property<string>("NombreProveedor")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nombre_proveedor");

                    b.HasKey("IdProveedor")
                        .HasName("PK__Proveedo__8D3DFE28F64B4E52");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.Recurso", b =>
                {
                    b.Property<long>("IdRecurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_recurso");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdRecurso"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<long>("IdTipoRecurso")
                        .HasColumnType("bigint")
                        .HasColumnName("id_tipo_recurso");

                    b.Property<string>("NombreRecurso")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre_recurso");

                    b.HasKey("IdRecurso")
                        .HasName("PK__Recurso__2B386DE4DE783DB2");

                    b.HasIndex("IdTipoRecurso");

                    b.ToTable("Recurso");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.RecursoDonacion", b =>
                {
                    b.Property<long>("IdRecursoDonacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_recurso_donacion");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdRecursoDonacion"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<long>("IdDonacion")
                        .HasColumnType("bigint")
                        .HasColumnName("id_donacion");

                    b.Property<long>("IdRecurso")
                        .HasColumnType("bigint")
                        .HasColumnName("id_recurso");

                    b.HasKey("IdRecursoDonacion")
                        .HasName("PK__Recurso___9565F4178D8C9919");

                    b.HasIndex("IdDonacion");

                    b.HasIndex("IdRecurso");

                    b.ToTable("Recurso_Donacion");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.RecursoSolicitud", b =>
                {
                    b.Property<long>("IdRecursoSolicitud")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_recurso_solicitud");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdRecursoSolicitud"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<long>("IdRecurso")
                        .HasColumnType("bigint")
                        .HasColumnName("id_recurso");

                    b.Property<long>("IdSolicitud")
                        .HasColumnType("bigint")
                        .HasColumnName("id_solicitud");

                    b.HasKey("IdRecursoSolicitud")
                        .HasName("PK__Recurso___C21795884DFEDF38");

                    b.HasIndex("IdRecurso");

                    b.HasIndex("IdSolicitud");

                    b.ToTable("Recurso_Solicitud");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.Rol", b =>
                {
                    b.Property<long>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_rol");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdRol"));

                    b.Property<string>("NombreRol")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre_rol");

                    b.HasKey("IdRol")
                        .HasName("PK__Rol__6ABCB5E0C6FDA965");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.Solicitud", b =>
                {
                    b.Property<long>("IdSolicitud")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_solicitud");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdSolicitud"));

                    b.Property<bool>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("motivo");

                    b.Property<string>("NombreSolicitante")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nombre_solicitante");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("ubicacion");

                    b.Property<byte>("Urgencia")
                        .HasColumnType("tinyint")
                        .HasColumnName("urgencia");

                    b.HasKey("IdSolicitud")
                        .HasName("PK__Solicitu__5C0C31F365C21C7F");

                    b.ToTable("Solicitud");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.TipoRecurso", b =>
                {
                    b.Property<long>("IdTipoRecurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_tipo_recurso");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdTipoRecurso"));

                    b.Property<string>("NombreTipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre_tipo");

                    b.HasKey("IdTipoRecurso")
                        .HasName("PK__Tipo_Rec__F8B8B7CE9E933468");

                    b.ToTable("Tipo_Recurso");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.Usuario", b =>
                {
                    b.Property<long>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id_usuario");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdUsuario"));

                    b.Property<string>("AliasUsuario")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("alias_usuario");

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("contrasenia");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.Property<long>("IdRol")
                        .HasColumnType("bigint")
                        .HasColumnName("id_rol");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nombre_usuario");

                    b.HasKey("IdUsuario")
                        .HasName("PK__Usuario__4E3E04AD9CB6F9C2");

                    b.HasIndex("IdRol");

                    b.HasIndex(new[] { "AliasUsuario" }, "UQ__Usuario__9A6188F5DC994E39")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.Donacion", b =>
                {
                    b.HasOne("SysAcopioDeRL.Entities.Proveedor", "IdProveedorNavigation")
                        .WithMany("Donaciones")
                        .HasForeignKey("IdProveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_donacion_proveedor");

                    b.Navigation("IdProveedorNavigation");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.Recurso", b =>
                {
                    b.HasOne("SysAcopioDeRL.Entities.TipoRecurso", "IdTipoRecursoNavigation")
                        .WithMany("Recursos")
                        .HasForeignKey("IdTipoRecurso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_recurso_tipo_recurso");

                    b.Navigation("IdTipoRecursoNavigation");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.RecursoDonacion", b =>
                {
                    b.HasOne("SysAcopioDeRL.Entities.Donacion", "IdDonacionNavigation")
                        .WithMany("RecursoDonaciones")
                        .HasForeignKey("IdDonacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_recurso_donacion_donacion");

                    b.HasOne("SysAcopioDeRL.Entities.Recurso", "IdRecursoNavigation")
                        .WithMany("RecursoDonaciones")
                        .HasForeignKey("IdRecurso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_recurso_donacion_recurso");

                    b.Navigation("IdDonacionNavigation");

                    b.Navigation("IdRecursoNavigation");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.RecursoSolicitud", b =>
                {
                    b.HasOne("SysAcopioDeRL.Entities.Recurso", "IdRecursoNavigation")
                        .WithMany("RecursoSolicitudes")
                        .HasForeignKey("IdRecurso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_recurso_solicitud_recurso");

                    b.HasOne("SysAcopioDeRL.Entities.Solicitud", "IdSolicitudNavigation")
                        .WithMany("RecursoSolicitudes")
                        .HasForeignKey("IdSolicitud")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_recurso_solicitud_solicitud");

                    b.Navigation("IdRecursoNavigation");

                    b.Navigation("IdSolicitudNavigation");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.Usuario", b =>
                {
                    b.HasOne("SysAcopioDeRL.Entities.Rol", "IdRolNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_usuario_rol");

                    b.Navigation("IdRolNavigation");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.Donacion", b =>
                {
                    b.Navigation("RecursoDonaciones");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.Proveedor", b =>
                {
                    b.Navigation("Donaciones");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.Recurso", b =>
                {
                    b.Navigation("RecursoDonaciones");

                    b.Navigation("RecursoSolicitudes");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.Rol", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.Solicitud", b =>
                {
                    b.Navigation("RecursoSolicitudes");
                });

            modelBuilder.Entity("SysAcopioDeRL.Entities.TipoRecurso", b =>
                {
                    b.Navigation("Recursos");
                });
#pragma warning restore 612, 618
        }
    }
}
