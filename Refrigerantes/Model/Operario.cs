using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Refrigerantes.Model;

[Table("Operario")]
[Index("Dni", Name = "UQ_Operario_DNI", IsUnique = true)]
public partial class Operario
{
    [Key]
    [Column("operario_id")]
    public int OperarioId { get; set; }

    [Column("dni")]
    [StringLength(15)]
    public string Dni { get; set; } = null!;

    [Column("nombre")]
    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [Column("apellido1")]
    [StringLength(100)]
    public string Apellido1 { get; set; } = null!;

    [Column("apellido2")]
    [StringLength(100)]
    public string? Apellido2 { get; set; }

    [Column("email")]
    [StringLength(50)]
    public string Email { get; set; } = null!;

    [Column("password")]
    [StringLength(50)]
    public string Password { get; set; } = null!;

    [Column("categoria_profesional_id")]
    public int CategoriaProfesionalId { get; set; }

    [ForeignKey("CategoriaProfesionalId")]
    [InverseProperty("Operarios")]
    public virtual CategoriaProfesional CategoriaProfesional { get; set; } = null!;

    [InverseProperty("Operario")]
    public virtual ICollection<OperacionCarga> OperacionCargas { get; set; } = new List<OperacionCarga>();
}
