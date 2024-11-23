using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Refrigerantes.Model;

[Table("Categoria_profesional")]
public partial class CategoriaProfesional : IDisposable
{
    [Key]
    [Column("categoria_profesional_id")]
    public int CategoriaProfesionalId { get; set; }

    [Column("categoria_profesional")]
    [StringLength(50)]
    public string CategoriaProfesional1 { get; set; } = null!;

    [InverseProperty("CategoriaProfesional")]
    public virtual ICollection<Operario> Operarios { get; set; } = new List<Operario>();

    bool disposed;

    public CategoriaProfesional()
    {
        disposed = false;
    }

    //Constructor con todos los parámetros.
    public CategoriaProfesional(int categoriaProfesionalId, string categoriaProfesional1, ICollection<Operario> operarios)
    {
        CategoriaProfesionalId = categoriaProfesionalId;
        CategoriaProfesional1 = categoriaProfesional1;
        Operarios = operarios;
    }


    //Constructor únicamente con los parámetros que sean obligatorios. (aquellos que sean
    //not null en la bd) 
    public CategoriaProfesional(int categoriaProfesionalId, string categoriaProfesional1)
    {
        CategoriaProfesionalId = categoriaProfesionalId;
        CategoriaProfesional1 = categoriaProfesional1;
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
