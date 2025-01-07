using Refrigerantes.ModelDTO;
using Refrigerantes.Services;
using Refrigerantes.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Refrigerantes.ViewModel
{
    public class OperacionDeCargaViewModel : BaseViewModel
    {
        private int operacionId;
        private int operarioId;
        private int equipoId;
        private DateTime fechaOperacion;
        private string descripcion;
        private decimal refrigeranteManipulado;
        private bool isRecuperacion;
        private string palabraClave;

        private DataRowView filaSeleccionada;
        private ObservableCollection<OperacionDeCargaDTO> operaciones;
        private ObservableCollection<InstalacionDTO> instalaciones;
        private ObservableCollection<OperarioDTO> operarios;
        private ObservableCollection<EquipoDTO> equipos;
        private EquipoDTO equipoSeleccionado;
        private OperarioDTO operarioSeleccionado;
        private KeyValuePair<bool, string> tipoSeleccionado;

        private DataTable tablaOperaciones;


        public Dictionary<bool, string> TiposDeCarga {  get; set; }
        public ICommand CargarCommand { get; }
        public ICommand ModificarCommand { get; }
        public ICommand GuardarCommand { get; }
        public ICommand LimpiarCommand { get; }
        public ICommand SelectedItemChangedCommand { get; }
        public ICommand FiltrarCommand { get; }

        public KeyValuePair<bool, string> TipoSeleccionado
        {
            get {  return tipoSeleccionado; }
            set 
            {
                tipoSeleccionado = value;
                IsRecuperacion = value.Key;
                OnPropertyChanged(nameof(tipoSeleccionado));
            }
        }

        public ObservableCollection<InstalacionDTO > Instalaciones 
        {
            get { return instalaciones; }
            set
            {
                instalaciones = value;
                OnPropertyChanged(nameof(Instalaciones));
            }
        }

        public bool IsRecuperacion
        {
            get { return isRecuperacion; }
            set
            {
                if (isRecuperacion != value) 
                {
                    isRecuperacion = value;
                    TipoSeleccionado = TiposDeCarga.First(kv => kv.Key == value);
                    OnPropertyChanged(nameof(IsRecuperacion));
                }
            }
        }

        public decimal RefrigeranteManipulado
        {
            get { return refrigeranteManipulado; }
            set
            {
                refrigeranteManipulado = value;
                OnPropertyChanged(nameof(RefrigeranteManipulado));
            }
        }

        public int OperacionId
        {
            get { return operacionId; }
            set
            {
                operacionId = value;
                OnPropertyChanged(nameof(OperacionId));
            }
        }

        public int OperarioId
        {
            get { return operarioId; }
            set
            {
                operarioId = value;
                OnPropertyChanged(nameof(OperarioId));
            }
        }

        public int EquipoId
        {
            get { return equipoId; }
            set
            {
                equipoId = value;
                OnPropertyChanged(nameof(EquipoId));
            }
        }

        public DateTime FechaOperacion
        {
            get { return fechaOperacion; }
            set
            {
                fechaOperacion = value;
                if(fechaOperacion == null)
                {
                    fechaOperacion = DateTime.Now;
                }
                OnPropertyChanged(nameof(FechaOperacion));
            }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
            }
        }

        public DataTable TablaOperaciones
        {
            get { return tablaOperaciones; }
            set
            {
                if (tablaOperaciones != value)
                {
                    tablaOperaciones = value;
                    OnPropertyChanged(nameof(TablaOperaciones));
                }
            }
        }

        public string PalabraClave
        {
            get { return palabraClave; }
            set
            {
                palabraClave = value;
                OnPropertyChanged(nameof(PalabraClave));
            }
        }

        public DataRowView FilaSeleccionada
        {
            get { return filaSeleccionada; }
            set
            {
                filaSeleccionada = value;
                OnPropertyChanged(nameof(FilaSeleccionada));
            }
        }

        public ObservableCollection<OperarioDTO> Operarios
        {
            get { return operarios; }
            set
            {
                operarios = value;
                OnPropertyChanged(nameof(Operarios));
            }
        }

        public ObservableCollection<EquipoDTO> Equipos
        {
            get { return equipos; }
            set
            {
                equipos = value;
                OnPropertyChanged(nameof(Equipos));
            }
        }

        public ObservableCollection<OperacionDeCargaDTO> Operaciones
        {
            get { return operaciones; }
            set
            {
                operaciones = value;
                OnPropertyChanged(nameof(Operaciones));
            }
        }

        public EquipoDTO EquipoSeleccionado
        {
            get { return equipoSeleccionado; }
            set
            {
                if (equipoSeleccionado != value )
                {
                    equipoSeleccionado = value;
                    OnPropertyChanged(nameof(EquipoSeleccionado));

                    EquipoId = equipoSeleccionado?.EquipoId ?? 0;
                }
            }
        }

        public OperarioDTO OperarioSeleccionado
        {
            get { return operarioSeleccionado; }
            set
            {
                if (operarioSeleccionado != value){
                    operarioSeleccionado = value;
                    OnPropertyChanged(nameof(OperarioSeleccionado));

                    OperarioId = operarioSeleccionado?.OperarioId_DTO ?? 0;
                }
            }
        }

        public OperacionDeCargaViewModel()
        {
            TiposDeCarga = new Dictionary<bool, string>
            {
                { true, "Recuperacion"},
                {false, "Carga" }
            };

            FechaOperacion = DateTime.Now;

            GuardarCommand = new RelayCommand(PerformInsertarOperacion,CanExecuteInsertarOperacion);
            ModificarCommand = new RelayCommand(PerformModificarOperacion, CanExecuteModificarOperacion);
            LimpiarCommand = new RelayCommand(PerformLimpiarOperacion);
            CargarCommand = new RelayCommand(PerformCargarOperaciones);
            FiltrarCommand = new RelayCommand(PerformFilterOperacion);
            SelectedItemChangedCommand = new RelayCommand(PerformSelectedItemChangedCommand);
        }
        //CanExecute
        private bool CanExecuteInsertarOperacion(object? parameter)
        {
            
            return (
                 OperarioId != 0 &&
                 EquipoId != 0 &&
                 FechaOperacion != null &&
                 !string.IsNullOrEmpty(Descripcion) &&
                 RefrigeranteManipulado != 0 &&
                 IsRecuperacion != null );
        }

        private bool CanExecuteModificarOperacion(object? parameter)
        {

            return (
                 OperacionId != 0 &&
                 OperarioId != 0 &&
                 EquipoId != 0 &&
                 FechaOperacion != null &&
                 !string.IsNullOrEmpty(Descripcion) &&
                 RefrigeranteManipulado != 0 &&
                 IsRecuperacion != null);
        }

        //Performs
        private void PerformSelectedItemChangedCommand(object? parameter = null)
        {
            if(FilaSeleccionada != null)
            {
               
                OperacionId = (int)FilaSeleccionada["OperacionId"];
                OperarioId = (int)FilaSeleccionada["OperarioId"];
                EquipoId = (int)FilaSeleccionada["EquipoId"];
                FechaOperacion = (DateTime)FilaSeleccionada["FechaOperacion"];
                Descripcion = FilaSeleccionada["Descripcion"].ToString();
                RefrigeranteManipulado = (decimal)FilaSeleccionada["RefrigeranteManipulado"];
                IsRecuperacion = (bool)FilaSeleccionada["IsRecuperacion"];
                TipoSeleccionado = TiposDeCarga.FirstOrDefault(x => x.Key == IsRecuperacion);
                OperarioSeleccionado = Operarios.FirstOrDefault(x => x.OperarioId_DTO == (int)FilaSeleccionada["OperarioId"]);
            }
        }

        private void PerformLimpiarOperacion(object? parameter = null)
        {
            OperarioId = 0;
            EquipoId = 0;
            FechaOperacion = DateTime.Now;
            Descripcion = "";
            RefrigeranteManipulado = 0;
            IsRecuperacion = true;
        }

        private void PerformModificarOperacion(object? parameter = null)
        {
            var result = MessageBox.Show("¿Desea realmente modificar este registro?", "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);
            OperacionDeCargaDTO operacion = new(OperacionId, OperarioId, EquipoId, FechaOperacion, Descripcion, RefrigeranteManipulado, IsRecuperacion);

            if (result == MessageBoxResult.Yes)
            {
                if(operacion == null)
                {
                    MessageBox.Show("Debe rellenar todos los campos");
                }
                else
                {
                    ActualizarOperaciones(operacion);
                }
                MessageBox.Show(String.Format("Registro " + OperarioId + " modificado", "Confirmar", MessageBoxButton.OK, MessageBoxImage.Information));
                PerformCargarOperaciones();
                PerformLimpiarOperacion();
            }
        }

        private void PerformInsertarOperacion(object? parameter = null)
        {
            OperacionDeCargaDTO operacion = new (OperarioId,EquipoId,FechaOperacion,Descripcion,RefrigeranteManipulado,IsRecuperacion);
            InsertarOperaciones(operacion);

            MessageBox.Show(String.Format("Registro {0} insertado", OperarioId), "Confirmar", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void PerformCargarOperaciones(object? parameter = null)
        {
            CargarOperarios();
            if (Operarios != null && Operarios.Count > 0)
            {
                OperarioSeleccionado = Operarios[0]; 
            }
            CargarEquipos();
            if(Equipos != null && Equipos.Count > 0)
            {
                EquipoSeleccionado = Equipos[0];
            }
            IsRecuperacion = true;
            CargarOperaciones();

            DataTable dtable = new DataTable();

            dtable.Columns.Add("OperacionId", typeof(int));
            dtable.Columns.Add("OperarioId", typeof(int));
            dtable.Columns.Add("EquipoId", typeof(int));
            dtable.Columns.Add("FechaOperacion", typeof(DateTime));
            dtable.Columns.Add("Descripcion", typeof(string));
            dtable.Columns.Add("RefrigeranteManipulado", typeof(decimal));
            dtable.Columns.Add("IsRecuperacion", typeof(bool));
            dtable.Columns.Add("TipoCarga", typeof(string));
            dtable.Columns.Add("Modelo", typeof(string));
            dtable.Columns.Add("Operario", typeof(string));

            foreach (OperacionDeCargaDTO operacion in Operaciones)
            {
                string s_NombreOperario = operacion.Operario_DTO.Nombre;
                string s_Modelo = operacion.Equipo_DTO.Modelo;
                string s_Recuperacion = operacion.Recuperacion_DTO == true ? "Gas recuperado" : "Recarga";

                dtable.Rows.Add(
                    operacion.OperacionCargaId_DTO,
                    operacion.OperarioId_DTO,
                    operacion.EquipoId_DTO,
                    operacion.FechaOperacion_DTO,
                    operacion.Descripcion_DTO,
                    operacion.RefrigeranteManipulado_DTO,
                    operacion.Recuperacion_DTO,
                    s_Recuperacion,
                    s_Modelo,
                   s_NombreOperario
                );
            }

            TablaOperaciones = dtable;
            PalabraClave = String.Empty;
        }
        private void PerformFilterOperacion(object? parameter)
        {
            string palabraClaveLimpia = PalabraClave?.Trim();

            if (!string.IsNullOrEmpty(palabraClaveLimpia))
            {
                TablaOperaciones.DefaultView.RowFilter = String.Format("Modelo like '%{0}%' ", palabraClaveLimpia);
            }
            else
            {
                TablaOperaciones.DefaultView.RowFilter = string.Empty;
            }
        }

        //Llamadas a ADO
        private void InsertarOperaciones(OperacionDeCargaDTO operacion)
        {
            using (OperacionDeCargaADO operacionDeCargaADO = new())
            {
                operacionDeCargaADO.InsertarOperacionDeCargaADO(operacion);
            }

        }
        private void ActualizarOperaciones(OperacionDeCargaDTO operacion)
        {
            using (OperacionDeCargaADO operacionDeCargaADO = new())
            {
                operacionDeCargaADO.ActualizarOperacionDeCargaADO(operacion);
            }

        }
        private void CargarOperaciones()
        {
            using (OperacionDeCargaADO operacionDeCargaADO = new())
            {
                var listaOperaciones = operacionDeCargaADO.ListarOperaciones();
                Operaciones = new ObservableCollection<OperacionDeCargaDTO>(listaOperaciones);
            }

        }
        private void CargarInstalaciones()
        {
            using (InstalacionADO instalacionADO = new())
            {
                var listaInstalaciones = instalacionADO.ListarInstalaciones();
                Instalaciones = new ObservableCollection<InstalacionDTO>(listaInstalaciones);
            }
        }
        private void CargarEquipos()
        {
            using (EquipoADO equipoADO = new())
            {
                var equiposList = equipoADO.ListarEquipos();
                Equipos = new ObservableCollection<EquipoDTO>(equiposList);
            }
        }
        private void CargarOperarios()
        {
            using (OperarioADO operarioADO = new())
            {
                var operariosList = operarioADO.ListarOperariosADO();
                Operarios = new ObservableCollection<OperarioDTO>(operariosList);
            }
        }

    }
}
