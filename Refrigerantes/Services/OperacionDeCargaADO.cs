using Refrigerantes.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refrigerantes.Model;
using Refrigerantes.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Refrigerantes.Services
{
    public class OperacionDeCargaADO : IDisposable, IOperacionDeCargaADO
    {
        bool disposed;
        public OperacionDeCargaADO()
        {
            disposed = false;
        }

        public List<OperacionDeCargaDTO> ListarOperaciones()
        {
            using (var context = new RefrigerantesContext())
            {
                // Mapear manualmente los datos de la entidad al DTO
                var listaOperaciones = context.OperacionCargas
                    .Select(operacion => new OperacionDeCargaDTO
                    {
                        OperacionCargaId_DTO = operacion.OperacionCargaId,
                        OperarioId_DTO = operacion.OperarioId,
                        EquipoId_DTO = operacion.EquipoId,
                        FechaOperacion_DTO = operacion.FechaOperacion,
                        Descripcion_DTO = operacion.Descripcion,
                        RefrigeranteManipulado_DTO = operacion.RefrigeranteManipulado,
                        Recuperacion_DTO = operacion.Recuperacion,
                        Equipo_DTO = operacion.Equipo,
                        Operario_DTO = operacion.Operario,

                    }).ToList();

                return listaOperaciones;
            }
        }

        public List<OperacionDeCargaDTO> ListarOperacionesPorInstalacion(int idInstalacion)
        {
            using (var context = new RefrigerantesContext())
            {
                // Mapear manualmente los datos de la entidad al DTO
                var listaOperaciones = context.OperacionCargas
                    .Select(operacion => new OperacionDeCargaDTO
                    {
                        OperacionCargaId_DTO = operacion.OperacionCargaId,
                        OperarioId_DTO = operacion.OperarioId,
                        EquipoId_DTO = operacion.EquipoId,
                        FechaOperacion_DTO = operacion.FechaOperacion,
                        Descripcion_DTO = operacion.Descripcion,
                        RefrigeranteManipulado_DTO = operacion.RefrigeranteManipulado,
                        Recuperacion_DTO = operacion.Recuperacion,

                    }).ToList();

                return listaOperaciones;
            }
        }


        public List<OperacionDeCargaDTO> ListarOperacionesOperarioEquipo()
        {
            using (var context = new RefrigerantesContext())
            {
                // Mapear manualmente los datos de la entidad al DTO
                var listaOperaciones = context.OperacionCargas
                    .Select(operacion => new OperacionDeCargaDTO
                    {
                        OperacionCargaId_DTO = operacion.OperacionCargaId,
                        OperarioId_DTO = operacion.OperarioId,
                        EquipoId_DTO = operacion.EquipoId,
                        FechaOperacion_DTO = operacion.FechaOperacion,
                        Descripcion_DTO = operacion.Descripcion,
                        RefrigeranteManipulado_DTO = operacion.RefrigeranteManipulado,
                        Recuperacion_DTO = operacion.Recuperacion,
                        Operario_DTO = operacion.Operario,
                        Equipo_DTO = operacion.Equipo,

                    }).ToList();

                return listaOperaciones;
            }
        }

        public OperacionDeCargaDTO OperacionPorId(int id)
        {
            using (var context = new RefrigerantesContext())
            {
                var operacion = context.OperacionCargas.FirstOrDefault(o => o.OperacionCargaId == id);

                return new OperacionDeCargaDTO
                {
                    OperacionCargaId_DTO = operacion.OperacionCargaId,
                    OperarioId_DTO = operacion.OperarioId,
                    EquipoId_DTO = operacion.EquipoId,
                    FechaOperacion_DTO = operacion.FechaOperacion,
                    Descripcion_DTO = operacion.Descripcion,
                    RefrigeranteManipulado_DTO = operacion.RefrigeranteManipulado,
                    Recuperacion_DTO = operacion.Recuperacion,
                    Equipo_DTO = operacion.Equipo,
                    Operario_DTO = operacion.Operario,
                };

            }
        }

        public void InsertarOperacionDeCargaADO(OperacionDeCargaDTO operacion)
        {
            using (var context = new RefrigerantesContext())
            {
                context.Entry(operacion.ToModel()).State = EntityState.Added;
                context.SaveChanges();
            }
                
        }

        public void ActualizarOperacionDeCargaADO(OperacionDeCargaDTO operacion)
        {
            using (var context = new RefrigerantesContext())
            {
                context.Entry(operacion.ToModel()).State = EntityState.Modified;
                context.SaveChanges();
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
