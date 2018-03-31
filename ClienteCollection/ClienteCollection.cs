using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Biblioteca;

namespace ClienteCollection
{
    public class ClienteCollection
    {

        //Crear una conexion
        SqlConnection conexion;
        String cadena = @"Data Source = url;Initial Catalog=nombredelabasededatos;Persist Security Info=True;User ID=nombre;Password=contraseña";
        public ClienteCollection()
        {
            //instanciar conexion
            conexion = new SqlConnection(cadena);
        }
        //C.R.U.D
        public Boolean Registrar(Cliente cli) {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "insertar";
                cmd.Parameters.Add("@rut", SqlDbType.VarChar, 50).Value = cli._rut;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = cli._nombre;
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = cli._apellidos;
                cmd.Parameters.Add("@fechaNacimiento", SqlDbType.Date).Value = cli._fechaNaci;
                cmd.Parameters.Add("@sexo", SqlDbType.Char, 1).Value = cli._sexo;
                cmd.Parameters.Add("@estadoCivil", SqlDbType.Char, 1).Value = cli._estado;
                conexion.Open();
                int x = cmd.ExecuteNonQuery();
                conexion.Close();
                return x> 0;

            }
            catch (Exception ex)
            {
                if (conexion.State==System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
                Logger.Message(ex.Message);
                return false;
                
            }
        }
    
        public Boolean Eliminar(String rut) {
            try
            {

            }
            catch (Exception ex)
            {
                if (conexion.State==System.Data.ConnectionState.Open)
                {
                    conexion.Close();

                }
                Logger.Message(Ex.Message);
                return false;
            }
        }

        public ArrayList Listar(String Cliente) {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        //buscar
        //actualizar




    }
}
