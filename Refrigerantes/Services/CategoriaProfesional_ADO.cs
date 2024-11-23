using Azure;
using Refrigerantes.Model;
using Refrigerantes.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerantes.Services
{
    public class CategoriaProfesional_ADO : IDisposable
    {
        bool disposed;
        public CategoriaProfesional_ADO()
        {
            disposed = false;
        }

        public List<CategoriaProfesional_DTO> ListarCategoriasProfesionales()
        {
            using (var context = new RefrigerantesContext())
            {
                // Mapear manualmente los datos de la entidad al DTO
                var listaCategorias = context.CategoriaProfesionals
                    .Select(cat => new CategoriaProfesional_DTO
                    {
                        CategoriaProfesionalId = cat.CategoriaProfesionalId,
                        CategoriaProfesional1 = cat.CategoriaProfesional1,
                        Operarios = cat.Operarios.ToList(),
                    }
                    ).ToList();

                return listaCategorias;
            }
        }

        public CategoriaProfesional_DTO CategoriasProfesionalesPorId(int id)
        {
            using (var context = new RefrigerantesContext())
            {
                var categoria = context.CategoriaProfesionals.FirstOrDefault(cat => cat.CategoriaProfesionalId == id);

                return new CategoriaProfesional_DTO
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
