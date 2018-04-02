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
using System.Windows.Shapes;

namespace Vista
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, RoutedEventArgs e)
        {
            Registro venRe = new Registro();
            venRe.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            Mantenedor venBuscar = new Mantenedor();
            venBuscar.Show();
            this.Close();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            Actualizar venUpdate = new Actualizar();
            venUpdate.Show();
            this.Close();
        }

        private void btnCerrarSe_Click(object sender, RoutedEventArgs e)
        {
            MainWindow veninicio = new MainWindow();
            veninicio.Show();
            this.Close();
        }
    }
}