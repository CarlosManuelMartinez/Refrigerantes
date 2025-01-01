using Refrigerantes.ViewModel;
using System.Windows.Controls;

namespace Refrigerantes.View
{
    /// <summary>
    /// Lógica de interacción para OperariosView.xaml
    /// </summary>
    public partial class OperariosView : UserControl
    {
        public OperariosView()
        {
            InitializeComponent();
            DataContext = new OperariosViewModel();
        }
    }
}
