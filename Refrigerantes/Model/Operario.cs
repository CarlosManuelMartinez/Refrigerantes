using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Refrigerantes.Model;

[Table("Operario")]
[Index("Dni", Name = "UQ_Operario_DNI", IsUnique = true)]
public partial class Operario : IDisposable
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
    [StringLength(64)]
    public string Password { get; set; } = null!;

    [Column("categoria_profesional_id")]
    public int CategoriaProfesionalId { get; set; }

    [ForeignKey("CategoriaProfesionalId")]
    [InverseProperty("Operarios")]
    public virtual CategoriaProfesional CategoriaProfesional { get; set; } = null!;

    [InverseProperty("Operario")]
    public virtual ICollection<OperacionCarga> OperacionCargas { get; set; } = new List<OperacionCarga>();
    bool disposed;

    public Operario()
    {
        disposed = false;
    }

    public Operario(int operarioId, string dni, string nombre,
        string apellido1, string? apellido2, string email,
        string password, int categoriaProfesionalId,
        CategoriaProfesional categoriaProfesional, 
        ICollection<OperacionCarga> operacionCargas)
    {
        OperarioId = operarioId;
        Dni = dni;
        Nombre = nombre;
        Apellido1 = apellido1;
        Apellido2 = apellido2;
        Email = email;
        Password = password;
        CategoriaProfesionalId = categoriaProfesionalId;
        CategoriaProfesional = categoriaProfesional;
        OperacionCargas = operacionCargas;
    }

    public Operario(int operarioId, string dni, string nombre,
       string apellido1, string? apellido2, string email,
       string password, int categoriaProfesionalId)
    {
        OperarioId = operarioId;
        Dni = dni;
        Nombre = nombre;
        Apellido1 = apellido1;
        Apellido2 = apellido2;
        Email = email;
        Password = password;
        CategoriaProfesionalId = categoriaProfesionalId;
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
