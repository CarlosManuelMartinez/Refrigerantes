using Refrigerantes.Model;
using Refrigerantes.ModelDTO;
using Refrigerantes.Services;
using Refrigerantes.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Refrigerantes.ViewModel
{
    public class RefrigerantesViewModel : BaseViewModel
    {
        private int refrigeranteId;
        private string nombre;
        private decimal co2Eq;
        private string clase;
        private string grupo;

        private DataRowView filaSeleccionada;
        private string palabraClave;
        private DataTable tablaRefrigerantes;
        private ObservableCollection<RefrigeranteDTO> refrigerantes;

        public ICommand CargarCommand { get; }
        public ICommand ModificarCommand { get; }
        public ICommand GuardarCommand { get; }
        public ICommand BorrarCommand { get; }

        public ICommand LimpiarCommand { get; }
        public ICommand SelectedItemChangedCommand { get; }
        public ICommand FiltrarCommand { get; }

        public DataTable TablaRefrigerantes
        {
            get { return tablaRefrigerantes; }
            set
            {
                if (tablaRefrigerantes != value)
                {
                    tablaRefrigerantes = value;
                    OnPropertyChanged(nameof(TablaRefrigerantes));
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

        public ObservableCollection<RefrigeranteDTO> Refrigerantes
        {
            get { return refrigerantes; }
            set
            {
                refrigerantes = value;
                OnPropertyChanged(nameof(refrigerantes));
            }
        }

        public int RefrigeranteId
        {
            get { return refrigeranteId; }
            set
            {
                refrigeranteId = value;
                OnPropertyChanged(nameof(RefrigeranteId));
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }

        public string Clase
        {
            get { return clase; }
            set
            {
                clase = value;
                OnPropertyChanged(nameof(Clase));
            }
        }

        public string Grupo
        {
            get { return grupo; }
            set
            {
                grupo = value;
                OnPropertyChanged(nameof(Grupo));
            }
        }

        public decimal Co2Eq
        {
            get { return co2Eq; }
            set
            {
                co2Eq = value;
                OnPropertyChanged(nameof(Co2Eq));   
            }
        }

        public RefrigerantesViewModel()
        {
            GuardarCommand = new RelayCommand(PerformInsertarRefrigerante, CanExecuteInsertarRefrigerante);
            BorrarCommand = new RelayCommand(PerformBorrarRefrigerante);
            ModificarCommand = new RelayCommand(PerformModificarRefrigerante);
            LimpiarCommand = new RelayCommand(PerformLimpiarRefrigerante);
            CargarCommand = new RelayCommand(PerformCargarRefrigerante);
            FiltrarCommand = new RelayCommand(PerformFilterRefrigerante);
            SelectedItemChangedCommand = new RelayCommand(PerformSelectedItemChangedCommand);
        }

        private void PerformBorrarRefrigerante(object? parameter = null)
        {
            var result = MessageBox.Show("¿Desea realmente borrar este registro?", "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                //int i_OperrioId = int.Parse(OperarioId);
                BorrarRefrigerante(RefrigeranteId);
            }
        }

        private void BorrarRefrigerante(int refrigeranteId)
        {
            using (RefrigeranteADO refrigeranteADO = new())
            {
                refrigeranteADO.BorrarRefrigeranteADO(refrigeranteId);
            }
        }

        private void PerformInsertarRefrigerante(object? parameter = null)
        {
            RefrigeranteDTO refrigeranteDTO = new(Nombre, Co2Eq, Clase, Grupo);
            InsertarRefrigerante(refrigeranteDTO);

            MessageBox.Show(String.Format("Registro {0} insertado", Nombre), "Confirmar", MessageBoxButton.OK, MessageBoxImage.Information);

        }
        private void PerformModificarRefrigerante(object obj)
        {
            var result = MessageBox.Show("¿Desea realmente modificar este registro?", "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                RefrigeranteDTO refrigerante = new((int)FilaSeleccionada[nameof(RefrigeranteId)], Nombre, Co2Eq, Clase, Grupo);
                if (refrigerante == null)
                {
                    MessageBox.Show("Debe rellenar todos los campos");
                }
                else
                {
                    ActualizarRefrigerante(refrigerante);
                }

                MessageBox.Show(String.Format("Registro " + Nombre + " modificado", "Confirmar", MessageBoxButton.OK, MessageBoxImage.Information));
                PerformCargarRefrigerante();
                PerformLimpiarRefrigerante();
            }
        }
        private void PerformSelectedItemChangedCommand(object obj)
        {
            if (FilaSeleccionada != null)
            {
                foreach (DataColumn column in TablaRefrigerantes.Columns)
                {
                    Debug.WriteLine($"Columna: {column.ColumnName}");
                }

                RefrigeranteId = (int)FilaSeleccionada[nameof(RefrigeranteId)];
                Nombre = (string)FilaSeleccionada[nameof(Nombre)];
                Co2Eq = (decimal)FilaSeleccionada[nameof(Co2Eq)];
                Clase = (string)FilaSeleccionada[nameof(Clase)];
                Grupo = (string)FilaSeleccionada[nameof(Grupo)];

            }
        }
        private void PerformCargarRefrigerante(object? parameter = null)
        {
            CargarRefrigerantes();
            DataTable dtable = new DataTable();
            dtable.Columns.Add("RefrigeranteId", typeof(int));
            dtable.Columns.Add("Nombre", typeof(string));
            dtable.Columns.Add("Co2Eq", typeof(decimal));
            dtable.Columns.Add("Clase", typeof(string));
            dtable.Columns.Add("Grupo", typeof(string));

            foreach (RefrigeranteDTO refrigerante in Refrigerantes)
            {
                dtable.Rows.Add(
                    refrigerante.RefrigeranteId_DTO,
                    refrigerante.Nombre_DTO,
                    refrigerante.Co2eq_DTO,
                    refrigerante.Clase_DTO,
                    refrigerante.Grupo_DTO
                    );
            }

            TablaRefrigerantes = dtable;
            PalabraClave = String.Empty;
        }
        private bool CanExecuteInsertarRefrigerante(object? parameter)
        {
            return (
                !string.IsNullOrEmpty(Nombre) &&
                !string.IsNullOrEmpty(Clase) &&
                !string.IsNullOrEmpty(Grupo) &&
                 Co2Eq != 0);

        }
        private void PerformLimpiarRefrigerante(object? parameter = null)
        {
            RefrigeranteId = 0;
            Nombre = "";
            Co2Eq = 0;
            Clase = "";
            Grupo = "";
        }
        private void PerformFilterRefrigerante(object? parameter)
        {
            TablaRefrigerantes.DefaultView.RowFilter = String.Format("Nombre like '%{0}%' ", PalabraClave);
        }
        private void InsertarRefrigerante(RefrigeranteDTO refrigerante)
        {
            using (RefrigeranteADO refrigeranteADO = new())
            {
                refrigeranteADO.InsertarRefrigeranteADO(refrigerante);
            }
            CargarRefrigerantes();
        }
        private void ActualizarRefrigerante(RefrigeranteDTO refrigerante)
        {
            using (RefrigeranteADO refrigeranteADO = new())
            {
                refrigeranteADO.ActualizarRefrigeranteADO(refrigerante);
            }
        }
        private void CargarRefrigerantes()
        {
            using (RefrigeranteADO refrigeranteADO = new())
            {
                var refrigerantesList = refrigeranteADO.ListarRefrigerantes();
                Refrigerantes = new ObservableCollection<RefrigeranteDTO>(refrigerantesList);
            }
        }
    }
}
