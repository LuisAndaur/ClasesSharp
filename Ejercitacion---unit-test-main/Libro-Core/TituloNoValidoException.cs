using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Libro_Core
{
    public class TituloNoValidoException : Exception
    {
        public TituloNoValidoException()
        {
        }

        public TituloNoValidoException(string message) : base(message)
        {
        }

        public TituloNoValidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
