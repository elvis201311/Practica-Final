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
using Practica_Final.UI.Registros.Registro_Amigos;
using Practica_Final.UI.Registros.Registro_Entrada;
using Practica_Final.UI.Registros.Registro_Juegos;

namespace Practica_Final
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
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rAmigos rAmigos = new rAmigos();
            rAmigos.Show();
        }
        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {
            rJuegos rJuegos = new rJuegos();
            rJuegos.Show();
        }
        private void MenuItem_Click3(object sender, RoutedEventArgs e)
        {
            rEntradas rEntradas = new rEntradas();
            rEntradas.Show();
        }
    }
}
