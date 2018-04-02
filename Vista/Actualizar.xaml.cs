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
            cbo_estado.ItemsSource = Enum.GetValues(typeof(EstadoCivil));
            cbo_estado.SelectedIndex = 0;
            cbo_sexo.ItemsSource = Enum.GetValues(typeof(Sexo));
            cbo_sexo.SelectedIndex = 0;
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

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cli = new Cliente();
                cli.Rut = txt_rut.Text;
                cli.Nombre = txt_nombre.Text;
                cli.Apellidos = txt_apellidos.Text;
                cli.FechaNaci = (DateTime)dpk_fechanaci.SelectedDate;
                string sexo= cbo_sexo.SelectedValue.ToString();
                string estado= cbo_estado.SelectedValue.ToString();
                char sex;
                char estadoC;
                if (sexo == "Masculino")
                {
                     sex = 'M';
                }
                else
                {
                    if (sexo == "Femenino") {
                         sex = 'F';
                    }
                    else
                    {
                        sex = 'O';
                    }

                }
                if (estado == "Soltero") {
                    estadoC = 'S';
                }
                else
                {
                    if (estado == "Casado") {
                        estadoC = 'C';
                    }
                    else
                    {
                        if (estado == "Divorciado") {
                            estadoC = 'D';
                        }
                        else
                        {
                            estadoC = 'V';
                        }
                    }
                }      
        
                cli.Sexo = sex;
                cli.Estado = estadoC;
          
                if (cli.Rut != "")
                {
                    daoClienteCollection cl = new daoClienteCollection();
                    bool resp = cl.Actualizar(cli,cli);
                    if (resp == true)
                    {
                        MessageBox.Show("Cliente Actualizado");
                    }
                    else
                    {
                        MessageBox.Show("No Ha Sido Posible Procesar Su Solicitud");
                    }

                }
                else
                {
                    MessageBox.Show("Debe ingresar todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void cbo_estado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void cbo_sexo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    }

