using Refrigerantes.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerantes.Services.Interfaces
{
    public interface IRefrigeranteADO
    {
        List<RefrigeranteDTO> ListarRefrigerantes();
        RefrigeranteDTO RefrigerantePorId(int id);
        void BorrarRefrigeranteADO(int id);
        void ActualizarRefrigeranteADO(RefrigeranteDTO refrigerante);
        void InsertarRefrigeranteADO(RefrigeranteDTO refrigerante);
    }
}
