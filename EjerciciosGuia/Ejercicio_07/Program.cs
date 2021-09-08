using System;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nacimiento;
            DateTime hoy;
            TimeSpan diferencia;

            Console.Write("Ingrese fecha de nacimiento DD/MM/AAAA: ");
            while (!DateTime.TryParse(Console.ReadLine(), out nacimiento))
            {
                Console.Write("ERROR: ingrese fecha de nacimiento DD/MM/AAAA: ");
            }

            hoy = DateTime.Now;
            diferencia = hoy - nacimiento;

            Console.WriteLine($"Usted hasta hoy tiene: {diferencia.Days} dias de vida.");

        }
    }
}
