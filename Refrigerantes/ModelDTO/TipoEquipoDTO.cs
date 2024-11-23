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
    public class TipoEquipoDTO
    {
        public int TipoEquipoId_DTO { get; set; }
        
        public string TipoEquipo1_DTO { get; set; } 
        

        public TipoEquipoDTO() { }

        public TipoEquipoDTO(int tipoEquipoId_DTO,string tipoEquipo1_DTO, List<Equipo> equipos_DTO) 
        { 
            TipoEquipoId_DTO = tipoEquipoId_DTO;
            TipoEquipo1_DTO = tipoEquipo1_DTO;
        }

        public override string ToString()
        {
            return "ID: "+this.TipoEquipoId_DTO + "TIPO EQUIPO: " + this.TipoEquipo1_DTO ;
        }

    }
}
