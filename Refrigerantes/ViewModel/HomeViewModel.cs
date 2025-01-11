using LiveCharts;
using LiveCharts.Wpf;
using Refrigerantes.ModelDTO;
using Refrigerantes.Services;
using Refrigerantes.Utils;
using Refrigerantes.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Refrigerantes.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        private const int TARGET_RIESGO = 2;
        private decimal mediaCo2;
        private OperarioDTO? operarioMasActivo;
        private string s_operarioMasActivo;
        private string fechaFormateada;
        private DateTime fechaActual;
        private ConsumirApi consumirApi = new ConsumirApi();


        private SeriesCollection pieSeriesCollection;
        private SeriesCollection cartesianSeriesCollection;
        private ObservableCollection<string> barLabels;
        private List<OperacionDeCargaDTO> operaciones;
        private List<OperarioDTO> operarios;
        private List<InstalacionDTO> l_instalacionesEnRiesgo;
        private List<InstalacionDTO> l_instalaciones;
        private List<ClienteDTO> clientes;

        public ICommand NotificarComand { get; }

        private int n_instalacionesEnRiesgo;
        IEnumerable<object> instalacionesEnRiesgo;
        private int n_instalacionesMasEco;
        IEnumerable<object> instalacionesMasEco;

        public ICommand EnvioEmailsCommand { get; }
        public List<ClienteDTO> Clientes
        {
            get { return this.clientes; }
            set
            {
                clientes = value;
            }
        }
        public List<OperarioDTO> Operarios
        {
            get { return operarios; }
            set
            {
                operarios = value;
            }
        }
        public List<InstalacionDTO> Instalaciones
        {
            get { return l_instalaciones; }
            set
            {
                l_instalaciones = value;
            }
        }
        public List<OperacionDeCargaDTO> Operaciones 
        {
            get { return operaciones; }
            set
            {
                operaciones = value;
            }
        }
        public decimal MediaCo2
        {
            get { return mediaCo2; }
            set
            {
                mediaCo2 = value;
                OnPropertyChanged(nameof(mediaCo2));
            }
        }
        public IEnumerable<object> InstalacionesEnRiesgo
        {
            get { return instalacionesEnRiesgo; }
            set
            {
                instalacionesEnRiesgo = value;
                OnPropertyChanged(nameof(InstalacionesEnRiesgo));
            }
        }
        public int N_instalacionesEnRiesgo
        {
            get { return n_instalacionesEnRiesgo; }
            set
            {
                n_instalacionesEnRiesgo = value;
                OnPropertyChanged(nameof(N_instalacionesEnRiesgo));
            }
        }
        public IEnumerable<object> InstalacionesMasEco
        {
            get { return instalacionesMasEco; }
            set
            {
                instalacionesMasEco = value;
                OnPropertyChanged(nameof(InstalacionesMasEco));
            }
        }
        public int N_InstalacionesMasEco
        {
            get { return n_instalacionesMasEco; }
            set
            {
                n_instalacionesMasEco = value;
                OnPropertyChanged(nameof(N_InstalacionesMasEco));
            }
        }
        public DateTime FechaActual
        {
            get
            {
                return fechaActual;
            }
            set
            {
                fechaActual = value; OnPropertyChanged(nameof(FechaActual));
            }
        }
        public string FechaFormateada
        {
            get
            {
                return fechaFormateada;
            }
            set
            {
                fechaFormateada = value; OnPropertyChanged(nameof(FechaFormateada));
            }
        }
        public OperarioDTO OperarioMasActivo
        {
            get { return operarioMasActivo; }
            set
            {
                operarioMasActivo = value;
                OnPropertyChanged(nameof(OperarioMasActivo));
            }
        }
        public string S_OperarioMasActivo
        {
            get { return s_operarioMasActivo; }
            set
            {
                s_operarioMasActivo = value;
                OnPropertyChanged(nameof(S_OperarioMasActivo));
            }
        }
        public HomeViewModel()
        {
            RealizarProcesoAsincrono();
            NotificarComand = new RelayCommand(PerformNotificar);

            CargarInstalaciones();
            CargarClientes();
            CargarOperaciones();
            CargarOperarios();

            CargarOperarioMasActivo();
            CargarInstalacionesMasEco(TARGET_RIESGO);
            InstalacionesConMasDeN_Oeraciones(TARGET_RIESGO);
            MediaCo2 = CargarMediaCO2();

            fechaActual = DateTime.Now;
            fechaFormateada = DateTime.Now.ToString("dd-MM-yyyy");
            
            S_OperarioMasActivo = OperarioMasActivo.Nombre_DTO;
            N_instalacionesEnRiesgo = InstalacionesEnRiesgo.Count();
            N_InstalacionesMasEco = InstalacionesMasEco.Count();
            
            GenerarPieSeries();
            GenerarBarChartSeries(operaciones, operarios);
        }

        private async void PerformNotificar(object? parameter = null)
        {

            List<InstalacionDTO> instalacionesConMasDeDosOperaciones = new List<InstalacionDTO>();

            foreach (InstalacionDTO ins in l_instalaciones)
            {
                int contadorOperaciones = 0;

                foreach (EquipoDTO equipo in ins.Equipos_DTO)  
                {
                    var operacionesDeEquipo = operaciones.Where(op => op.EquipoId_DTO == equipo.EquipoId);

                    contadorOperaciones += operacionesDeEquipo.Count();
                }

                if (contadorOperaciones > TARGET_RIESGO)
                {
                    instalacionesConMasDeDosOperaciones.Add(ins);
                }
            }


            Notificaciones notificaciones = new Notificaciones(instalacionesConMasDeDosOperaciones, operaciones);
            notificaciones.EnviarNotificaciones();
            
        }

        public void CargarClientes()
        {
            using (var context = new ClienteADO())
            {
                var clientes = context.ListarClientes();
            }
        }

        public void CargarInstalaciones()
        {
            using (var context = new InstalacionADO())
            {
                Instalaciones = context.ListarInstalaciones();
            }
        }

        public SeriesCollection PieSeriesCollection
        {
            get { return pieSeriesCollection; }
            set { pieSeriesCollection = value; OnPropertyChanged(nameof(PieSeriesCollection)); }
        }

       
        public SeriesCollection CartesianSeriesCollection
        {
            get { return cartesianSeriesCollection; }
            set { cartesianSeriesCollection = value; OnPropertyChanged(nameof(CartesianSeriesCollection)); }
        }
        public ObservableCollection<string> BarLabels
        {
            get { return barLabels; }
            set { barLabels = value; OnPropertyChanged(nameof(BarLabels)); }
        }
        Func<double, string> XFormatter { get; set; }

        private void InstalacionesConMasDeN_Oeraciones(int n_Operaciones)
        {

            using (var context = new InstalacionADO())
            {
                InstalacionesEnRiesgo = context.InstalacionesMasDeNOperacionesADO(n_Operaciones);
            }
        }

        private void CargarOperarioMasActivo()
        {
            using (var context = new OperacionDeCargaADO())
            {
                OperarioMasActivo = context.OPerarioMasActivoADO();
            }
        }
        private void CargarOperaciones()
        {
            using (var context = new OperacionDeCargaADO())
            {
                Operaciones = context.ListarOperaciones();
            }
        }
        private void CargarOperarios()
        {
            using (var context = new OperarioADO())
            {
                Operarios = context.ListarOperariosADO();
            }
        }

        private void CargarInstalacionesMasEco(int n_Operaciones)
        {
            using (var context = new InstalacionADO())
            {
                InstalacionesMasEco = context.InstalacionesMasEcoADO(n_Operaciones);
            }
        }

        private decimal CargarMediaCO2()
        {
            using (var context = new InstalacionADO())
            {
                int totalEquipos = 0;
                decimal totalCO2 = 0;
                var instalaciones = context.ListarInstalaciones();

                foreach (var instalacion in instalaciones)
                {
                    List<EquipoDTO> equipos = instalacion.Equipos_DTO;

                    foreach (EquipoDTO equipo in equipos)
                    {
                        totalEquipos += 1;
                        totalCO2 += equipo.CargaRefrigerante;
                    }
                }
                return totalCO2 / totalEquipos;
            }
        }

        private void GenerarBarChartSeries(List<OperacionDeCargaDTO> operaciones, List<OperarioDTO> operarios)
        {
            Dictionary<int, int> operarioId_Operaciones = new Dictionary<int, int>();
            
            foreach (var operacion in operaciones)
            {
                if (operarioId_Operaciones.ContainsKey(operacion.OperarioId_DTO))
                {
                    operarioId_Operaciones[operacion.OperarioId_DTO]++;
                }
                else
                {
                    operarioId_Operaciones[operacion.OperarioId_DTO] = 1;
                }
            }

            SeriesCollection series = new SeriesCollection();

            foreach (var operario in operarios)
            {
                if (operarioId_Operaciones.ContainsKey(operario.OperarioId_DTO))
                {
                    int numeroOperaciones = operarioId_Operaciones[operario.OperarioId_DTO];

                    // Añado una barra para cada operario
                    series.Add(new ColumnSeries
                    {
                        Title = operario.Nombre_DTO,
                        Values = new ChartValues<double> { (double)numeroOperaciones }
                    });
                }
            }

            // "N" para que salga el eje en enteros
            //XFormatter = value => value.ToString("N");
            CartesianSeriesCollection = series;
        }

        private void GenerarPieSeries()
        {
            Dictionary<string, decimal> clienteTotalCO2eq = new Dictionary<string, decimal>();
            
            CargarInstalaciones();

            foreach (InstalacionDTO i in l_instalaciones)
            {
                if (!clienteTotalCO2eq.ContainsKey(i.Cliente_DTO.Nombre))
                {
                    clienteTotalCO2eq[i.Cliente_DTO.Nombre] = 0; 
                }

                // Sumo el CO2eq de cada equipo
                foreach (EquipoDTO e in i.Equipos_DTO)
                {
                    // Verifico si el equipo tiene un refrigerante y sumo su valor de CO2eq
                    if (e.Refrigerante != null && e.CargaRefrigerante !=0 && e.Refrigerante.Co2eq !=0) 
                    {
                        decimal co2eqPorEquipo = e.CargaRefrigerante * e.Refrigerante.Co2eq;
                        clienteTotalCO2eq[i.Cliente_DTO.Nombre] += co2eqPorEquipo;
                    }
                }
            }


            SeriesCollection series = new SeriesCollection();

            foreach(var kpv in clienteTotalCO2eq)
            {
                series.Add(new PieSeries
                {
                    Title = kpv.Key,
                    Values = new ChartValues<double> { (double)kpv.Value },
                });
            }
           //chartPoint => $"{chartPoint.Y:N2} CO2eq"
            PieSeriesCollection = series;
        }

        public async Task RealizarProcesoAsincrono()
        {
            await consumirApi.CargarImpuestosApi();

            List<PcaImpuestos> pcaImpuestos = consumirApi.PcaImpuestos;
        }
    }
}
