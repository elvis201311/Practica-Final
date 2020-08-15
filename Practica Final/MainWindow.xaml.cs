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
using Practica_Final.UI.Registros.Registro_Prestamos;
using Practica_Final.UI.Consultas.Consulta_Amigoa;
using Practica_Final.UI.Consultas;
using Practica_Final.UI.Consultas.Consulta_Juegos;
using Practica_Final.UI.Consultas.Prestamos;

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
        private void MenuItem_Click4(object sender, RoutedEventArgs e)
        {
            rPrestamos rPrestamos = new rPrestamos();
            rPrestamos.Show();
        }
        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            cAmigo cAmigo = new cAmigo();
            cAmigo.Show();
        }
        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            cEntrada cEntrada = new cEntrada();
            cEntrada.Show();
        }
        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            cJuegos cJuegos = new cJuegos();
            cJuegos.Show();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            cPrestamos cPrestamos = new cPrestamos();
            cPrestamos.Show();
        }
    }
}
