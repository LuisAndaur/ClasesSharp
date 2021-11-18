using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEventos
{
    public class Mama
    {
       
        public void Festejar( Alumno alumno)
        {
            Console.WriteLine($"{alumno.Nombre} Aprobooo! Inteligente como mamaaaaa");
        }

        public void Resongar(string info)
        {
            Console.WriteLine($"PUCHA.... {info}");
        }

        public void MamaSeEntera(DelegadoDesaprobar unDelegado)
        {
            unDelegado.Invoke("quienes?");
        }



    }
}
