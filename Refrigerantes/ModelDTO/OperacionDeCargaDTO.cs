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
    public class OperacionDeCargaDTO
    {
        public int OperacionCargaId_DTO { get; set; }

        public int OperarioId_DTO { get; set; }

        public int EquipoId_DTO { get; set; }
        public DateTime FechaOperacion_DTO { get; set; }

        public string Descripcion_DTO { get; set; } = null!;

        public decimal RefrigeranteManipulado_DTO { get; set; }

        public bool Recuperacion_DTO { get; set; }

        public  Operario Operario_DTO { get; set; } = null!;
        public  Equipo Equipo_DTO { get; set; } = null!;


        public OperacionDeCargaDTO() { }
        public OperacionDeCargaDTO(int operacionCargaId, int operarioId, int equipoId, DateTime fechaOperacion, string descripcion, decimal refrigeranteManipulado, bool recuperacion)
        {
            OperacionCargaId_DTO = operacionCargaId;
            OperarioId_DTO = operarioId;
            EquipoId_DTO = equipoId;
            FechaOperacion_DTO = fechaOperacion;
            Descripcion_DTO = descripcion;
            RefrigeranteManipulado_DTO = refrigeranteManipulado;
            Recuperacion_DTO = recuperacion;
        }

        public OperacionDeCargaDTO(int operacionCargaId_DTO, int operarioId_DTO, int equipoId_DTO, DateTime fechaOperacion_DTO, string descripcion_DTO, decimal refrigeranteManipulado_DTO, bool recuperacion_DTO, Operario operario, Equipo equipo) : this(operacionCargaId_DTO, operarioId_DTO, equipoId_DTO, fechaOperacion_DTO, descripcion_DTO, refrigeranteManipulado_DTO, recuperacion_DTO)
        {
            Operario_DTO = operario;
            Equipo_DTO = equipo;
        }
    }
}
