﻿using ClienteCollection;
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
        public Mantenedor()
        {

            InitializeComponent();
            DataTable tablita = new DataTable();
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
                tablita.AddRow(cl.Buscar(cli.Rut));
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
                int fila=tbl_mantenedor.
            }
            catch (Exception)
            {
                MessageBox.Show("Error Eliminar");
                throw;
            }
        }

        
    }
}
