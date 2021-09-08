using System;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int contador;

            Console.WriteLine("Ingrese un numero: ");
            while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                Console.WriteLine("Error: ingrese un numero: ");
            }

            for (int i = 2; i < numeroIngresado; i++)
            {
                contador = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        contador++;
                    }
                }

                if (contador<2)
                {
                    Console.WriteLine($"El numero {i} es primo");
                }
                
            }
        }
    }
}
