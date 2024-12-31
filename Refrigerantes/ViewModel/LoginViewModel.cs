using Refrigerantes.Model;
using Refrigerantes.ModelDTO;
using Refrigerantes.Services;
using Refrigerantes.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Refrigerantes.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private OperarioDTO operario;
        private ObservableCollection<OperarioDTO> operariosObservable;
        private byte[] password;
        private string mensajeError;
        private bool visible = true;
        public int intentosLogin = 0;

        public OperarioDTO Operario
        {
            get { return operario; }
            set { operario = value; }
        }

        public ObservableCollection<OperarioDTO> OperariosObservable
        {
            get { return operariosObservable; }
            set { operariosObservable = value; }
        }

        public string MensajeError
        {
            get { return mensajeError; }
            set { mensajeError = value; OnPropertyChanged(nameof(MensajeError)); }
        }

        public byte[] Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(nameof(Password)); }
        }

        public bool Visible
        {
            get { return visible; }
            set { visible = value; OnPropertyChanged(nameof(Visible)); }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(ExecuteLoginCommand, CanExecuteLoginCommand);

            using (OperarioADO operarioADO = new OperarioADO())
            {
                OperariosObservable = new ObservableCollection<OperarioDTO>(operarioADO.ListarOperariosADO());
            }
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            Debug.WriteLine("Can execute");
            bool valid;

            if (Operario == null || Password == null || Password.Length < 3)
            {
                valid = false;
            }
            else
            {
                valid = true;
            }
            return valid;

        }

        private void ExecuteLoginCommand(object obj)
        {
            MensajeError = string.Empty;
            OperarioDTO? operarioSeleccionado = BuscarOperarioPorMail(Operario.Email_DTO);

            MensajeError = "Email de " + operarioSeleccionado.Nombre_DTO + operarioSeleccionado.Email_DTO;

            if (intentosLogin < 10)
            {
                if (operarioSeleccionado != null && operarioSeleccionado.Password_DTO.ToLower().Equals(BitConverter.ToString(Password).Replace("-", "").ToLower()))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(operarioSeleccionado.OperarioId_DTO.ToString()), null);
                    Visible = false;
                }
                else
                {
                    intentosLogin++;
                    MensajeError = "Contraseña errónea";
                }
            }
            else
            {
                App.Current.Shutdown();
            }
        }

        public OperarioDTO? BuscarOperarioPorMail(string email)
        {
            using (var operarioADO = new OperarioADO())
            {
                return operarioADO.OperarioPorEmailADO(email);
            }
        }
    }
}
