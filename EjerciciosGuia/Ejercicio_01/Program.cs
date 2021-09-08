using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int numeroIngresado;
            int maximo = 0;
            int minimo = 0;
            float promedio = 0;
            int acumulador = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese numero {i + 1}: ");
                aux = Console.ReadLine();
                while (!int.TryParse(aux, out numeroIngresado))
                {
                    Console.WriteLine($"Error: ingrese un numero {i + 1}: ");
                }

                if (i==0 || numeroIngresado>maximo)
                {
                    maximo = numeroIngresado;
                }

                if (i==0 || numeroIngresado<minimo)
                {
                    minimo = numeroIngresado;
                }

                acumulador += numeroIngresado;
            }

            promedio = (float)acumulador / 5;

            Console.WriteLine($"Valor maximo: {maximo}");
            Console.WriteLine($"Valor minimo: {minimo}");
            Console.WriteLine($"Promedio: {promedio}");
        }
    }
}
