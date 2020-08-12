using Practica_Final.BLL;
using Practica_Final.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Practica_Final.UI.Registros.Registro_Juegos
{
    /// <summary>
    /// Interaction logic for rJuegos.xaml
    /// </summary>
    public partial class rJuegos : Window
    {
        private Juegos Juegos = new Juegos();
        public rJuegos()
        {
            InitializeComponent();
            this.DataContext = Juegos;
        }

        //todo: Hacer las validaciones de los campos.
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var encontrado = JuegosBLL.Buscar(int.Parse(JuegoIdTextBox.Text));
            if (encontrado != null)
            {
                Juegos = encontrado;
                this.DataContext = Juegos;
            }
            else
            {
                MessageBox.Show("Ese Juego no existe en la base de datos.", "No se encontro.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (JuegosBLL.Guardar(Juegos))
            {
               ;
                MessageBox.Show("Guardado.", "Exito.", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Algo salio mal.", "Error.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (JuegosBLL.Eliminar(int.Parse(JuegoIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Eliminado.", "Exito.", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Algo salio mal.", "Error.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
        }
        public void Limpiar()
        {
            Juegos = new Juegos();
            this.DataContext = Juegos;
        }
    }

   
   
}