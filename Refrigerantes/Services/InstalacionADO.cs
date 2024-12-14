using Refrigerantes.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refrigerantes.Model;
using Refrigerantes.Services.Interfaces;

namespace Refrigerantes.Services
{
    public class InstalacionADO : IDisposable, IInstalacionADO
    {
        bool disposed;
        public InstalacionADO()
        {
            disposed = false;
        }


        public List<InstalacionDTO> ListarInstalaciones()
        {
            using (var context = new RefrigerantesContext())
            {
                // Mapear manualmente los datos de la entidad al DTO
                var listaInstalaciones = context.Instalacions
                    .Select(instalacion => new InstalacionDTO
                    {
                        InstalacionId_DTO = instalacion.InstalacionId,
                        ClienteId_DTO = instalacion.ClienteId,
                        Nombre_DTO = instalacion.Nombre,
                        Direccion_DTO = instalacion.Direccion,
                        Horario_DTO = instalacion.Horario,
                        Cliente_DTO = instalacion.Cliente,

                    }).ToList();

                return listaInstalaciones;
            }
        }

        public InstalacionDTO InstalacionPorId(int id)
        {
            using (var context = new RefrigerantesContext())
            {
                var instalacion = context.Instalacions.FirstOrDefault(instalacion => instalacion.InstalacionId == id);

                return new InstalacionDTO
                {
                    InstalacionId_DTO = instalacion.InstalacionId,
                    ClienteId_DTO = instalacion.ClienteId,
                    Nombre_DTO = instalacion.Nombre,
                    Direccion_DTO = instalacion.Direccion,
                    Horario_DTO = instalacion.Horario,
                    Cliente_DTO = instalacion.Cliente,

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
