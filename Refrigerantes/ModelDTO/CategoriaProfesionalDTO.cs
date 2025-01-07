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
    public class CategoriaProfesionalDTO
    {
        public int CategoriaProfesionalId { get; set; }
        public string CategoriaProfesional1 { get; set; } = null!;
        public  List<Operario> Operarios { get; set; } = new List<Operario>();

        public CategoriaProfesionalDTO()
        {
        }
        public CategoriaProfesionalDTO(int categoriaProfesionalId, string categoriaProfesional1, List<Operario> operarios)
        {
            CategoriaProfesionalId = categoriaProfesionalId;
            CategoriaProfesional1 = categoriaProfesional1;
            Operarios = operarios;
        }
    }
}
