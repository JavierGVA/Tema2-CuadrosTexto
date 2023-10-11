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

namespace Tema2_CuadrosTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                if (f1Nombre.Visibility == Visibility.Collapsed)
                {
                    f1Nombre.Visibility = Visibility.Visible;
                }
                else
                    f1Nombre.Visibility = Visibility.Collapsed;
            }

        }
        private void apellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                if (f1Apellido.Visibility == Visibility.Collapsed)
                {
                    f1Apellido.Visibility = Visibility.Visible;
                }
                else
                    f1Apellido.Visibility = Visibility.Collapsed;
            }

        }

        private void edad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                if (double.TryParse(edad.Text, out _))
                {
                    // El texto es un número
                    f2Edad.Visibility = Visibility.Collapsed;
                }
                else
                    f2Edad.Visibility = Visibility.Visible;

            }
        }
    }
}
