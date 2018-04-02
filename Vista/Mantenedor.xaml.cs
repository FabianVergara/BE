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
using System.Data;

namespace Vista
{
    /// <summary>
    /// Lógica de interacción para Mantenedor.xaml
    /// </summary>
    public partial class Mantenedor : Window
    {
        DataTable tablita = new DataTable();
        public Mantenedor()
        {

            InitializeComponent();
            
            tablita.Columns.Add("Rut");
            tablita.Columns.Add("Nombre");
            tablita.Columns.Add("Apellidos");
            tablita.Columns.Add("Fec_N");
            tablita.Columns.Add("Sexo");
            tablita.Columns.Add("Est_civ");
            tbl_mantenedor.IsItemItsOwnContainer(tablita);

        }
        
        

        private void btn_volver_Click(object sender, RoutedEventArgs e)
        {
            Inicio ventana = new Vista.Inicio();
            ventana.Show();
        }

       

        private void btn_Listar_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                
                daoClienteCollection cl = new daoClienteCollection();
                tablita.Rows.Add(cl.Listar());
                tbl_mantenedor.IsItemItsOwnContainer(tablita);
            }
            catch (Exception)
            {

                MessageBox.Show("Error Listar");
            }
        }

        private void btn_buscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cli = new Cliente();
                cli.Rut = txt_rut.Text;
                daoClienteCollection cl = new daoClienteCollection();
                tablita.Rows.Add(cl.Buscar(cli.Rut));
                tbl_mantenedor.IsItemItsOwnContainer(tablita);
            }
            catch (Exception)
            {

                MessageBox.Show("Error Buscar");
            }
        }

        private void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //debemos rescatar la fila y la columna rut para luego utilizarla en el metodo
                int fila = tbl_mantenedor.SelectedIndex;
                Boolean Eliminar;
                daoClienteCollection cl = new daoClienteCollection();
                String rut = tbl_mantenedor.GetDetailsVisibilityForItem(fila).ToString();
                Eliminar=cl.Eliminar(rut);
                if (Eliminar == true) {
                    MessageBox.Show("Cliente eliminado");
                        } else MessageBox.Show("Cliente no se ha podido eliminar");
            }
            catch (Exception)
            {
                MessageBox.Show("Error Eliminar");
                throw;
            }
        }

        
    }
}
