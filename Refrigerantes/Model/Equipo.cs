using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Refrigerantes.Model;

[Table("Equipo")]
public partial class Equipo : IDisposable
{
    [Key]
    [Column("equipo_id")]
    public int EquipoId { get; set; }

    [Column("instalacion_id")]
    public int InstalacionId { get; set; }

    [Column("refrigerante_id")]
    public int RefrigeranteId { get; set; }

    [Column("tipo_equipo_id")]
    public int TipoEquipoId { get; set; }

    [Column("marca")]
    [StringLength(100)]
    public string Marca { get; set; } = null!;

    [Column("modelo")]
    [StringLength(200)]
    public string Modelo { get; set; } = null!;

    [Column("carga_refrigerante", TypeName = "decimal(5, 3)")]
    public decimal CargaRefrigerante { get; set; }

    [ForeignKey("InstalacionId")]
    [InverseProperty("Equipos")]
    public virtual Instalacion Instalacion { get; set; } = null!;

    [InverseProperty("Equipo")]
    public virtual ICollection<OperacionCarga> OperacionCargas { get; set; } = new List<OperacionCarga>();

    [ForeignKey("RefrigeranteId")]
    [InverseProperty("Equipos")]
    public virtual Refrigerante Refrigerante { get; set; } = null!;

    [ForeignKey("TipoEquipoId")]
    [InverseProperty("Equipos")]
    public virtual TipoEquipo TipoEquipo { get; set; } = null!;

    bool disposed;

    public Equipo()
    {
        disposed = false;
    }

    public Equipo(int equipoId, int instalacionId, int refrigeranteId,
        int tipoEquipoId, string marca, string modelo,
        decimal cargaRefrigerante, Instalacion instalacion,
        ICollection<OperacionCarga> operacionCargas, Refrigerante refrigerante,
        TipoEquipo tipoEquipo)
    {
        EquipoId = equipoId;
        InstalacionId = instalacionId;
        RefrigeranteId = refrigeranteId;
        TipoEquipoId = tipoEquipoId;
        Marca = marca;
        Modelo = modelo;
        CargaRefrigerante = cargaRefrigerante;
        Instalacion = instalacion;
        OperacionCargas = operacionCargas;
        Refrigerante = refrigerante;
        TipoEquipo = tipoEquipo;
    }

    public Equipo(int equipoId, int instalacionId, int refrigeranteId,
       int tipoEquipoId, string marca, string modelo,
       decimal cargaRefrigerante)
    {
        EquipoId = equipoId;
        InstalacionId = instalacionId;
        RefrigeranteId = refrigeranteId;
        TipoEquipoId = tipoEquipoId;
        Marca = marca;
        Modelo = modelo;
        CargaRefrigerante = cargaRefrigerante;
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    // Protected implementation of Dispose pattern.
    protected virtual void Dispose(bool disposing)
    {
        if (disposed)
            return;

        if (disposing)
        {
            // Free any other managed objects here.
            //Liberar recursos no manejados como ficheros, conexiones a bd, etc.
        }

        disposed = true;
    }
}
