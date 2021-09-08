using System;

namespace Ejercicios_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Lore",60,"22657223");
            Persona persona2 = new Persona("Jose",16,"43854001");
            Persona persona3 = new Persona("Laura",21,"38777555");

            Console.WriteLine($"{persona1.Mostrar()} {persona1.EsMayorDeEdad()}");
            Console.WriteLine($"{persona2.Mostrar()} {persona2.EsMayorDeEdad()}");
            Console.WriteLine($"{persona3.Mostrar()} {persona3.EsMayorDeEdad()}");
        }
    }
}
