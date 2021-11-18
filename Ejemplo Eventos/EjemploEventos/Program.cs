using System;

namespace EjemploEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Mama madre1 = new Mama();
            Mama madre2 = new Mama();

            Alumno a1 = new Alumno("Pepe");
            Alumno a2 = new Alumno("Juana");

            DelegadoDesaprobar desaprobaron = CadenaNacional;

            madre1.MamaSeEntera(desaprobaron);


            a1.AvisarAprobacion += Festejar;
            a1.AvisarAprobacion += LLamarAMama;
            a1.AvisarAprobacion += madre1.Festejar;

            a1.AvisarRecursar += CadenaNacional;
            a1.AvisarRecursar += madre1.Resongar;



            a2.AvisarAprobacion += LLamarAMama;
            a2.AvisarAprobacion += madre2.Festejar;
            a2.AvisarRecursar += CadenaNacional;
            a2.AvisarRecursar += madre2.Resongar;

            a1.NotificarQueAprobe();
            a2.NotificarQueAprobe();
            

        }

        static void Festejar(Alumno alum)
        {
            Console.WriteLine($"Aprobo {alum.Nombre}");

        } 

        static void LLamarAMama(Alumno alumno)
        {
            Console.WriteLine($"{alumno.Nombre} llamo a la mama llorando que aprobo");
        }
        static void CadenaNacional(string mensaje)
        {
            Console.WriteLine(mensaje);
        }


    }
}
