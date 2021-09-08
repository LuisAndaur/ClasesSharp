using System;

namespace EjercicioGatoVeterinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato gato1 = new Gato("Lolo", "Rojo", 3);
            Gato gato2 = new Gato("Jack", "Verde", 7);
            Gato gato3 = new Gato("Muni", "Azul", 1);
            Veterinario veterinario = new Veterinario(4);


            veterinario.AgregarGatito(gato1);
            veterinario.AgregarGatito(gato2);
            veterinario.AgregarGatito(gato3);
            veterinario.MostrarGatito();
            


        }
    }
}
