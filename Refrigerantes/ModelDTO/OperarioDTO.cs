using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerantes.ModelDTO
{
    public class OperarioDTO
    {
        public int OperarioId_DTO { get; set; }

        public string Dni_DTO { get; set; } = null!;

        public string Nombre_DTO { get; set; } = null!;

        public string Apellido1_DTO { get; set; } = null!;
        public string? Apellido2_DTO { get; set; }

        public string Email_DTO { get; set; } = null!;

        public string Password_DTO { get; set; } = null!;

        public int CategoriaProfesionalId_DTO { get; set; }

        public OperarioDTO() { }

        public OperarioDTO(int operarioId_DTO, string dni_DTO, string nombre_DTO, string apellido1_DTO, string? apellido2, string email_DTO, string password_DTO, int categoriaProfesionalId_DTO)
        {
            OperarioId_DTO = operarioId_DTO;
            Dni_DTO = dni_DTO;
            Nombre_DTO = nombre_DTO;
            Apellido1_DTO = apellido1_DTO;
            Apellido2_DTO = apellido2;
            Email_DTO = email_DTO;
            Password_DTO = password_DTO;
            CategoriaProfesionalId_DTO = categoriaProfesionalId_DTO;

        }

        public OperarioDTO( string dni_DTO, string nombre_DTO, string apellido1_DTO, string? apellido2, string email_DTO, string password_DTO, int categoriaProfesionalId_DTO)
        {
            Dni_DTO = dni_DTO;
            Nombre_DTO = nombre_DTO;
            Apellido1_DTO = apellido1_DTO;
            Apellido2_DTO = apellido2;
            Email_DTO = email_DTO;
            Password_DTO = password_DTO;
            CategoriaProfesionalId_DTO = categoriaProfesionalId_DTO;

        }
    }
}
