using System;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador cuenta = new Sumador();

            Console.WriteLine(cuenta.Sumar(10, 20));
            Console.WriteLine(cuenta.Sumar("20", "30"));
            ;
        }
    }
}
