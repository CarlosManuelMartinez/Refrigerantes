﻿using Refrigerantes.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refrigerantes.Model;
using Refrigerantes.Services.Interfaces;
namespace Refrigerantes.Services
{
    public class ClienteADO : IDisposable, IClienteADO
    {
        bool disposed;
        public ClienteADO()
        {
            disposed = false;
        }

        public List<ClienteDTO> ListarClientes()
        {
            using (var context = new RefrigerantesContext())
            {
                // Mapear manualmente los datos de la entidad al DTO
                var listaClientes = context.Clientes
                    .Select(cli => new ClienteDTO
                    {
                        ClienteIdDTO = cli.ClienteId,
                        CifDTO = cli.Cif,
                        NombreDTO = cli.Nombre,
                        DireccionFacturacionDTO = cli.DireccionFacturacion,
                        InstalacionsDTO = cli.Instalacions.ToList(),
                    }).ToList();

                return listaClientes;
            }
        }

        public ClienteDTO ClientePorId(int id)
        {
            using (var context = new RefrigerantesContext())
            {
                var cliente = context.Clientes.FirstOrDefault(cli
                    => cli.ClienteId == id);

                return new ClienteDTO
                {
                    ClienteIdDTO = cliente.ClienteId,
                    CifDTO = cliente.Cif,
                    NombreDTO = cliente.Nombre,
                    DireccionFacturacionDTO = cliente.DireccionFacturacion,
                    InstalacionsDTO = cliente.Instalacions.ToList(),
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
