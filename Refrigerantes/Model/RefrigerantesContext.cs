﻿using System;
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

        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Refrigerantes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoriaProfesional>(entity =>
        {
            entity.HasKey(e => e.CategoriaProfesionalId).HasName("PK__Categori__3E3DCBF2E9167CB7");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK__Cliente__47E34D64B62A740F");
        });

        modelBuilder.Entity<Equipo>(entity =>
        {
            entity.HasKey(e => e.EquipoId).HasName("PK__Equipo__50EAD2BF5449E6DF");

            entity.HasOne(d => d.Instalacion).WithMany(p => p.Equipos).HasConstraintName("FK_Equipo_Instalacion");

            entity.HasOne(d => d.Refrigerante).WithMany(p => p.Equipos).HasConstraintName("FK_Equipo_Refrigerante");

            entity.HasOne(d => d.TipoEquipo).WithMany(p => p.Equipos).HasConstraintName("FK_Equipo_Tipo_equipo");
        });

        modelBuilder.Entity<Instalacion>(entity =>
        {
            entity.HasKey(e => e.InstalacionId).HasName("PK__Instalac__14A693527C0B3269");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Instalacions).HasConstraintName("FK_Instalacion_Cliente");
        });

        modelBuilder.Entity<OperacionCarga>(entity =>
        {
            entity.HasKey(e => e.OperacionCargaId).HasName("PK__Operacio__02E46A5F185156AC");

            entity.HasOne(d => d.Equipo).WithMany(p => p.OperacionCargas).HasConstraintName("FK_Operacion_carga_Equipo");

            entity.HasOne(d => d.Operario).WithMany(p => p.OperacionCargas).HasConstraintName("FK_Operacion_carga_Operario");
        });

        modelBuilder.Entity<Operario>(entity =>
        {
            entity.HasKey(e => e.OperarioId).HasName("PK__Operario__D18AFCF8761D5AE3");

            entity.HasOne(d => d.CategoriaProfesional).WithMany(p => p.Operarios).HasConstraintName("FK_Operario_Categoria_profesional");
        });

        modelBuilder.Entity<Refrigerante>(entity =>
        {
            entity.HasKey(e => e.RefrigeranteId).HasName("PK__Refriger__E217A3A75A62F7D6");
        });

        modelBuilder.Entity<TipoEquipo>(entity =>
        {
            entity.HasKey(e => e.TipoEquipoId).HasName("PK__Tipo_equ__037D0FEC3E596709");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
