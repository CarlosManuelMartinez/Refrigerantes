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
    internal class RefrigeranteADO : IDisposable, IRefrigeranteADO
    {
        bool disposed;
        public RefrigeranteADO()
        {
            disposed = false;
        }

        public List<RefrigeranteDTO> ListarRefrigerantes()
        {
            using (var context = new RefrigerantesContext())
            {
                // Mapear manualmente los datos de la entidad al DTO
                var data = context.Refrigerantes
                    .Select(r => new RefrigeranteDTO
                    {
                        RefrigeranteId_DTO = r.RefrigeranteId,
                        Nombre_DTO = r.Nombre,
                        Co2eq_DTO = r.Co2eq,
                        Clase_DTO = r.Clase,
                        Grupo_DTO = r.Grupo,
                    })
                    .ToList();
                return data;
            }
        }

        public RefrigeranteDTO RefrigerantePorId(int id)
        {
            using (var context = new RefrigerantesContext())
            {
                var refrigerante = context.Refrigerantes.FirstOrDefault(r => r.RefrigeranteId == id);

                return new RefrigeranteDTO
                {
                    RefrigeranteId_DTO = refrigerante.RefrigeranteId,
                    Nombre_DTO = refrigerante.Nombre,
                    Co2eq_DTO = refrigerante.Co2eq,
                    Clase_DTO = refrigerante.Clase,
                    Grupo_DTO = refrigerante.Grupo,
                };

            }
        }

        public void InsertarRefrigeranteADO(RefrigeranteDTO refrigerante)
        {
            using (var context = new RefrigerantesContext())
            {
                context.Refrigerantes.Entry(refrigerante.ToModel()).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void ActualizarRefrigeranteADO(RefrigeranteDTO refrigerante)
        {
            using (var context = new RefrigerantesContext())
            {
                context.Refrigerantes.Entry(refrigerante.ToModel()).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void BorrarRefrigeranteADO(int id)
        {

            using (var context = new RefrigerantesContext())
            {
                var refrigeranteABorrar = context.Refrigerantes.FirstOrDefault(x => x.RefrigeranteId == id);
                context.Refrigerantes.Remove(refrigeranteABorrar);
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
