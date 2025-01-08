using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Refrigerantes.Model;

[Table("Cliente")]
public partial class Cliente 
{
    [Key]
    [Column("cliente_id")]
    public int ClienteId { get; set; }

    [Column("cif")]
    [StringLength(15)]
    public string Cif { get; set; } = null!;

    [Column("nombre")]
    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [Column("direccion_facturacion")]
    [StringLength(200)]
    public string DireccionFacturacion { get; set; } = null!;

    [Column("email")]
    [StringLength(200)]
    public string Email { get; set; } = null!;


    [InverseProperty("Cliente")]
    public virtual ICollection<Instalacion> Instalacions { get; set; } = new List<Instalacion>();
    
}
