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
        public Boolean Registrar(Cliente cli)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;//para utilizar procedimientos almacenados
                cmd.CommandText = "insertar";//nombre del metodo en sql
                cmd.Parameters.Add("@rut", SqlDbType.VarChar, 50).Value = cli._rut;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = cli._nombre;
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = cli._apellidos;
                cmd.Parameters.Add("@fechaNacimiento", SqlDbType.Date).Value = cli._fechaNaci;
                cmd.Parameters.Add("@sexo", SqlDbType.Char, 1).Value = cli._sexo;
                cmd.Parameters.Add("@estadoCivil", SqlDbType.Char, 1).Value = cli._estado;
                conexion.Open();
                int x = cmd.ExecuteNonQuery();
                conexion.Close();
                return x > 0;

            }
            catch (Exception ex)
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
                Logger.Message(ex.Message);
                return false;

            }
        }

        public Boolean Eliminar(String rut)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "eliminar";
                cmd.Parameters.AddWithValue("@rut", rut);
                conexion.Open();
                int x = cmd.ExecuteNonQuery();
                conexion.Close();
                return x > 0;

            }
            catch (Exception ex)
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();

                }
                Logger.Message(Ex.Message);
                return false;
            }
        }

        public DataTable Listar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "listar";
                conexion.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                conexion.Close();
                return dt;
            }
            catch (Exception ex)
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();

                }
                Logger.Message(Ex.Message);
                return null;
            }
        }

        //buscar
        public DataTable Buscar(String rut)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "buscar";
                cmd.Parameters.AddWithValue("@rut", rut);
                conexion.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                conexion.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Logger.Mensaje(ex.Message);
                return null;
            }
        }

        //actualizar

        public boolean Actualizar(Cliente cliv, Cliente clinuevo)//
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "actualizar";
                cmd.Parameters.AddWithValue("@rut", cliv._rut);//es el unico que tiene referencia a los antiguos datos del cliente 
                cmd.Parameters.AddWithValue("@nombre", clinuevo._nombre);
                cmd.Parameters.AddWithValue("@apellido", clinuevo.apellido);
                cmd.Parameters.AddWithValue("@fechaNacimiento", clinuevo._fechaNaci);
                cmd.Parameters.AddWithValue("@sexo", clinuevo._sexo);
                cmd.Parameters.AddWithValue("@estadoCivil", clinuevo._estado);
                conexion.Open();
                int x = cmd.ExecuteNonQuery();
                conexion.Close();
                return x > 0;

            }
            catch (Exception ex)
            {
                Logger.Mensaje(ex.Message);
                return false;

            }



        }
    }
}


