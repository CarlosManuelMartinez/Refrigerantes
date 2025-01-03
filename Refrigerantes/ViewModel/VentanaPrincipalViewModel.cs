using Refrigerantes.ModelDTO;
using Refrigerantes.Services;
using Refrigerantes.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Refrigerantes.ViewModel
{
    public class VentanaPrincipalViewModel : BaseViewModel
    {
        private OperarioDTO? _operario;
        private BaseViewModel currentChildView;

        public OperarioDTO? Operario
        {
            get { return _operario; }
            set
            {
                _operario = value;
                OnPropertyChanged(nameof(Operario));
            }
        }

        public BaseViewModel CurrentChildView
        {
            get
            {
                return currentChildView;
            }
            set
            {
                currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }

        public ICommand MostrarHomeViewCommand { get; }
        public ICommand MostrarOperacionesViewCommand { get; }
        public ICommand MostrarOperariosViewCommand { get; }
        public ICommand MostrarRefrigerantesViewCommand { get; }
        public ICommand MostrarInstalacionesViewCommand { get; }

        public VentanaPrincipalViewModel()
        {
            MostrarHomeViewCommand = new RelayCommand(ExecuteMostrarHomeViewCommand);
            MostrarOperacionesViewCommand = new RelayCommand(ExecuteMostrarOperacionesViewCommand);
            MostrarOperariosViewCommand = new RelayCommand(ExecuteMostrarOperariosViewCommand);
            MostrarRefrigerantesViewCommand = new RelayCommand(ExecuteMostrarInstalacionesViewCommand);
            MostrarInstalacionesViewCommand = new RelayCommand(ExecuteMostrarInstalacionesViewCommand);

            ExecuteMostrarHomeViewCommand(null);
            CargarOperario();
        }

        private void ExecuteMostrarHomeViewCommand(object obj)
        {
            HomeViewModel homeViewModel = new();
            CurrentChildView = homeViewModel;
        }

        private void ExecuteMostrarOperariosViewCommand(object obj)
        {
            OperariosViewModel operariosViewModel = new();
            CurrentChildView = operariosViewModel;
        }

        private void ExecuteMostrarOperacionesViewCommand(object obj)
        {
            OperacionDeCargaViewModel operacionesViewModel = new();
            CurrentChildView = operacionesViewModel;
        }

        public void ExecuteMostrarGasesViewCommand(object obj)
        {
            GasesViewModel gasesViewModel = new();
            CurrentChildView = gasesViewModel;
        }
        public void ExecuteMostrarInstalacionesViewCommand(object obj)
        {
            RefrigerantesViewModel refrigerantesViewModel = new();
            CurrentChildView = refrigerantesViewModel;
        }

        private void CargarOperario()
        {
            using (OperarioADO operarioADO = new())
            {

                if (Thread.CurrentPrincipal.Identity.Name == null)
                {
                    MessageBox.Show("Operario no encontrado");
                    //Application.Current.Shutdown();
                }
                else
                {
                    int id = Convert.ToInt32(Thread.CurrentPrincipal.Identity.Name);

                    _operario = operarioADO.OperarioPorIdADO(id);

                    if (_operario == null)
                    {
                        MessageBox.Show("Operario no encontrado");
                        Application.Current.Shutdown();
                    }
                }
            }
        }












    }
}
