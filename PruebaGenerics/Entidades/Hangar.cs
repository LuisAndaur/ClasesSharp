using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Entidades
{
    public class Hangar<T>
    {
        private Queue<T> queueEnPista;

        public Queue<T> EnPista 
        {
            get
            {
                return queueEnPista;
            }
            
            set
            {
                this.queueEnPista = value;
            }
        
        }
        public Hangar()
        {
            queueEnPista = new Queue<T>(); 
        }

        public void PonerEnPista(T aux)
        {
            this.queueEnPista.Enqueue(aux);
        }

        public void LanzarTodos()
        {
            for (int i = 0; i < queueEnPista.Count ; i++)
            {
                this.queueEnPista.Dequeue();
            }
        }

        private void GuardarEnBitacora(T aux)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += "\\lanzamientos.txt";

            using(StreamWriter escritor = new StreamWriter(path, true))
            {
                escritor.WriteLine($"El tipo {aux.GetType().Name} despego a las {DateTime.Now}");
            }







            //StreamWriter outputFile = new StreamWriter("C:\\Users\\LuisAndaur\\source\\repos\\PruebaGenerics\\vuelos.txt");
            //StringBuilder despegue = new StringBuilder();

            //for (int i = 0; i < queueEnPista.Count; i++)
            //{
            //    despegue.AppendLine($"El Tipo {aux} despego a las {DateTime.Now()}");
            //}

            //outputFile.WriteLine(despegue.ToString());
            //outputFile.Close();


        }
    }
}
