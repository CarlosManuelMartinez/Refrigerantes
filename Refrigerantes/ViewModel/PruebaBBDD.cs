using Refrigerantes.ViewModel.Base;
using Refrigerantes.ModelDTO;
using Refrigerantes.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Refrigerantes.ViewModel
{
    public class PruebaBBDD : BaseViewModel
    {
        private int operarioId;
        private string dni;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string email;
        private string pasword;
        private int categoriaProfesional;

        private ObservableCollection<OperarioDTO> operarios;
        private DataTable tablaOperarios;
        public ICommand CargarCommand { get; }

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

        public ObservableCollection<OperarioDTO> Operarios
        {
            get { return operarios; }
            set { operarios = value; OnPropertyChanged(nameof(Operarios)); }
        }
        public PruebaBBDD()
        {
            CargarOperarios();
            CargarNombrePrimerOperarios();  
            //NotificarComand = new RelayCommand(PerformCargarOperarios);
           PerformCargarOperarios();

        }
        public int OperarioId
        {
            get { return operarioId; }
            set { operarioId = value; OnPropertyChanged("OperarioId"); }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; OnPropertyChanged("Dni"); }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; OnPropertyChanged("Nombre"); }
        }
        public string Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; OnPropertyChanged("Apellido1"); }
        }
        public string Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; OnPropertyChanged("Apellido2"); }
        }
        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged("Email"); }
        }

        public string Password
        {
            get { return pasword; }
            set { pasword = value; OnPropertyChanged("Password"); }
        }

        public int Categoria
        {
            get { return categoriaProfesional; }
            set { categoriaProfesional = value; OnPropertyChanged("Categoria"); }
        }

        private void CargarNombrePrimerOperarios()
        {
            using (OperarioADO operario_ADO = new())
            {
                var operariosList = operario_ADO.ListarOperariosADO();
                if(operariosList != null)
                {
                     Nombre = operariosList[1].Nombre_DTO;
                }
                else
                {
                    Nombre = "HA VENIDO NULO";
                }
               
            }
        }

        private void CargarOperarios()
        {
            using (OperarioADO operario_ADO = new())
            {
                var operariosList = operario_ADO.ListarOperariosADO();
                Operarios = new ObservableCollection<OperarioDTO>(operariosList);
            }
        }

        private void PerformCargarOperarios(object? parameter = null)
        {

            DataTable dtable = new DataTable();

            //dtable.Columns.Add("OperarioId", typeof(int));
            //dtable.Columns.Add("DNI", typeof(string));
            dtable.Columns.Add("Nombre", typeof(string));
            dtable.Columns.Add("Apellido 1", typeof(string));
            //dtable.Columns.Add("Apellido 2", typeof(string));
            dtable.Columns.Add("Email", typeof(string));
            //dtable.Columns.Add("Password", typeof(string));
            //dtable.Columns.Add("Categoria", typeof(int));

            foreach (OperarioDTO operario in Operarios)
            {
                dtable.Rows.Add(
                    //operario.OperarioId_DTO,
                    // operario.Dni_DTO,
                    operario.Nombre_DTO,
                    operario.Apellido1_DTO,
                    //operario.Apellido2_DTO,
                    operario.Email_DTO);
                    //operario.Password_DTO,
                    //operario.CategoriaProfesionalId_DTO);
            }
            TablaOperarios = dtable;
        }


    }//END CLASS
}//END NAMESPACE
