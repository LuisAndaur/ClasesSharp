using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Libro
    {
        private List<string> paginas;

        public List<string> listaPaginas
        {
            get { return paginas; }
        }

        public string this[int pagina]
        {
            get 
            {
                if (pagina>0 || pagina<10)
                {
                    return paginas[pagina];
                }
                return string.Empty;
            }
        }
    }
}
