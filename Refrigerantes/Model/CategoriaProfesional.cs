using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Refrigerantes.Model;

[Table("Categoria_profesional")]
public partial class CategoriaProfesional
{
    [Key]
    [Column("categoria_profesional_id")]
    public int CategoriaProfesionalId { get; set; }

    [Column("categoria_profesional")]
    [StringLength(50)]
    public string CategoriaProfesional1 { get; set; } = null!;

    [InverseProperty("CategoriaProfesional")]
    public virtual ICollection<Operario> Operarios { get; set; } = new List<Operario>();
}
