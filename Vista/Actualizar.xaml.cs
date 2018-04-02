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
using ClienteCollection;
using SegurosBeLife;

namespace Vista
{
    /// <summary>
    /// Lógica de interacción para Actualizar.xaml
    /// </summary>
    public partial class Actualizar : Window
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, RoutedEventArgs e)
        {
            //la logica seria la siguiente tomo el rut del buscar y desplego los datos en cada elemento , es decir les doy los valores a cada celda, luego aplico 
            Cliente cli = new Cliente();
            cli.Rut = txt_rut.Text;
            daoClienteCollection cl = new daoClienteCollection();
            String _rut = cl.Buscar(cli.Rut).Columns.Contains("Rut").ToString(); ;
            
        }

        private void txt_buscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            string rut = txt_buscar.Text;
            if (rut.Length >= 9)
            {

            }
        }
    }
    }

