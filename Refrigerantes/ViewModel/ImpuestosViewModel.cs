using Refrigerantes.ModelDTO;
using Refrigerantes.Utils;
using Refrigerantes.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Refrigerantes.ViewModel
{
    public class ImpuestosViewModel : BaseViewModel
    {
        private ConsumirApi consumirApi = new ConsumirApi();
        private List<PcaImpuestos> pcaImpuestos;
        private DataTable tablaImpuestos;
        private string parrafoInformativo;

        public List<PcaImpuestos> PcaImpuestos
        {
            get { return pcaImpuestos; }
            set
            {
                pcaImpuestos = value;
                OnPropertyChanged(nameof(pcaImpuestos));
            }
        }

        public DataTable TablaImpuestos
        {
            get { return tablaImpuestos; }
            set
            {
                if (tablaImpuestos != value)
                {
                    tablaImpuestos = value;
                    OnPropertyChanged(nameof(TablaImpuestos));
                }
            }
        }

        public string FechaFormateada
        {
            get
            {
                string ff = $"*PCA e Impuestos de Gases Refrigerantes obtenidos de la API del Ministerio de Industria y ecologia obtenidos el {DateTime.Now.ToString("dd-MM-yyyy")}";
                return ff; 
            }
        }

        public ImpuestosViewModel()
        {
            RealizarProcesoAsincrono();
        }

        private void CargarPca(object? parameter = null)
        {
            DataTable dtable = new DataTable();

            dtable.Columns.Add("id", typeof(int));
            dtable.Columns.Add("nombre", typeof(string));
            dtable.Columns.Add("pca", typeof(decimal));
            dtable.Columns.Add("impuesto", typeof(decimal));

            foreach (PcaImpuestos impuestos in pcaImpuestos)
            {
                dtable.Rows.Add(
                    impuestos.Id,
                    impuestos.Nombre,
                    impuestos.Pca,
                    impuestos.Impuesto
                    );
            }

            TablaImpuestos = dtable;
        }
        public async Task RealizarProcesoAsincrono()
        {
            await consumirApi.CargarImpuestosApi();

            PcaImpuestos = consumirApi.PcaImpuestos;

            CargarPca();
        }
    }
}
