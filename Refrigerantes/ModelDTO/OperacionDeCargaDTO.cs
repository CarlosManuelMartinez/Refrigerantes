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

        public OperacionDeCargaDTO(int operarioId, int equipoId, DateTime fechaOperacion, string descripcion, decimal refrigeranteManipulado, bool recuperacion)
        {
            OperarioId_DTO = operarioId;
            EquipoId_DTO = equipoId;
            FechaOperacion_DTO = fechaOperacion;
            Descripcion_DTO = descripcion;
            RefrigeranteManipulado_DTO = refrigeranteManipulado;
            Recuperacion_DTO = recuperacion;
        }

        public OperacionDeCargaDTO(int operacionCargaId, int operarioId, int equipoId, DateTime fechaOperacion, string descripcion, decimal refrigeranteManipulado, bool recuperacion, Operario operario, Equipo equipo)
            : this(operacionCargaId, operarioId, equipoId, fechaOperacion, descripcion, refrigeranteManipulado, recuperacion)
        {
            Operario_DTO = operario;
            Equipo_DTO = equipo;
        }

        public OperacionCarga ToModel()
        {
            OperacionCarga result = new OperacionCarga
            {
               OperacionCargaId = this.OperacionCargaId_DTO,
               OperarioId = this.OperarioId_DTO,
               EquipoId = this.EquipoId_DTO,
               FechaOperacion = this.FechaOperacion_DTO,
               Descripcion = this.Descripcion_DTO,
               RefrigeranteManipulado = this.RefrigeranteManipulado_DTO,
               Recuperacion = this.Recuperacion_DTO,
               Equipo = this.Equipo_DTO,
               Operario = this.Operario_DTO
            };
            return result;
        }
    }
}
