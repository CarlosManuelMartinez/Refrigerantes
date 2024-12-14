using Azure;
using Refrigerantes.Model;
using Refrigerantes.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refrigerantes.Services.Interfaces;

namespace Refrigerantes.Services
{
    public class CategoriaProfesionalADO : IDisposable, ICategoriaProfesionalADO
    {
        bool disposed;
        public CategoriaProfesionalADO()
        {
            disposed = false;
        }

        public List<CategoriaProfesionalDTO> ListarCategoriasProfesionales()
        {
            using (var context = new RefrigerantesContext())
            {
                // Mapear manualmente los datos de la entidad al DTO
                var listaCategorias = context.CategoriaProfesionals
                    .Select(cat => new CategoriaProfesionalDTO
                    {
                        CategoriaProfesionalId = cat.CategoriaProfesionalId,
                        CategoriaProfesional1 = cat.CategoriaProfesional1,
                        Operarios = cat.Operarios.ToList(),
                    }
                    ).ToList();

                return listaCategorias;
            }
        }

        public CategoriaProfesionalDTO CategoriasProfesionalesPorId(int id)
        {
            using (var context = new RefrigerantesContext())
            {
                var categoria = context.CategoriaProfesionals.FirstOrDefault(cat => cat.CategoriaProfesionalId == id);

                return new CategoriaProfesionalDTO
                {
                    CategoriaProfesionalId = categoria.CategoriaProfesionalId,
                    CategoriaProfesional1 = categoria.CategoriaProfesional1,
                    Operarios = categoria.Operarios.ToList(),
                };

            }
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

            }

            disposed = true;
        }
    }
}
