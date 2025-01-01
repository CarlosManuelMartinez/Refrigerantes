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
    public class OperariosViewModel : BaseViewModel
    {
        private const string PASSWORD_POR_DEFECTO = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4";
        private int operarioId;
        private string dni;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string email;
        private string password;
        private string nombreCategoria;
        private int categoriaId;
        private string palabraClave;

        private DataRowView filaSeleccionada;
        private ObservableCollection<OperarioDTO> operarios;
        private ObservableCollection<CategoriaProfesionalDTO> categorias;
        private CategoriaProfesionalDTO categoriaSeleccionada;

        private DataTable tablaOperarios;

        public ICommand CargarCommand { get; }
        public ICommand ModificarCommand { get; }
        public ICommand GuardarCommand { get; }
        public ICommand BorrarCommand { get; }

        public ICommand LimpiarCommand { get; }
        public ICommand SelectedItemChangedCommand { get; }
        public ICommand FiltrarCommand { get; }

        public DataTable TablaOperarios
        {
            get { return tablaOperarios; }
            set
            {
                if (tablaOperarios != value)
                {
                    tablaOperarios = value;
                    OnPropertyChanged(nameof(TablaOperarios));
                }
            }
        }

        public string Busqueda
        {
            get { return palabraClave; }
            set
            {
                palabraClave = value;
                OnPropertyChanged(nameof(Busqueda));
            }
        }

        public CategoriaProfesionalDTO CategoriaSeleccionada
        {
            get { return categoriaSeleccionada; }
            set
            {
                categoriaSeleccionada = value;
                OnPropertyChanged(nameof(CategoriaSeleccionada));
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

        public ObservableCollection<CategoriaProfesionalDTO> Categorias
        {
            get { return categorias; }
            set
            {
                categorias = value;
                OnPropertyChanged("Categorias");
            }
        }

        public OperariosViewModel()
        {
            Password = PASSWORD_POR_DEFECTO;
            GuardarCommand = new RelayCommand(PerformInsertarOperario, CanExecuteInsertarOperario);
            BorrarCommand = new RelayCommand(PerformBorrarOperario);
            ModificarCommand = new RelayCommand(PerformModificarOperario);
            LimpiarCommand = new RelayCommand(PerformLimpiarOperario);
            CargarCommand = new RelayCommand(PerformCargarOperarios);
            FiltrarCommand = new RelayCommand(PerformFilterOperarios);
            SelectedItemChangedCommand = new RelayCommand(PerformSelectedItemChangedCommand);

        }

        public int OperarioId
        {
            get { return operarioId; }
            set
            {
                operarioId = value;
                OnPropertyChanged("OperarioId");
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value; OnPropertyChanged("Nombre");
            }
        }

        public string Apellido1
        {
            get { return apellido1; }
            set
            {
                apellido1 = value; OnPropertyChanged("Apellido1");
            }
        }

        public string Apellido2
        {
            get { return apellido2; }
            set
            {
                apellido2 = value; OnPropertyChanged("Apellido2");
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value; OnPropertyChanged("Email");
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value; OnPropertyChanged("Password");
            }
        }

        public string Dni
        {
            get { return dni; }
            set
            {
                dni = value; OnPropertyChanged("Dni");
            }
        }
        public string NombreCategoria
        {
            get { return nombreCategoria; }
            set
            {
                nombreCategoria = value; OnPropertyChanged("NombreCategoria");
            }
        }

        public int CategoriaId
        {
            get { return categoriaId; }
            set
            {
                categoriaId = value;
                OnPropertyChanged("CategoriaId");
            }
        }

        public string PalabraClave
        {
            get { return palabraClave; }
            set
            {
                palabraClave = value; OnPropertyChanged("PalabraClave");
            }
        }
        
        private bool CanExecuteInsertarOperario(object? parameter)
        {
            Debug.WriteLine("CanExecuteSaveOperarios");
            return (!string.IsNullOrEmpty(Nombre)
                && !string.IsNullOrEmpty(Dni)
                && !string.IsNullOrEmpty(Apellido1)
                && !string.IsNullOrEmpty(Apellido2)
                && !string.IsNullOrEmpty(Email)
                && !string.IsNullOrEmpty(Password)
                );
        }
        private void PerformFilterOperarios(object? parameter)
        {
            TablaOperarios.DefaultView.RowFilter = String.Format("Nombre like '%{0}%' ", Busqueda);
        }

        private void PerformSelectedItemChangedCommand(object? parameter = null)
        {
            if (FilaSeleccionada != null)

            {
                foreach (DataColumn column in TablaOperarios.Columns)
                {
                    Debug.WriteLine($"Columna: {column.ColumnName}");
                }


                Debug.WriteLine("PerformSelectedItemChangedCommand:" + "Selected:" + FilaSeleccionada["Nombre"].ToString());

                OperarioId = (int)FilaSeleccionada["OperarioId"];
                Dni = FilaSeleccionada["Dni"].ToString();
                Nombre = FilaSeleccionada["Nombre"].ToString();
                Apellido1 = FilaSeleccionada["Apellido1"].ToString();
                Apellido2 = FilaSeleccionada["Apellido2"].ToString();
                Email = FilaSeleccionada["Email"].ToString();
                Password = PASSWORD_POR_DEFECTO;
                CategoriaSeleccionada = Categorias.FirstOrDefault(x => x.CategoriaProfesionalId == (int)FilaSeleccionada["CategoriaId"]);

            }
        }

        private void PerformLimpiarOperario(object? parameter = null)
        {
            OperarioId = 0;
            Dni = String.Empty;
            Nombre = String.Empty;
            Apellido1 = String.Empty;
            Apellido2 = String.Empty;
            Email = String.Empty;
            CategoriaSeleccionada = null;
        }

        private void PerformCargarOperarios(object? parameter = null)
        {
            CargarCategorias();
            if (Categorias != null && Categorias.Count > 0)
            {
                CategoriaSeleccionada = Categorias[0]; // Asignar la primera categoria profesional
            }

            CargarOperarios();

            Debug.WriteLine("Cargando operarios");

            DataTable dtable = new DataTable();

            dtable.Columns.Add("OperarioId", typeof(int));
            dtable.Columns.Add("Dni", typeof(string));
            dtable.Columns.Add("Nombre", typeof(string));
            dtable.Columns.Add("Apellido1", typeof(string));
            dtable.Columns.Add("Apellido2", typeof(string));
            dtable.Columns.Add("Email", typeof(string));
            dtable.Columns.Add("Password", typeof(string));
            dtable.Columns.Add("CategoriaProfesional", typeof(string));
            dtable.Columns.Add("CategoriaId", typeof(int));

            foreach (OperarioDTO operario in Operarios)
            {
                String s_categoriaProfesional;
                CategoriaProfesionalDTO categoriaProfesional = Categorias.FirstOrDefault(b => b.CategoriaProfesionalId == operario.CategoriaProfesionalId_DTO);

                s_categoriaProfesional = categoriaProfesional == null ? String.Empty : categoriaProfesional.CategoriaProfesional1;

                dtable.Rows.Add(operario.OperarioId_DTO,
                    operario.Dni_DTO,
                    operario.Nombre_DTO,
                    operario.Apellido1_DTO,
                    operario.Apellido2_DTO,
                    operario.Email_DTO,
                    operario.Password_DTO,
                    s_categoriaProfesional,
                    operario.CategoriaProfesionalId_DTO);
            }

            TablaOperarios = dtable;
            Busqueda = String.Empty;
        }

        private void PerformModificarOperario(object? parameter = null)
        {
            var result = MessageBox.Show("¿Desea realmente modificar este registro?", "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);


            if (result == MessageBoxResult.Yes)
            {

                OperarioDTO operario = new((int)FilaSeleccionada["OperarioId"], Dni, Nombre, Apellido1, Apellido2, Email, PASSWORD_POR_DEFECTO, CategoriaSeleccionada.CategoriaProfesionalId);

                if (operario == null)
                {
                    MessageBox.Show("Debe rellenar todos los campos");
                }
                else
                {
                    ActualizarOperario(operario);
                }

                MessageBox.Show(String.Format("Registro " + Nombre + " modificado", "Confirmar", MessageBoxButton.OK, MessageBoxImage.Information));
                PerformCargarOperarios();
                PerformLimpiarOperario();
            }
        }
        private void PerformInsertarOperario(object? parameter = null)
        {
            OperarioDTO operario = new(Dni, Nombre, Apellido1, Apellido2, Email, PASSWORD_POR_DEFECTO,CategoriaSeleccionada.CategoriaProfesionalId);
            InsertarOperario(operario);
            MessageBox.Show(String.Format("Registro {0} insertado", Nombre), "Confirmar", MessageBoxButton.OK, MessageBoxImage.Information);

        }
        private void PerformBorrarOperario(object? parameter = null)
        {
            var result = MessageBox.Show("¿Desea realmente borrar este registro?", "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                //int i_OperrioId = int.Parse(OperarioId);
                BorrarOperario(OperarioId);
            }
        }

        private void BorrarOperario(int id)
        {
            using (OperarioADO operarioADO = new())
            {
                operarioADO.BorrarOperarioADO(id);
            }
            
        }

        private void CargarCategorias()
        {
            using (CategoriaProfesionalADO categoriaProfesionalADO = new())
            {
                var categoriasList = categoriaProfesionalADO.ListarCategoriasProfesionales();
                Categorias = new ObservableCollection<CategoriaProfesionalDTO>(categoriasList);
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

        private void InsertarOperario(OperarioDTO operarioDTO)
        {
            using (OperarioADO operarioADO = new())
            {
                operarioADO.InsertarOperarioADO(operarioDTO);
            }
        }

        private void ActualizarOperario(OperarioDTO operario)
        {
            using (OperarioADO operarioADO = new())
            {
                operarioADO.ActualizarOperarioADO(operario);
            }
        }

    }
}
