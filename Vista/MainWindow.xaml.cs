using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using ClienteCollection;

namespace Vista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
          
        }
        


        private void btn_aceptar_Click(object sender, RoutedEventArgs e)
        {
            daoClienteCollection cl =new daoClienteCollection();
            Inicio ventana = new Inicio();
                  ventana.Show();
            //for (int i = 1; i < 4; i++)
            //{
            //    String usuario = txt_usuario.Text;
            //    String contrasenna = txt_pass.Text;

            //    int result = cl.loggearse(usuario, contrasenna);
            //    if (result >= 1)
            //    {
            //        Inicio ventana = new Inicio();
            //        ventana.Show();
            //    }
            //    else
            //    {
            //        String j = i.ToString();
            //        MessageBox.Show("Le quedan {0} intentos", j);
            //    }
            //}


        }
    }
}
