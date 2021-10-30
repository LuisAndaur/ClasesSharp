using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCentralita
{
    public class Local : Llamada
    {
        private float costo;

        public override float CostoLlamada 
        { 
            get
            {
                return CalcularCosto();
            }
        }

        public Local(string nroOrigen, float duracion, string nroDestino, float costo) :base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }

        public override string Mostrar()
        {
            return $"{base.Mostrar()}El costo de la llamada fue ${CostoLlamada}\n------------------------------------------";
        }

        //public override void Equals(Llamada l1, Llamada l2)
        //{
        //    if (l1.)
        //    {

        //    }
        //}

    }
}
