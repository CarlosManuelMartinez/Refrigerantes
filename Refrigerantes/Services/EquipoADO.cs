using Refrigerantes.Model;
using Refrigerantes.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Refrigerantes.Services
{
    public class EquipoADO : IDisposable
    {
        bool disposed;
        public EquipoADO()
        {
            disposed = false;
        }

        public List<EquipoDTO> ListarEquipos()
        {
            using (var context = new RefrigerantesContext())
            {
                // Mapear manualmente los datos de la entidad al DTO
                var listaOperarios = context.Equipos
                .Select(equipo => new EquipoDTO
                {
                    EquipoId = equipo.EquipoId,
                    InstalacionId = equipo.InstalacionId,
                    RefrigeranteId = equipo.RefrigeranteId,
                    TipoEquipoId = equipo.TipoEquipoId,
                    Marca = equipo.Marca,
                    Modelo = equipo.Modelo,
                    CargaRefrigerante = equipo.CargaRefrigerante,
                    Instalacion = equipo.Instalacion,
                    OperacionCargas = equipo.OperacionCargas.ToList(),
                    Refrigerante = equipo.Refrigerante,
                    TipoEquipo = equipo.TipoEquipo,
            }).ToList();

                return listaOperarios;
            }
        }

        public EquipoDTO EquipoPorId(int id)
        {
            using (var context = new RefrigerantesContext())
            {
                var equipo = context.Equipos.FirstOrDefault(eq => eq.EquipoId == id);

                return new EquipoDTO
                {
                    EquipoId = equipo.EquipoId,
                    InstalacionId = equipo.InstalacionId,
                    RefrigeranteId = equipo.RefrigeranteId,
                    TipoEquipoId = equipo.TipoEquipoId,
                    Marca = equipo.Marca,
                    Modelo = equipo.Modelo,
                    CargaRefrigerante = equipo.CargaRefrigerante,
                    Instalacion = equipo.Instalacion,
                    OperacionCargas = equipo.OperacionCargas.ToList(),
                    Refrigerante = equipo.Refrigerante,
                    TipoEquipo = equipo.TipoEquipo,
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
