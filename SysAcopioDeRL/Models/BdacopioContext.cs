using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SysAcopioDeRL.Models;

public partial class BdacopioContext : DbContext
{
    public BdacopioContext()
    {
    }

    public BdacopioContext(DbContextOptions<BdacopioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Donacion> Donacions { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<Recurso> Recursos { get; set; }

    public virtual DbSet<RecursoDonacion> RecursoDonacions { get; set; }

    public virtual DbSet<RecursoSolicitud> RecursoSolicituds { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Solicitud> Solicituds { get; set; }

    public virtual DbSet<TipoRecurso> TipoRecursos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Donacion>(entity =>
        {
            entity.HasKey(e => e.IdDonacion).HasName("PK__Donacion__931F75CCDDD0A833");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Donacions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_donacion_proveedor");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PK__Proveedo__8D3DFE28CF840575");
        });

        modelBuilder.Entity<Recurso>(entity =>
        {
            entity.HasKey(e => e.IdRecurso).HasName("PK__Recurso__2B386DE45BD2FD88");

            entity.HasOne(d => d.IdTipoRecursoNavigation).WithMany(p => p.Recursos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_recurso_tipo_recurso");
        });

        modelBuilder.Entity<RecursoDonacion>(entity =>
        {
            entity.HasKey(e => e.IdRecursoDonacion).HasName("PK__Recurso___9565F417A9BF8F31");

            entity.HasOne(d => d.IdDonacionNavigation).WithMany(p => p.RecursoDonacions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_recurso_donacion_donacion");

            entity.HasOne(d => d.IdRecursoNavigation).WithMany(p => p.RecursoDonacions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_recurso_donacion_recurso");
        });

        modelBuilder.Entity<RecursoSolicitud>(entity =>
        {
            entity.HasKey(e => e.IdRecursoSolicitud).HasName("PK__Recurso___C2179588D7D7B033");

            entity.HasOne(d => d.IdRecursoNavigation).WithMany(p => p.RecursoSolicituds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_recurso_solicitud_recurso");

            entity.HasOne(d => d.IdSolicitudNavigation).WithMany(p => p.RecursoSolicituds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_recurso_solicitud_solicitud");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__Rol__6ABCB5E0CCE9ACA5");
        });

        modelBuilder.Entity<Solicitud>(entity =>
        {
            entity.HasKey(e => e.IdSolicitud).HasName("PK__Solicitu__5C0C31F3792886AB");
        });

        modelBuilder.Entity<TipoRecurso>(entity =>
        {
            entity.HasKey(e => e.IdTipoRecurso).HasName("PK__Tipo_Rec__F8B8B7CEE9036459");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__4E3E04ADBE5F6E6F");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuario_rol");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
