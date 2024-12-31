using Refrigerantes.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Refrigerantes.Model;
using Refrigerantes.Services.Interfaces;

namespace Refrigerantes.Services
{
    public class OperarioADO :IDisposable, IOperarioADO
    {
        bool disposed;
        public OperarioADO() 
        {
            disposed = false;
        }

        public List<OperarioDTO> ListarOperariosADO()
        {
            using (var context = new RefrigerantesContext())
            {
                // Mapear manualmente los datos de la entidad al DTO
                var listaOperarios = context.Operarios
                    .Select(o => new OperarioDTO
                    {
                        OperarioId_DTO = o.OperarioId,
                        Dni_DTO = o.Dni,
                        Nombre_DTO = o.Nombre,
                        Apellido1_DTO = o.Apellido1,
                        Apellido2_DTO = o.Apellido2,
                        Email_DTO= o.Email,
                        Password_DTO = o.Password,
                        CategoriaProfesionalId_DTO = o.CategoriaProfesionalId
                    }).ToList() ;
                   
                return listaOperarios;
            }
        }

        public OperarioDTO OperarioPorIdADO(int id)
        {
            using (var context = new RefrigerantesContext())
            {
                var operario = context.Operarios.FirstOrDefault(o => o.OperarioId == id);

                return new OperarioDTO
                {
                    OperarioId_DTO = operario.OperarioId,
                    Dni_DTO = operario.Dni,
                    Apellido1_DTO = operario.Apellido1,
                    Apellido2_DTO = operario.Apellido2,
                    Email_DTO = operario.Email,
                    Password_DTO = operario.Password,
                    CategoriaProfesionalId_DTO = operario.CategoriaProfesionalId
                };
            }
        }

        public OperarioDTO OperarioPorEmailADO(string email)
        {
            using (var context = new RefrigerantesContext())
            {
                var operario = context.Operarios.FirstOrDefault(o => o.Email == email);

                return new OperarioDTO
                {
                    OperarioId_DTO = operario.OperarioId,
                    Dni_DTO = operario.Dni,
                    Apellido1_DTO = operario.Apellido1,
                    Apellido2_DTO = operario.Apellido2,
                    Email_DTO = operario.Email,
                    Password_DTO = operario.Password,
                    CategoriaProfesionalId_DTO = operario.CategoriaProfesionalId
                };

            }
        }

        public void InsertarOperarioADO(OperarioDTO operarioDTO)
        {
            using (var context = new RefrigerantesContext())
            {
                context.Entry(operarioDTO).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void ActualizarOperarioADO(OperarioDTO operarioDTO)
        {
            using (var context =  new RefrigerantesContext())
            {
                context.Entry(operarioDTO).State = EntityState.Modified;
                context.SaveChanges();
            }

        }

        public void BorrarOperarioADO(int id)
        {
            
            using (var context = new RefrigerantesContext())
            {
                var operarioABorrar = context.Operarios.FirstOrDefault(x => x.OperarioId == id);
                context.Operarios.Remove(operarioABorrar);
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
