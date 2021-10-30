using System;
using System.Collections.Generic;

namespace pruebaExam
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperCalculator superCalculator = new SuperCalculator();
            superCalculator += 3;
            superCalculator += 3;
            superCalculator += 1;            
            Console.WriteLine($"Resultado {superCalculator.Resultado}");
        }

        public class SuperCalculator
        {
            private Stack<int> numeros;

            public SuperCalculator()
            {
                this.numeros = new Stack<int>();
            }

            public double Resultado
            {
                get
                {
                    int resultado = 0;
                    foreach (int numero in this.numeros)
                    {
                        resultado += numero;
                    }
                    return resultado;
                }
            }

            public static SuperCalculator operator +(SuperCalculator superCalculator, int numero)
            {
                foreach (int item in superCalculator.numeros)
                {
                    numero *= item;
                }
                superCalculator.numeros.Push(numero);
                return superCalculator;
            }
        }
    }
}
