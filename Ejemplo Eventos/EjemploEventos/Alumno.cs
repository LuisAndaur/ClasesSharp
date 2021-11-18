using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEventos
{
    public delegate void DelegadoNotificar(Alumno alumno);
    public delegate void DelegadoDesaprobar(string dato);

    public class Alumno
    {
        string nombre;
        List<float> notas; 
        public event DelegadoNotificar AvisarAprobacion; 
        public  event DelegadoDesaprobar AvisarRecursar; 
          
        public Alumno(string nombre)
        {
            this.nombre = nombre;
            this.notas = new List<float>();

            notas.Add(ClaseAyudadora.rnd.Next(0,10));
            notas.Add(ClaseAyudadora.rnd.Next(0,10));
            notas.Add(ClaseAyudadora.rnd.Next(0,10));
            notas.Add(ClaseAyudadora.rnd.Next(0,10));
            AvisarAprobacion += SoyCrack;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public void NotificarQueAprobe()
        {

            float notaFinal = 0;

            foreach (float item in notas)
            {
                notaFinal += item;
            }

            if((notaFinal/notas.Count) > 3)
            {
                AvisarAprobacion.Invoke(this);
            }
            else
            {
                AvisarRecursar.Invoke($"{this.nombre} recursara la materia");
            }

        }

        public void SoyCrack(Alumno a)
        {
            Console.WriteLine($"{a.nombre} soy re crackkkk");
        }


    }
}
