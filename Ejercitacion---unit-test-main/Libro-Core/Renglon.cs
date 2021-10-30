using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro_Core
{
    public class Renglon
    {
        private string texto;
        private bool coloreado;

        public Renglon()
        {
            this.Texto = "";
        }
        /// <summary>
        /// Texto contenido en el renglón.
        /// </summary>
        public string Texto
        {
            get
            {
                return this.texto;
            }
            set
            {
                this.texto = value;
            }
        }
        /// <summary>
        /// Indica si el renglón se encuentra o no coloreado.
        /// </summary>
        public bool Coloreado
        {
            get
            {
                return this.coloreado;
            }
            set
            {
                this.coloreado = value;
            }
        }
    }
}
