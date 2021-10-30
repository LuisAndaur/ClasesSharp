using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajesEntidades
{
    public class Mensajeria
    {
        static List<Usuario> usuarios;
        


        public static bool TieneUsuario()
        {
            return !(Mensajeria.usuariosLogueado is null);
        }

        public static void Loguear(Usuario usuario)
        {
            DB miBase = new DB("Data Source=190.210.161.90;Integrated Security=false;User ID=alumno;Password=alumno;Initial Catalog=UTN");
            Mensajeria.usuariosLogueado = miBase.LoguearUsuarios(usuario);
            return true;
        }

        public Usuario LogearUsuarios(Usuario usuario)
        {
            Usuario salida = null;
            string consulta = $"select * from usuarios where usuario = @usuario and pass = @password";

            SqlConnection conection = new SqlConnection(this.conectionString);
            SqlCommand command = new SqlCommand(consulta, conection);

            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("@usuario", usuario.NombreUsuario));
            command.Parameters.Add(new SqlParameter("@password", usuario.Pass));

            try
            {
                conection.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    salida = new Usuario();
                    salida.Id = (int)(decimal)dr["id"];
                    salida.Nombre = dr["nombre"].ToString();
                    salida.NombreUsuario = dr["usuario"].ToString();
                }
            }
            finally 
            {
                conection.Close();
           
            }

            return salida;
        }

        public static bool BuscarUsuarios()
        {
            DB miBase = new DB("Data Source=190.210.161.90;Integrated Security=false;User ID=alumno;Password=alumno;Initial Catalog=UTN");
            Mensajeria.usuarios = miBase.RetornarUsuarios();
            return true;
        }   

        public static bool InsertarUsuario(Usuario nuevoUsuario)
        {
            DB miBase = new DB("Data Source=190.210.161.90;Integrated Security=false;User ID=alumno;Password=alumno;Initial Catalog=UTN");
            return miBase.CrearUsuario(nuevoUsuario) == 1;            
        }

    }
}
