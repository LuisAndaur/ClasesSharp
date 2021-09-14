using System;

namespace Entidades
{
    public class Guitarra
    {
        private EMarca marca;
        private string modelo;
        private double precio;

        public EMarca Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }

        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public Guitarra(EMarca marca, string modelo, double precio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
        }

    }
}
