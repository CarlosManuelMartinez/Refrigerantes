using Azure;
using LiveCharts;
using LiveCharts.Wpf;
using Refrigerantes.Model;
using Refrigerantes.ModelDTO;
using Refrigerantes.Services;
using Refrigerantes.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
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


        private SeriesCollection pieSeriesCollection;
        private SeriesCollection lineSeriesCollection;
        private SeriesCollection cartesianSeriesCollection;
        private ObservableCollection<string> barLabels;
        private List<OperacionDeCargaDTO> operaciones;
        private List<OperarioDTO> operarios;
        private List<InstalacionDTO> l_instalacionesEnRiesgo;
        private List<InstalacionDTO> l_instalaciones;
        private List<ClienteDTO> clientes;

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
            fechaActual = DateTime.Now;
            fechaFormateada = DateTime.Now.ToString("dd-MM-yyyy");
            CargarClientes();
            CargarOperarioMasActivo();
            CargarInstalacionesMasEco(TARGET_RIESGO);
            InstalacionesConMasDeN_Oeraciones(TARGET_RIESGO);
            MediaCo2 = CargarMediaCO2();

            S_OperarioMasActivo = OperarioMasActivo.Nombre_DTO;
            N_instalacionesEnRiesgo = InstalacionesEnRiesgo.Count();
            N_InstalacionesMasEco = InstalacionesMasEco.Count();

            EnvioEmailsCommand = new RelayCommand(PerformEnvioEmails, CanExecuteEnvioEmails);
            CargarOperaciones();
            CargarOperarios();
            GenerarPieSeries();
            GenerarBarChartSeries(operaciones, operarios);
        }

        public void CargarClientes()
        {
            using (var context = new ClienteADO())
            {
                var clientes = context.ListarClientes();
                Debug.WriteLine($" EMAIL: {clientes[0].EmailDTO} NOMBRE: {clientes[0].NombreDTO}");
            }
        }

        public void CargarInstalaciones()
        {
            using (var context = new InstalacionADO())
            {
                Instalaciones = context.ListarInstalaciones();
                Debug.WriteLine($" Instalaciones listadas: {l_instalaciones.Count}");
                foreach(var i in l_instalaciones)
                {
                    Debug.WriteLine(i.Nombre_DTO + "\n");
                    Debug.WriteLine(i + "\n");
                    if(i.Equipos_DTO.Count > 0)
                    {
                        Debug.WriteLine(i.Equipos_DTO[0].CargaRefrigerante + "\n");
                    }
                    
                }
                
            }
        }

        public SeriesCollection PieSeriesCollection
        {
            get { return pieSeriesCollection; }
            set { pieSeriesCollection = value; OnPropertyChanged(nameof(PieSeriesCollection)); }
        }

        public SeriesCollection LineSeriesCollection
        {
            get { return lineSeriesCollection; }
            set { lineSeriesCollection = value; OnPropertyChanged(nameof(LineSeriesCollection)); }
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
        private bool CanExecuteEnvioEmails(object? parameter = null)
        {
            return (0 == 0);
        }
        private void PerformEnvioEmails(object? parameter = null)
        {
            CargarClientes();
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
                        Values = new ChartValues<double> { numeroOperaciones }
                    });
                }
            }

            // "N" para que salga el eje en enteros
            XFormatter = value => value.ToString("N");
            CartesianSeriesCollection = series;
        }

        //TODO
        private void GenerarPieSeries()
        {
            Dictionary<string, decimal> clienteTotalCO2eq = new Dictionary<string, decimal>();
            //Nombre cliente y totalCo2Eq
            CargarInstalaciones();

            foreach (InstalacionDTO i in l_instalaciones)
            {
                if (!clienteTotalCO2eq.ContainsKey(i.Cliente_DTO.Nombre))
                {
                    clienteTotalCO2eq[i.Cliente_DTO.Nombre] = 0; 
                }

                // Sumamos el CO2eq de cada equipo
                foreach (EquipoDTO e in i.Equipos_DTO)
                {
                    // Verificamos si el equipo tiene un refrigerante y sumamos su valor de CO2eq
                    if (e.Refrigerante != null && e.CargaRefrigerante !=0 && e.Refrigerante.Co2eq !=0) // Asegurémonos de que el equipo tiene un refrigerante asignado
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
                    Values = new ChartValues<double> { (double)kpv.Value }
                });
            }

            PieSeriesCollection = series;
        }
    }
}
