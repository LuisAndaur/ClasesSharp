using System;

namespace Ejercicios_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Pepe","Sand",7,4);
            Alumno alumno2 = new Alumno("Albert","Einstein",2,10);
            Alumno alumno3 = new Alumno("Carlos","Chaplin",5,9);

            Console.WriteLine($"Promedio alumno1: {alumno1.MostrarPromedio()}");
            Console.WriteLine($"Promedio alumno2: {alumno2.MostrarPromedio()}");
            Console.WriteLine($"Promedio alumno3: {alumno3.MostrarPromedio()}");
            
            
        }     
    }
}
