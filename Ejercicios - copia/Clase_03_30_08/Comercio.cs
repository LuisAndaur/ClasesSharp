using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03_30_08
{
    public static class Comercio
    {
        static string nombre;
        static string direccion;
        static long cuit;
        static string razonSocial;

        static Comercio()
        {
            nombre = "Firulais";
            direccion = "San Martin 455";
            cuit = 30234568764;
            razonSocial = "Lucas Rodriguez";
        }

        public static string GetNombre()
        {
            return nombre;
        }

        public static void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
            //Comercio.nombre = nombre;
        }

        public static string GetDireccion()
        {
            return direccion;
        }

        public static long GetCuit()
        {
            return cuit;
        }

        public static string GetRazonSocial()
        {
            return razonSocial;
        }
    }
}
