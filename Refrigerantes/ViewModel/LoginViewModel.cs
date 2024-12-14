using CarlosManuelMartinezPomaresBikeStores_WPF.ViewModel.Base;
using Refrigerantes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerantes.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private int idOperario;
        private string email;
        private string password;


        public int IdOperario
        {
            get { return idOperario; }
            set { idOperario = value; OnPropertyChanged("OperarioId"); }
        }

        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged("email"); }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value; OnPropertyChanged("password");
            }
        }

    }
}
