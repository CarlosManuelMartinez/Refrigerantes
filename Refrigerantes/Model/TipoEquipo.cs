using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Refrigerantes.Model;

[Table("Tipo_equipo")]
public partial class TipoEquipo
{
    [Key]
    [Column("tipo_equipo_id")]
    public int TipoEquipoId { get; set; }

    [Column("tipo_equipo")]
    [StringLength(50)]
    public string TipoEquipo1 { get; set; } = null!;

    [InverseProperty("TipoEquipo")]
    public virtual ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();

}
