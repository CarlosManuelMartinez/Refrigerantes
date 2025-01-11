using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Refrigerantes.Model;

[Table("Instalacion")]
public partial class Instalacion
{
    [Key]
    [Column("instalacion_id")]
    public int InstalacionId { get; set; }

    [Column("cliente_id")]
    public int ClienteId { get; set; }

    [Column("nombre")]
    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [Column("direccion")]
    [StringLength(200)]
    public string Direccion { get; set; } = null!;

    [Column("horario")]
    [StringLength(50)]
    public string Horario { get; set; } = null!;

    [ForeignKey("ClienteId")]
    [InverseProperty("Instalacions")]
    public virtual Cliente Cliente { get; set; } = null!;

    [InverseProperty("Instalacion")]
    public virtual ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();

}
