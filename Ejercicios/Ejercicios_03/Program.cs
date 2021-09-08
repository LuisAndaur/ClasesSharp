using System;

namespace Ejercicios_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Aldo", 50000.100);
            double cantidad;

            Console.WriteLine($"Cuenta de: {cuenta1.Mostrar()}");

            Console.WriteLine("Ingrese dinero:");
            while (!double.TryParse(Console.ReadLine(), out cantidad))
            {
                Console.WriteLine("ERROR: Ingrese dinero:");
            }
            Console.WriteLine($"Saldo actual: {cuenta1.Ingresar(cantidad)}");

            Console.WriteLine("Retire dinero:");
            while (!double.TryParse(Console.ReadLine(), out cantidad))
            {
                Console.WriteLine("ERROR: Retire dinero:");
            }
            Console.WriteLine($"Saldo actual: {cuenta1.Retirar(cantidad)}");


        }
    }
}
