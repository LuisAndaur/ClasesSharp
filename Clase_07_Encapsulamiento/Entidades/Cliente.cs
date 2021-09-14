using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        //ATRIBUTOS
        private int id;
        private string nombre;
        private Guitarra guitarra;



        private static Cliente clienteHistorico;
        private static int ultimoIdRegistrado;

        


        //PROPIEDADES
        public int Id
            {
                get { return this.id; }
            }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public Guitarra Guitarra
        {
            get { return this.guitarra; }
            set { this.guitarra = value; }
        }

        public static Cliente MejorCliente
        {
            get { return clienteHistorico;  }
        }

        //CONSTRUCTORES
        //no se pone ni private ni public en el static
        static Cliente()
        {
            ultimoIdRegistrado = 1000;
        }

        private Cliente()
        {
            ultimoIdRegistrado++;
            this.id = ultimoIdRegistrado;
        }

        public Cliente(string nombre): this()
        {
            this.nombre = nombre;
        }

        public Cliente(string nombre, Guitarra guitarra) : this(nombre)
        {
            this.guitarra = guitarra;
        }

        

    }
}
