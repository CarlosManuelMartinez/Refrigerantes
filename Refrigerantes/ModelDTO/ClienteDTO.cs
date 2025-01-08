using Refrigerantes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerantes.ModelDTO
{
    public class ClienteDTO
    {
        public int ClienteIdDTO { get; set; }
        public string CifDTO { get; set; } = null!;
        public string NombreDTO { get; set; } = null!;
        public string DireccionFacturacionDTO { get; set; } = null!;
        public string EmailDTO { get; set; } = null!;
        public  List<Instalacion> InstalacionsDTO { get; set; } = new List<Instalacion>();

        public ClienteDTO(){}
        public ClienteDTO(int clienteId, string cif, string nombre, string direccionFacturacion,string email,List<Instalacion> instalacions)
        {
            ClienteIdDTO = clienteId;
            CifDTO = cif;
            NombreDTO = nombre;
            DireccionFacturacionDTO = direccionFacturacion;
            EmailDTO = email;
            InstalacionsDTO = instalacions;
        }
    }
}
