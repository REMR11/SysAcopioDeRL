using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SysAcopioDeRL.Entities;

public partial class DbacopioDeRlContext : DbContext
{
    public DbacopioDeRlContext()
    {
    }

    public DbacopioDeRlContext(DbContextOptions<DbacopioDeRlContext> options)
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
        //=> optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=DBAcopioDeRL;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        => optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionString"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Donacion>(entity =>
        {
            entity.HasKey(e => e.IdDonacion).HasName("PK__Donacion__931F75CCFCD86B45");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Donaciones).HasConstraintName("fk_donacion_proveedor");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PK__Proveedo__8D3DFE28F64B4E52");
        });

        modelBuilder.Entity<Recurso>(entity =>
        {
            entity.HasKey(e => e.IdRecurso).HasName("PK__Recurso__2B386DE4DE783DB2");

            entity.HasOne(d => d.IdTipoRecursoNavigation).WithMany(p => p.Recursos).HasConstraintName("fk_recurso_tipo_recurso");
        });

        modelBuilder.Entity<RecursoDonacion>(entity =>
        {
            entity.HasKey(e => e.IdRecursoDonacion).HasName("PK__Recurso___9565F4178D8C9919");

            entity.HasOne(d => d.IdDonacionNavigation).WithMany(p => p.RecursoDonaciones).HasConstraintName("fk_recurso_donacion_donacion");

            entity.HasOne(d => d.IdRecursoNavigation).WithMany(p => p.RecursoDonaciones).HasConstraintName("fk_recurso_donacion_recurso");
        });

        modelBuilder.Entity<RecursoSolicitud>(entity =>
        {
            entity.HasKey(e => e.IdRecursoSolicitud).HasName("PK__Recurso___C21795884DFEDF38");

            entity.HasOne(d => d.IdRecursoNavigation).WithMany(p => p.RecursoSolicitudes).HasConstraintName("fk_recurso_solicitud_recurso");

            entity.HasOne(d => d.IdSolicitudNavigation).WithMany(p => p.RecursoSolicitudes).HasConstraintName("fk_recurso_solicitud_solicitud");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__Rol__6ABCB5E0C6FDA965");
        });

        modelBuilder.Entity<Solicitud>(entity =>
        {
            entity.HasKey(e => e.IdSolicitud).HasName("PK__Solicitu__5C0C31F365C21C7F");
        });

        modelBuilder.Entity<TipoRecurso>(entity =>
        {
            entity.HasKey(e => e.IdTipoRecurso).HasName("PK__Tipo_Rec__F8B8B7CE9E933468");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__4E3E04AD9CB6F9C2");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios).HasConstraintName("fk_usuario_rol");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
