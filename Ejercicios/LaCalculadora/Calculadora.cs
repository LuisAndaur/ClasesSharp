using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCalculadora
{
    public class Calculadora
    {



        public static float Calcular(int num1, int num2, string operacion)
        {
            float retorno = 0; 
            switch (operacion)
            {
                case "+":
                    retorno = num1 + num2;
                    break;

                case "-":
                    retorno = num1 - num2;
                    break;

                case "*":
                    retorno = num1 * num2;
                    break;

                case "/":
                    if (Validar(num2))
                    {
                        retorno = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Operacion invalida.");
                    }
                    break;

            }
            return retorno;
        }

        private static bool Validar(int num2)
        {
            
            return !(num2 == 0);
        }

    }
}
