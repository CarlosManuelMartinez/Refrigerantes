using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Refrigerantes.Model;

[Table("Instalacion")]
public partial class Instalacion : IDisposable
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

    bool disposed;

    public Instalacion()
    {
        disposed = true;
    }


    public Instalacion(int instalacionId, int clienteId, string nombre, string direccion, string horario, Cliente cliente, ICollection<Equipo> equipos)
    {
        InstalacionId = instalacionId;
        ClienteId = clienteId;
        Nombre = nombre;
        Direccion = direccion;
        Horario = horario;
        Cliente = cliente;
        Equipos = equipos;
    }

    public Instalacion(int instalacionId, int clienteId, string nombre, string direccion, string horario)
    {
        InstalacionId = instalacionId;
        ClienteId = clienteId;
        Nombre = nombre;
        Direccion = direccion;
        Horario = horario;
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
