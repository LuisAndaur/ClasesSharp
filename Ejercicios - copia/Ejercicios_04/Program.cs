using System;

namespace Ejercicios_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Conductor[] conductores = new Conductor[3];

            Conductor conductor1 = new Conductor("Claudia", 200, 350, 0, 129, 333, 549, 0);
            Conductor conductor2 = new Conductor("Pedro", 0, 350, 130, 600, 0, 710, 910);
            Conductor conductor3 = new Conductor("Juan", 152, 250, 321, 0, 489, 119, 0);

            conductores[0] = conductor1;
            conductores[1] = conductor2;
            conductores[2] = conductor3;

            Conductor.ConductorMasKms(conductores);

            //CargarConductores(conductores);
            for (int i = 0; i < conductores.Length; i++)
            {
                Console.WriteLine(conductores[i].GetDia1());

            }
            
        }

        /*static void CargarConductores(Conductor[] auxConductores)
        {
            Conductor conductor1 = new Conductor("Claudia",200,350,0,129,333,549,0);
            Conductor conductor2 = new Conductor("Pedro",0,350,130,600,0,710,910);
            Conductor conductor3 = new Conductor("Juan",152,250,321,0,489,119,0);

            auxConductores[0] = conductor1;
            auxConductores[1] = conductor2;
            auxConductores[2] = conductor3;
        }*/
    }
}
