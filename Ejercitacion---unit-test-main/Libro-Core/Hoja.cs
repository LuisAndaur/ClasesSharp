using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro_Core
{
    public class Hoja
    {
        private List<Renglon> renglones;
        private int numero;

        public Hoja()
        {
            renglones = new List<Renglon>();
        }


        public Hoja(int numero) : this()
        {
            this.numero = numero;
            for (int nroRenglon = 0; nroRenglon < 20; nroRenglon++)
            {
                this.renglones.Add(new Renglon());
            }
        }


        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public List<Renglon> Renglones
        {
            get
            {
                return this.renglones;
            }
            set
            {
                this.renglones = value;
            }
        }

    }
}
