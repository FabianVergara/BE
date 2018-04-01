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
            Cliente cli = new Cliente();
            cli.Rut = txt_rut.Text;
            daoClienteCollection cl = new daoClienteCollection();
            

        }
    }
    }
}
