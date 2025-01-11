using Refrigerantes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refrigerantes.Services;

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
            Nombre_DTO = nombre.ToUpper();
            Co2eq_DTO = co2eq;
            Clase_DTO = clase;
            Grupo_DTO = grupo;
        }
        public RefrigeranteDTO(string nombre, decimal co2eq, string clase, string grupo)
            :this(0, nombre, co2eq, clase, grupo)
        {

        }
        public Refrigerante ToModel()
        {
            Refrigerante result = new Refrigerante
            {
                RefrigeranteId = this.RefrigeranteId_DTO,
                Nombre = this.Nombre_DTO,
                Co2eq = this.Co2eq_DTO,
                Clase = this.Clase_DTO,
                Grupo = this.Grupo_DTO,
            };
            return result;
        }
    }
}
