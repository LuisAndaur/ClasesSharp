using System;

namespace ConversorBinarioRecargado
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDecimal;

            Console.Write("Ingrese numero para covertir de decimal a binario el numero: ");
            while (!int.TryParse(Console.ReadLine(), out numDecimal))
            {
                Console.Write("Error: ingrese numero para covertir de decimal a binario el numero: ");
            }
            Console.WriteLine($"El numero decimal {numDecimal} es el numero {Conversor.ConvertirDecimalABinario(numDecimal)} binario.");

            Console.Write("Ingrese numero para covertir de binario a decimal el numero: ");
            numDecimal = Conversor.ConvertirBinarioADecimal(Console.ReadLine());
            Console.WriteLine($"El numero binario {Console.ReadLine()} es el numero {numDecimal} decimal.");
        }
    }
}
