using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCentralita
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        public float Duracion
        {
            get { return this.duracion; }
        }

        public abstract float CostoLlamada { get;}

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        public virtual string Mostrar()
        {
            StringBuilder llamada = new StringBuilder();
            llamada.AppendLine($"Origen: {NroOrigen}");
            llamada.AppendLine($"Destino: {NroDestino}");
            llamada.AppendLine($"Duracion: {Duracion}min");
            return llamada.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.Duracion.CompareTo(llamada2.Duracion);
        }

        //public bool operator ==(Llamada l1, Llamada l2)
        //{
        //    if (l1.     l1.nroOrigen == l2.nroOrigen && l1.nroDestino == l2.nroDestino)
        //    {

        //    }
        //}

    }
}
