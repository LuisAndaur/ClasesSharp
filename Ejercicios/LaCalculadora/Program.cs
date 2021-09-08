using System;

namespace LaCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            int num1;
            int num2;
            int resultado;

            Console.Write("Ingrese numero1: ");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("ERROR: ingrese numero2: ");
            }

            Console.Write("Ingrese numero2: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("ERROR: ingrese numero2: ");
            }

            Console.WriteLine($"El resultado es: {Calculadora.Calcular(num1, num2, "/")}"); 



        }
    }
}
