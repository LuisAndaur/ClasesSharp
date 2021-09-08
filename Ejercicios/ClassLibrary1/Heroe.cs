using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHeroe
{
    public class Heroe
    {
        private string nombre;
        private string poder;
        private int nivelFuerza;
        private bool esAyudante;

        public Heroe(string nombre, string poder, int nivelFuerza)
        {
            this.SetNombre(nombre);
            this.SetPoder(poder);
            this.SetNivelFuerza(nivelFuerza);
            this.SetEsAyudante(this.GetNivelFuerza() < 50);
        }
        

        public bool SetNombre(string nombre)
        {
            if (!String.IsNullOrEmpty(nombre))
            {
                this.nombre = nombre;
                return true;
            }
            return false;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetPoder(string poder)
        {
            this.poder = poder;
        }

        public bool SetNivelFuerza(int nivelFuerza)
        {
            if (nivelFuerza>-1)
            {
                this.nivelFuerza = nivelFuerza;
                return true;
            }
            return false;
        }

        public int GetNivelFuerza()
        {
            return this.nivelFuerza;
        }

        public bool GetEsAyudante()
        {
            return this.esAyudante;
        }

        public void SetEsAyudante(bool esAyudante)
        {
            this.esAyudante = esAyudante;
        }

        public string HeroeToString()
        {
            return $"Heroe: {nombre}\nPoder: {poder}\nFuerza: {nivelFuerza}\nAyudante: {esAyudante}\n";
        }

    }
}
