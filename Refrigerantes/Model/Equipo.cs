using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Refrigerantes.Model;

[Table("Equipo")]
public partial class Equipo
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
}
