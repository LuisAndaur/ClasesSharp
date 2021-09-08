using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {        
            int numeroIngresado;
            double cuadrado;
            double cubo;

            Console.WriteLine("Ingrese un numero: ");            
            while (!int.TryParse(Console.ReadLine(), out numeroIngresado) || numeroIngresado < 0)
            {
                Console.WriteLine("Error. Ingrese un numero: ");              
            }

            cuadrado = Math.Pow(numeroIngresado, 2);
            cubo = Math.Pow(numeroIngresado, 3);

            Console.WriteLine($"{numeroIngresado} al cuadrado es: {cuadrado}");
            Console.WriteLine($"{numeroIngresado} al cubo es: {cubo}");
        }
    }
}
