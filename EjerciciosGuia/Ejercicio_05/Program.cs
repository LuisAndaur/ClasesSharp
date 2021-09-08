using System;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double aumento = 1;
            double numero;
            double sumaAtras;
            double sumaAdelante;

            Console.Write("Ingrese un numero: ");
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("ERROR: Ingrese un numero: ");
            }

            while (aumento < numero)
            {
                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;

                //calculo para atras
                for (double i = 1; i < aumento; i++)
                {
                    sumaAtras += i;
                }

                //calculo adelante
                for (double j = aumento + 1; j <= sumaAtras; j++)
                {
                    if (sumaAdelante == sumaAtras || sumaAdelante > sumaAtras)
                    {
                        break;
                    }
                    sumaAdelante += j;
                }

                if (sumaAtras == sumaAdelante)
                {
                    Console.WriteLine($"El numero {aumento} es centro numerico.");
                }


            }


        }
    }
}
