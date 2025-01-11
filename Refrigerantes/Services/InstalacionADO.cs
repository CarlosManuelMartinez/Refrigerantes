using Refrigerantes.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refrigerantes.Model;
using Refrigerantes.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Security.Permissions;

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
                
                var listaInstalaciones = context.Instalacions
                    .Include(i => i.Equipos)
                    
                    .Select(instalacion => new InstalacionDTO
                    {
                        InstalacionId_DTO = instalacion.InstalacionId,
                        ClienteId_DTO = instalacion.ClienteId,
                        Nombre_DTO = instalacion.Nombre,
                        Direccion_DTO = instalacion.Direccion,
                        Horario_DTO = instalacion.Horario,
                        Cliente_DTO = instalacion.Cliente,
                        Equipos_DTO = instalacion.Equipos.Select
                        (e => new EquipoDTO
                        { 
                            EquipoId = e.EquipoId,
                            InstalacionId = e.InstalacionId,
                            CargaRefrigerante = e.CargaRefrigerante,
                            Refrigerante = e.Refrigerante,
                        }).ToList()

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

        public IEnumerable<object> InstalacionesMasDeNOperacionesADO(int n_Operaciones)
        {
            using (var context = new RefrigerantesContext())
            {
                var query = from ins in context.Instalacions
                            where ins.Equipos.Any(e =>
                                context.OperacionCargas
                                    .Where(op => op.EquipoId == e.EquipoId)
                                    .Count() >= n_Operaciones)
                            select new
                            {
                                InstalacionId = ins.InstalacionId,
                                InstalacionNombre = ins.Nombre,
                                ClienteDTO = ins.Cliente,
                            };

            return  query.ToList();
            }
        }

        public IEnumerable<object> InstalacionesMasEcoADO(int n_Operaciones)
        {
            using (var context = new RefrigerantesContext())
            {
                var query = from ins in context.Instalacions
                            where ins.Equipos.Any(e =>
                                context.OperacionCargas
                                    .Where(op => op.EquipoId == e.EquipoId)
                                    .Count() < n_Operaciones)
                            select new
                            {
                                InstalacionId = ins.InstalacionId,
                                InstalacionNombre = ins.Nombre,
                                Cliente = ins.Cliente,
                            };

                return query.ToList();
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

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
