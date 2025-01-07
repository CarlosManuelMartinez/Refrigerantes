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
    public class EquipoDTO
    {
        public int EquipoId { get; set; }

        public int InstalacionId { get; set; }

        public int RefrigeranteId { get; set; }

        public int TipoEquipoId { get; set; }

        public string Marca { get; set; } = null!;

        public string Modelo { get; set; } = null!;

        public decimal CargaRefrigerante { get; set; }

        public virtual Instalacion Instalacion { get; set; } = null!;

        public List<OperacionCarga> OperacionCargas { get; set; } = new List<OperacionCarga>();

        public  Refrigerante Refrigerante { get; set; } = null!;

        public  TipoEquipo TipoEquipo { get; set; } = null!;

        public EquipoDTO()
        {
        }

        public EquipoDTO(int equipoId, int instalacionId, int refrigeranteId, int tipoEquipoId, string marca, string modelo, decimal cargaRefrigerante, Instalacion instalacion, List<OperacionCarga> operacionCargas, Refrigerante refrigerante, TipoEquipo tipoEquipo)
        {
            EquipoId = equipoId;
            InstalacionId = instalacionId;
            RefrigeranteId = refrigeranteId;
            TipoEquipoId = tipoEquipoId;
            Marca = marca;
            Modelo = modelo;
            CargaRefrigerante = cargaRefrigerante;
            Instalacion = instalacion;
            OperacionCargas = operacionCargas;
            Refrigerante = refrigerante;
            TipoEquipo = tipoEquipo;
        }

        public EquipoDTO(int equipoId, decimal cargaRefrigerante)
        {
            EquipoId = equipoId;
            CargaRefrigerante = cargaRefrigerante;
            
        }
    }
}
