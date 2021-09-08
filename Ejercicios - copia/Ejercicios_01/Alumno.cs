using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_01
{
    class Alumno
    {
        private string nombre;
        private string apellido;
        private int nota1;
        private int nota2;

        public Alumno(string nombre, string apellido, int nota1, int nota2)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public float MostrarPromedio()
        {
            float suma = nota1 + nota2;
            return suma / 2;
        }

      


    }
}
