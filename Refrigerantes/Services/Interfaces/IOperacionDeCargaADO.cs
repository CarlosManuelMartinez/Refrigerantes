using Refrigerantes.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerantes.Services.Interfaces
{
    public interface IOperacionDeCargaADO
    {
        List<OperacionDeCargaDTO> ListarOperaciones();
        List<OperacionDeCargaDTO> ListarOperacionesOperarioEquipo();
        OperacionDeCargaDTO OperacionPorId(int id);

    }
}
