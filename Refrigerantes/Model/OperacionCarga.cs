﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Refrigerantes.Model;

[Table("Operacion_carga")]
public partial class OperacionCarga
{
    [Key]
    [Column("operacion_carga_id")]
    public int OperacionCargaId { get; set; }

    [Column("operario_id")]
    public int OperarioId { get; set; }

    [Column("equipo_id")]
    public int EquipoId { get; set; }

    [Column("fecha_operacion")]
    public DateTime FechaOperacion { get; set; }

    [Column("descripcion")]
    [StringLength(500)]
    public string Descripcion { get; set; } = null!;

    [Column("refrigerante_manipulado", TypeName = "decimal(5, 3)")]
    public decimal RefrigeranteManipulado { get; set; }

    [Column("recuperacion")]
    public bool Recuperacion { get; set; }

    [ForeignKey("EquipoId")]
    [InverseProperty("OperacionCargas")]
    public virtual Equipo Equipo { get; set; } = null!;

    [ForeignKey("OperarioId")]
    [InverseProperty("OperacionCargas")]
    public virtual Operario Operario { get; set; } = null!;
}
