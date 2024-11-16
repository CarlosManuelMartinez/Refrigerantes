using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Refrigerantes.Model;

public partial class RefrigerantesContext : DbContext
{
    public RefrigerantesContext()
    {
    }

    public RefrigerantesContext(DbContextOptions<RefrigerantesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CategoriaProfesional> CategoriaProfesionals { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Equipo> Equipos { get; set; }

    public virtual DbSet<Instalacion> Instalacions { get; set; }

    public virtual DbSet<OperacionCarga> OperacionCargas { get; set; }

    public virtual DbSet<Operario> Operarios { get; set; }

    public virtual DbSet<Refrigerante> Refrigerantes { get; set; }

    public virtual DbSet<TipoEquipo> TipoEquipos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Refrigerantes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoriaProfesional>(entity =>
        {
            entity.HasKey(e => e.CategoriaProfesionalId).HasName("PK__Categori__3E3DCBF2EA0C0A6F");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK__Cliente__47E34D640E3EDFED");
        });

        modelBuilder.Entity<Equipo>(entity =>
        {
            entity.HasKey(e => e.EquipoId).HasName("PK__Equipo__50EAD2BF256E4242");

            entity.HasOne(d => d.Instalacion).WithMany(p => p.Equipos).HasConstraintName("FK_Equipo_Instalacion");

            entity.HasOne(d => d.Refrigerante).WithMany(p => p.Equipos).HasConstraintName("FK_Equipo_Refrigerante");

            entity.HasOne(d => d.TipoEquipo).WithMany(p => p.Equipos).HasConstraintName("FK_Equipo_Tipo_equipo");
        });

        modelBuilder.Entity<Instalacion>(entity =>
        {
            entity.HasKey(e => e.InstalacionId).HasName("PK__Instalac__14A69352DC171AF9");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Instalacions).HasConstraintName("FK_Instalacion_Cliente");
        });

        modelBuilder.Entity<OperacionCarga>(entity =>
        {
            entity.HasKey(e => e.OperacionCargaId).HasName("PK__Operacio__02E46A5F48232BA9");

            entity.HasOne(d => d.Equipo).WithMany(p => p.OperacionCargas).HasConstraintName("FK_Operacion_carga_Equipo");

            entity.HasOne(d => d.Operario).WithMany(p => p.OperacionCargas).HasConstraintName("FK_Operacion_carga_Operario");
        });

        modelBuilder.Entity<Operario>(entity =>
        {
            entity.HasKey(e => e.OperarioId).HasName("PK__Operario__D18AFCF87B665E8E");

            entity.HasOne(d => d.CategoriaProfesional).WithMany(p => p.Operarios).HasConstraintName("FK_Operario_Categoria_profesional");
        });

        modelBuilder.Entity<Refrigerante>(entity =>
        {
            entity.HasKey(e => e.RefrigeranteId).HasName("PK__Refriger__E217A3A759ACF9C9");
        });

        modelBuilder.Entity<TipoEquipo>(entity =>
        {
            entity.HasKey(e => e.TipoEquipoId).HasName("PK__Tipo_equ__037D0FEC1964FC6C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
