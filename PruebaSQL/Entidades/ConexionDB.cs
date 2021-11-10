using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace Entidades
{
    public static class ConexionDB
    {
        static SqlConnection conexion; //conecta la instancia de sql
        static SqlCommand comando; //llevar la consulta
        static SqlDataReader reader; //devolverme los datos
        private static string connStr;

        static ConexionDB()
        {
            conexion = new SqlConnection(@"Server=DESKTOP-1GT6RE5\SQLEXPRESS;Database=myDataBase;Trusted_Connection=True;");
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<string> TraerDatos()
        {
            try
            {
                List<string> auxLista = new List<string>();

                comando.CommandText = "Select nombre from Usuarios";
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    auxLista.Add(reader["nombre"].ToString());
                }

                return auxLista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
