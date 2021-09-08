using System;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 4;
            int numeroPerfecto = 0;
            int acumulador;
            int contador = 0;

            while (cantidad > contador)
            {
                numeroPerfecto++;
                acumulador = 0;

                for (int i = 1; i < numeroPerfecto; i++)
                {
                    if (numeroPerfecto % i == 0)
                    {
                        acumulador += i;
                    }
                }                

                if (acumulador == numeroPerfecto)
                {
                    Console.WriteLine($"El {numeroPerfecto} es un numero perfecto.");
                    contador++;
                }
            }
        }
    }
}
