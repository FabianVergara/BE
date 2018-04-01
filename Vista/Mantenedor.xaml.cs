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
using SegurosBeLife;
using System.Data;
using ClienteCollection;

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

        private void btn_buscar(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cli = new Cliente();
                cli.Rut = txt_rut.Text;
                daoClienteCollection cl = new  daoClienteCollection();
                foreach (var item in collection)
                {

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error Buscar");
            }

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
