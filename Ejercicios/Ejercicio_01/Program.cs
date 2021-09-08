using System;

namespace Ejercicio_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] listado = new Alumno[2];

            MostrarInfoInicial(listado);

            for (int i = 0; i < listado.Length; i++)
            {
                Console.WriteLine(listado[i].usuario);
                Console.WriteLine(listado[i].GetCategoria());

            }



            #region codigo comentado practica
            //string[] usuarios = new string[3];
            //usuarios[0] = "luis";
            //usuarios[1] = "pablo";
            //usuarios[2] = "beto";

            //string[] claves = {"lucho","pela","betun"};

            //string usuario;
            //string password;


            //Console.WriteLine("Ingrese un usuario: ");
            //usuario = Console.ReadLine().ToLower().Trim();

            //Console.Clear();

            //Console.WriteLine("Ingrese un password: ");
            //password = Console.ReadLine();


            //if (usuario=="luis" && password== "asd123")
            //{
            //    Console.WriteLine("Usuario logueado");
            //}
            //else
            //{
            //    Console.WriteLine("No se encuentra el usuario");
            //}

            //for (int i = 0; i < usuarios.Length; i++)
            //{
            //    if (usuarios[i] == usuario && claves[i] == password)
            //    {
            //        Console.WriteLine("Usuario logueado");
            //    }
            //}
            #endregion

        }

        static void MostrarInfoInicial(Alumno[] auxListado)
        {
            Alumno alumnoUno = new Alumno(100, "luis","1234", 20);
            Alumno unAlumno2 = new Alumno(101, "jero", "4321", 39);

            


            auxListado[0] = alumnoUno;
            auxListado[1] = unAlumno2;
        }
    }
}
