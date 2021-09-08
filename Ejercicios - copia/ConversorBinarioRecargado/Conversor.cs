using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBinarioRecargado
{
    class Conversor
    {

        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string binario = "";
            while (numeroEntero > 0)
            {
                binario = (numeroEntero % 2).ToString() + binario;
                numeroEntero = numeroEntero / 2;
            }
            return binario;
        }

        public static int ConvertirBinarioADecimal(string binario)
        {
            double numeroASumar = 0;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '1')
                {
                    int len = binario.Length - 1 - i;
                    numeroASumar += Math.Pow(2, len);
                }                
            }
            return (int)numeroASumar;
        }
    }
}
