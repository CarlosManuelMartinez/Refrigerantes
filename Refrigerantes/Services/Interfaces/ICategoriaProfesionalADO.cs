﻿using Refrigerantes.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerantes.Services.Interfaces
{
    public interface ICategoriaProfesionalADO
    {
        List<CategoriaProfesionalDTO> ListarCategoriasProfesionales();
        CategoriaProfesionalDTO CategoriasProfesionalesPorId(int id);
    }
}
