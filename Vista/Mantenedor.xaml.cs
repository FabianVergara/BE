using ClienteCollection;
using SegurosBeLife;
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
    /// Lógica de interacción para Mantenedor.xaml
    /// </summary>
    public partial class Mantenedor : Window
    {
        public Mantenedor()
        {
            InitializeComponent();
        }
        
        

        private void btn_volver_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Listar_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                
                daoClienteCollection cl = new daoClienteCollection();

            }
            catch (Exception)
            {

                MessageBox.Show("Error Buscar");
            }
        }

        private void btn_buscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cli = new Cliente();
                cli.Rut = txt_rut.Text;
                daoClienteCollection cl = new daoClienteCollection();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Error Buscar");
            }
        }

        private void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
