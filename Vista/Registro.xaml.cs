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
using SegurosBeLife;//MODELO
using ClienteCollection;//CONTROLADOR

namespace Vista
{
    /// <summary>
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : Window
    {
        public Registro()
        {
            InitializeComponent();
            //inicializar Combo Box
            cbo_ECivil.ItemsSource = Enum.GetValues(typeof(EstadoCivil));
            cbo_ECivil.SelectedIndex = 0;
            cbo_sexo.ItemsSource = Enum.GetValues(typeof(Sexo));
            cbo_sexo.SelectedIndex = 0;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
