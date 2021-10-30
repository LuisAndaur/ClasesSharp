using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCentralita
{
    public  class Provincial : Llamada
    {
        private Franja franjaHoraria;
        public Provincial(string nroOrigen, Franja miFranja,float duracion, string nroDestino) : base(duracion, nroDestino, nroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        public override float CostoLlamada 
        { 
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            //duracion + costo segun franja...Franja_1: 0.99, Franja_2: 1.25 y Franja_3: 0.66.
            float precio = 0;

            if (this.franjaHoraria == Franja.Franja_1)
            {
                precio = 0.99f;
            }
            else
            {
                if (this.franjaHoraria == Franja.Franja_2)
                {
                    precio = 1.25f;
                }
                else
                {
                    precio = 0.66f;
                }
            }
            return base.Duracion * precio;
        }

        public override string Mostrar()
        {
            return $"{base.Mostrar()}El costo de la llamada es de ${CostoLlamada}\n------------------------------------------";
        }
    }
}
