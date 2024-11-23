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
    public class Cliente_DTO
    {
        public int ClienteId { get; set; }

        public string Cif { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string DireccionFacturacion { get; set; } = null!;

        public  List<Instalacion> Instalacions { get; set; } = new List<Instalacion>();

        public Cliente_DTO(){}

        public Cliente_DTO(int clienteId, string cif, string nombre, string direccionFacturacion, List<Instalacion> instalacions)
        {
            ClienteId = clienteId;
            Cif = cif;
            Nombre = nombre;
            DireccionFacturacion = direccionFacturacion;
            Instalacions = instalacions;
        }
    }
}
