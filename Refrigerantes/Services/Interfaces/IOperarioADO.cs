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
        List<OperarioDTO> ListarOperariosADO();
        OperarioDTO OperarioPorIdADO(int id);
        OperarioDTO OperarioPorEmailADO(string email);
        void InsertarOperarioADO(OperarioDTO operarioDTO);
        void ActualizarOperarioADO(OperarioDTO operarioDTO);
        void BorrarOperarioADO(int id);
    }
}
