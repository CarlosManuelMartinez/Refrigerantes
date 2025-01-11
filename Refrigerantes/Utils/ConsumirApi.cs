using Newtonsoft.Json;
using Refrigerantes.ModelDTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerantes.Utils
{
    public class ConsumirApi
    {
        private List<PcaImpuestos> pcaImpuestos;
        private static readonly HttpClient client = new HttpClient();
        private const string url = "https://raw.githubusercontent.com/CarlosManuelMartinez/RefrigerantesPCA/main/RefrigerantesImpuestos.json";

        public List<PcaImpuestos> PcaImpuestos
        {
            get { return pcaImpuestos; }
            set { pcaImpuestos = value; }
        }

        public async Task CargarImpuestosApi()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                string respuesta = await response.Content.ReadAsStringAsync();

                pcaImpuestos = JsonConvert.DeserializeObject<List<PcaImpuestos>>(respuesta);


            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al traer los datos: {ex.Message}");
            }
        }
    }
}
