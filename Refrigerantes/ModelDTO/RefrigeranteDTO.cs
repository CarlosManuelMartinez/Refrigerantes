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
    public class RefrigeranteDTO
    {
        public int RefrigeranteId_DTO { get; set; }

        public string Nombre_DTO { get; set; } = null!;

        public decimal Co2eq_DTO { get; set; }

        public string Clase_DTO { get; set; } = null!;

        public string Grupo_DTO { get; set; } = null!;

        public RefrigeranteDTO() { }

        public RefrigeranteDTO(int refrigeranteId, string nombre, decimal co2eq, string clase, string grupo)
        {
            RefrigeranteId_DTO = refrigeranteId;
            Nombre_DTO = nombre;
            Co2eq_DTO = co2eq;
            Clase_DTO = clase;
            Grupo_DTO = grupo;
        }

    }
}
