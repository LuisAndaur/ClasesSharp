using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_clase
{
    public class Alumno
    {
        public int id;
        public string usuario;
        public string password;
        public int edad;
        private string categoria;

        public void MostrarInformacion()
        {
            Console.WriteLine(usuario);
            Console.WriteLine(password);
            Console.WriteLine(edad);
        }

        public Alumno(int id, string usuario, string password, int edad)
        {
            this.id = id;
            categoria = "Personas";
        }

        public string GetCategoria()
        {
            return $"La categoria es {categoria}";
        }

        public void SetCategoria(string categoria)
        {
            this.categoria = categoria;
        }

    

    }

    
}
