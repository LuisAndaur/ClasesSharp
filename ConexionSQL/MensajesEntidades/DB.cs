using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajesEntidades
{
    public class DB
    {
        private string conectionString;
        static Usuario usuariosLogueado;
        //string consulta = "select * from usuarios";
        string consulta = "select id, usuario, pass, nombre from usuarios";
        List<Usuario> usuarios = new List<Usuario>();

        public DB(string conectionString)
        {
            this.conectionString = conectionString;
        }

        public List<Usuario> RetornarUsuarios()
        {
            //abre y cierra la conexion
            SqlConnection cn = new SqlConnection(this.conectionString);

            //establecemos la consulta
            SqlCommand cm = new SqlCommand(consulta, cn);

            try
            {
                //abre la conexion
                cn.Open();

                //ejecutar consulta
                SqlDataReader sqlDataReader =  cm.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Usuario user = new Usuario();
                    //por cada fila verifico las celdas, por indice de columna o por nombre
                    //user.Id = (int)sqlDataReader["id"];
                    //user.MiUsuario = sqlDataReader["Usuario"].ToString();
                    //user.Pass = sqlDataReader["Pass"].ToString();
                    //user.Nombre = sqlDataReader["Nombre"].ToString();

                    user.Id = (int)(decimal)sqlDataReader[0];
                    user.NombreUsuario = sqlDataReader[1].ToString();
                    user.Pass = sqlDataReader[2].ToString();
                    user.Nombre = sqlDataReader[3].ToString();

                    usuarios.Add(user);
                }
                return usuarios;
            }

            finally
            {
                //cerramos la conexion
                cn.Close();

            }
        }


        public int CrearUsuario(Usuario usuario)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = this.conectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = $"insert into usuarios (usuario, pass, nombre) values ('{usuario.NombreUsuario}','{usuario.Pass}', '{usuario.Nombre}')";
            sqlCommand.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
            finally 
            {
                sqlConnection.Close();
            }
        }

    }
}
