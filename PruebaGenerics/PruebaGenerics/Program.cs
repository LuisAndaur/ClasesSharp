using System;
using Entidades;

namespace PruebaGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hangar<Avion> hangar1 = new Hangar<Avion>();
            Hangar<Androide> hangar2 = new Hangar<Androide>();

            Avion avion1 = new Avion();
            Avion avion2 = new Avion();

            Androide androide1 = new Androide();
            Androide androide2 = new Androide();

            hangar1.PonerEnPista(avion1);
            hangar1.PonerEnPista(avion2);                      

            hangar2.PonerEnPista(androide1);
            hangar2.PonerEnPista(androide2);

            hangar1.LanzarTodos();
            hangar2.LanzarTodos();

            Console.WriteLine("Buen viaje!");
        }
    }
}
