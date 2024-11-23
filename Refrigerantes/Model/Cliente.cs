using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Refrigerantes.Model;

[Table("Cliente")]
public partial class Cliente : IDisposable
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

    [InverseProperty("Cliente")]
    public virtual ICollection<Instalacion> Instalacions { get; set; } = new List<Instalacion>();

    bool disposed;
    public Cliente()
    { 
        disposed = false;
    }

    public Cliente(int clienteId, string cif, string nombre, string direccionFacturacion, ICollection<Instalacion> instalacions) 
    {
        ClienteId = clienteId;
        Cif = cif;
        Nombre = nombre;
        DireccionFacturacion = direccionFacturacion;
        Instalacions = instalacions;
    }

    public Cliente(int clienteId, string cif, string nombre, string direccionFacturacion)
    {
        ClienteId = clienteId;
        Cif = cif;
        Nombre = nombre;
        DireccionFacturacion = direccionFacturacion;
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
