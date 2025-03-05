using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    internal class Datos
    {
        String cadenaConexion = "Data Source=MSI; integrated security=true; initial catalog=pubs; encrypt=false";
        SqlConnection conexion;

        private SqlConnection abrirConexion()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open(); //Abrir conexion a BD
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                return null;
            }

        }
        public bool prueba()
        {
            try
            {
                abrirConexion();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public DataSet Consulta(string consulta)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(consulta, abrirConexion());
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }

        }

        public bool comando(string consulta)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(consulta, abrirConexion());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
