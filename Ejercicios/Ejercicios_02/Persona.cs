using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_02
{
    class Persona
    {
        private string nombre;
        private int edad;
        private string dni;

        public Persona(string nombre, int edad, string dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            if (edad > 0)
            {
                this.edad = edad;
            }
            
        }

        //public void SetDni(string dni)
        //{
        //    this.dni = dni;
        //}

        public string GetNombre()
        {
            return this.nombre;
        }

        public int GetEdad()
        {
            return edad;
        }

        public string GetDni()
        {
            return dni;
        }

        public string Mostrar()
        {
            return $"Nombre: {GetNombre()}, Edad: {GetEdad()}, DNI: {GetDni()}";
        }


        public string EsMayorDeEdad()
        {
            if (GetEdad()>17)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor";
            }
        }






    }

    
}
