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
            try
            {
                Cliente cli = new Cliente();
                cli.Rut = txtRut.Text;
                cli.Nombre = txtNombre.Text;
                cli.Apellidos = txtApellido.Text;
                cli.FechaNaci = (DateTime)dpkFechaN.SelectedDate;
                        //ESTADO CIVIL
                        if (cbo_ECivil.SelectedValue.Equals("Soltero"))
                        {
                                cli.Estado = (char)'S'; }
                        else
                        {   if (cbo_ECivil.SelectedValue.Equals("Casado"))
                                {   cli.Estado = (char)'C'; }
                            else {
                                   if (cbo_ECivil.SelectedValue.Equals("Viudo"))
                                        { cli.Estado = (char)'V'; }
                                   else
                                    {   if (cbo_ECivil.SelectedValue.Equals("Divorciado"))
                                             { cli.Estado = (char)'D'; }
                                    }
                                 }
               
                        }
                        //SEXO
                        if (cbo_sexo.SelectedValue.Equals("Femenino"))
                        {
                            cli.Sexo = 'F'; }
                        else {
                            if (cbo_sexo.SelectedValue.Equals("Masculino")) { 
                                cli.Sexo = 'M'; }
                                else
                            { 
                                cli.Sexo = 'O';//Otro
                            } 
                        }
                
                daoClienteCollection cl = new daoClienteCollection();
                bool resp=cl.Registrar(cli);
                if (resp == true)
                {
                    MessageBox.Show("Cliente Registrado");
                }
                else
                {
                    MessageBox.Show("No Ha Sido Posible Procesar Su Solicitud");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Error");
            }
                   
        }

        private void btn_volver_Click(object sender, RoutedEventArgs e)
        {
            Inicio ventana = new Vista.Inicio();
            ventana.Show();
            this.Close();
        }

        private void cbo_sexo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
