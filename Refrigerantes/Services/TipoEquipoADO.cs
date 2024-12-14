using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refrigerantes.ModelDTO;
using Refrigerantes.Model;

namespace Refrigerantes.Services
{
    public class TipoEquipoADO : IDisposable
    {
        bool disposed;
        public TipoEquipoADO()
        {
            disposed = false;
        }

        public List<TipoEquipoDTO> ListarTipoEquipo()
        {
            using (var context = new RefrigerantesContext())
            {
                // Mapear manualmente los datos de la entidad al DTO
                var data = context.TipoEquipos
                    .Select(e => new TipoEquipoDTO
                    {
                        TipoEquipoId_DTO = e.TipoEquipoId,
                        TipoEquipo1_DTO = e.TipoEquipo1,
                    })
                    .ToList();
                return data;
            }
        }

        public TipoEquipoDTO TipoEquipoPorId(int id)
        {
            using (var context = new RefrigerantesContext())
            {
                var tipoEquipo = context.TipoEquipos.FirstOrDefault(te=>te.TipoEquipoId==id);
                
                return new TipoEquipoDTO 
                {
                    TipoEquipoId_DTO = tipoEquipo.TipoEquipoId,
                    TipoEquipo1_DTO = tipoEquipo.TipoEquipo1,
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
