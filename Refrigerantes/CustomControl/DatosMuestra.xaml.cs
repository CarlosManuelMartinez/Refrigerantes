using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Refrigerantes.CustomControl
{
    /// <summary>
    /// Lógica de interacción para DatosMuestra.xaml
    /// </summary>
    public partial class DatosMuestra : UserControl
    {
        public static readonly DependencyProperty Texto1Property =
      DependencyProperty.Register("Texto1", typeof(string), typeof(DatosMuestra));

        public static readonly DependencyProperty Texto2Property =
        DependencyProperty.Register("Texto2", typeof(string), typeof(DatosMuestra));

        public static readonly DependencyProperty Texto3Property =
        DependencyProperty.Register("Texto3", typeof(string), typeof(DatosMuestra));

        public static readonly DependencyProperty Color1Property =
        DependencyProperty.Register("Color1", typeof(System.Windows.Media.Color), typeof(DatosMuestra));

        public static readonly DependencyProperty Color2Property =
        DependencyProperty.Register("Color2", typeof(System.Windows.Media.Color), typeof(DatosMuestra));
        public System.Windows.Media.Color Color1
        {
            get { return (System.Windows.Media.Color)GetValue(Color1Property); }
            set { SetValue(Color1Property, value); }
        }
        public System.Windows.Media.Color Color2
        {
            get { return (System.Windows.Media.Color)GetValue(Color2Property); }
            set { SetValue(Color2Property, value); }
        }
        public string Texto1
        {
            get { return (string)GetValue(Texto1Property); }
            set { SetValue(Texto1Property, value); }
        }

        public string Texto2
        {
            get { return (string)GetValue(Texto2Property); }
            set { SetValue(Texto2Property, value); }
        }
        public string Texto3
        {
            get { return (string)GetValue(Texto3Property); }
            set { SetValue(Texto3Property, value); }
        }
        public DatosMuestra()
        {
            InitializeComponent();
        }
    }
}
