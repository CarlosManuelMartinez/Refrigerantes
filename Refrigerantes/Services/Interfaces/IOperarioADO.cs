using Refrigerantes.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerantes.Services.Interfaces
{
    public interface IOperarioADO
    {
        List<OperarioDTO> ListarOperarios();
        OperarioDTO OperarioPorId(int id);
        OperarioDTO OperarioPorEmail(string email);
    }
}
