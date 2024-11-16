using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Refrigerantes.Model;

[Table("Refrigerante")]
public partial class Refrigerante
{
    [Key]
    [Column("refrigerante_id")]
    public int RefrigeranteId { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [Column("CO2eq", TypeName = "decimal(10, 2)")]
    public decimal Co2eq { get; set; }

    [Column("clase")]
    [StringLength(50)]
    public string Clase { get; set; } = null!;

    [Column("grupo")]
    [StringLength(50)]
    public string Grupo { get; set; } = null!;

    [InverseProperty("Refrigerante")]
    public virtual ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();
}
