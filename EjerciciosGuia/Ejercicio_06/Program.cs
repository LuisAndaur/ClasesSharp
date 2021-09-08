using System;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFin;

            Console.Write("Ingrese anio de inicio: ");
            while (!int.TryParse(Console.ReadLine(), out anioInicio))
            {
                Console.Write("ERROR: ingrese anio de inicio: ");
            }

            Console.Write("Ingrese anio de fin: ");
            while (!int.TryParse(Console.ReadLine(), out anioFin))
            {
                Console.Write("ERROR: ingrese anio de fin: ");
            }

            for (int i = anioInicio; i < anioFin; i++)
            {
                if ( (i % 4 == 0 && i % 100 != 0) || i % 400 == 0 )
                {
                    Console.WriteLine($"El anio {i} es bisiesto.");
                }
            }

        }
    }
}
