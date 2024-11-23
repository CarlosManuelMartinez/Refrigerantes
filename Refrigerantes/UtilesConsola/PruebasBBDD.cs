using Refrigerantes.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerantes.UtilesConsola
{
    public class PruebasBBDD
    {
        public static void PrintTipoEquipoDTOList(List<TipoEquipoDTO> tipoEquipoList)
        {
            if (tipoEquipoList == null || tipoEquipoList.Count == 0)
            {
                Console.WriteLine("No hay tipos de equipo para mostrar.");
                return;
            }

            Console.WriteLine("Lista de Tipos de Equipo:");
            Console.WriteLine(new string('-', 40));

            foreach (var tipoEquipo in tipoEquipoList)
            {
                Console.WriteLine($"ID: {tipoEquipo.TipoEquipoId_DTO}");
                Console.WriteLine($"Nombre: {tipoEquipo.TipoEquipo1_DTO}");
                Console.WriteLine($"Cantidad de Equipos Asociados: {tipoEquipo.Equipos_DTO.Count}");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
