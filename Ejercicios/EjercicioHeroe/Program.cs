using System;

namespace EjercicioHeroe
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroe heroe1 = new Heroe("Batman", "Crack", 100);
            Heroe heroe2 = new Heroe("Acuaman", "Gritar", 20);
            Heroe heroe3 = new Heroe("Flash", "Correr", 45);
            Heroe heroe4 = new Heroe("Saitama", "Calvicie", 100);
            Heroe heroe5 = new Heroe("Vegeta", "Maldito insecto", 63);

            Console.WriteLine(heroe1.HeroeToString());
            Console.WriteLine(heroe2.HeroeToString());
            Console.WriteLine(heroe3.HeroeToString());
            Console.WriteLine(heroe4.HeroeToString());
            Console.WriteLine(heroe5.HeroeToString());



            Universo grupoDeHeroes = new Universo(5);
            Universo.AgregarHeroe(grupoDeHeroes, heroe1);
            Universo.AgregarHeroe(grupoDeHeroes, heroe2);
            Universo.AgregarHeroe(grupoDeHeroes, heroe3);
            Universo.AgregarHeroe(grupoDeHeroes, heroe4);
            Universo.AgregarHeroe(grupoDeHeroes, heroe5);

            Console.WriteLine(Universo.Enfrentar(grupoDeHeroes, 3, 5));
            Console.WriteLine(Universo.Enfrentar(grupoDeHeroes, 1, 4));
            Console.WriteLine(Universo.Enfrentar(grupoDeHeroes, 2, 3));
        }
    }
}
