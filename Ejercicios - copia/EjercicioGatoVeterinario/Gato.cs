using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGatoVeterinario
{
    class Gato
    {
        private string nombre;
        private string color;
        private int edad;

        public Gato(string nombre, string color, int edad)
        {
            this.nombre = nombre;
            this.color = color;
            this.edad = edad;
        }

        public string GatoToString()
        {
            return $"Nombre: {nombre}\nColor: {color}\nEdad:{edad}\n";
        }
    }

   

}
