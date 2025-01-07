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
    public class InstalacionDTO
    {
        public int InstalacionId_DTO { get; set; }

        public int ClienteId_DTO { get; set; }

        public string Nombre_DTO { get; set; } = null!;
        public string NombreCliente_DTO { get; set; }

        public string Direccion_DTO { get; set; } = null!;

        public string Horario_DTO { get; set; } = null!;

        public Cliente Cliente_DTO { get; set; } = null!;
        public List<EquipoDTO> Equipos_DTO { get; set; } = new List<EquipoDTO>();

        public InstalacionDTO() { }

        public InstalacionDTO(int instalacionId_DTO, int clienteId_DTO, string nombre_DTO, string direccion_DTO, string horario_DTO, Cliente cliente_DTO, List<EquipoDTO> equipos_DTO)
        {

            InstalacionId_DTO = instalacionId_DTO;
            ClienteId_DTO = clienteId_DTO;
            Nombre_DTO = nombre_DTO;
            NombreCliente_DTO = cliente_DTO.Nombre;
            Direccion_DTO = direccion_DTO;
            Horario_DTO = horario_DTO;
            Cliente_DTO = cliente_DTO;
            Equipos_DTO = equipos_DTO;
        }

    }

}
