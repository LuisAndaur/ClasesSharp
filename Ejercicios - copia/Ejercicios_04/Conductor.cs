using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_04
{
    public class Conductor
    {
        private string nombre;
        int[] kms;

        public Conductor(string nombre, int dia1, int dia2, int dia3, int dia4, int dia5, int dia6, int dia7)
        {
            this.nombre = nombre;
            kmsDia1 = dia1;
            kmsDia2 = dia2;
            kmsDia3 = dia3;
            kmsDia4 = dia4;
            kmsDia5 = dia5;
            kmsDia6 = dia6;
            kmsDia7 = dia7;
        }

        public int GetDia1()
        {
            return this.kmsDia1;
        }

        public static void ConductorMasKms(Conductor[] auxConductores)
        {
            Conductor[] contador = new Conductor[3];
            for (int i = 1; i < auxConductores.Length; i++)
            {
                Console.WriteLine(auxConductores[i]);
            }
        }

        public static void ConductorMasKmsDia3()
        {

        }




    }
}
