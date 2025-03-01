﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refrigerantes.Model;
using Refrigerantes.Services;

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
        public OperarioDTO(Operario model)
        {
            if(model != null)
            {
                OperarioId_DTO = model.OperarioId;
                Dni_DTO = model.Dni;
                Nombre_DTO = model.Nombre;
                Apellido1_DTO = model.Apellido1;
                Apellido2_DTO = model.Apellido2;
                Email_DTO = model.Email;
                Password_DTO = model.Password;
                CategoriaProfesionalId_DTO = model.CategoriaProfesionalId;
            }
        }
        public Operario ToModel()
        {
            Operario result = new Operario
            {
                OperarioId = this.OperarioId_DTO,
                Dni = this.Dni_DTO,
                Nombre = this.Nombre_DTO,
                Apellido1 = this.Apellido1_DTO,
                Apellido2 = this.Apellido2_DTO,
                Email = this.Email_DTO,
                Password = this.Password_DTO,
                CategoriaProfesionalId = this.CategoriaProfesionalId_DTO
            };
            return result;
        }
    }
}
