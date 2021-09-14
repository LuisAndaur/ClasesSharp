using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Usuario
    {
        private string usuario;
        private string pass;

        public Usuario(string usuario, string pass)
        {
            this.usuario = usuario;
            this.pass = pass;
        }

        public string Usuarios
        {
            get { return this.usuario; }
            set { this.usuario = value;  }
        }

        public string Pass
        {
            get { return this.pass; }
            set { this.pass = value; }
        }
    }
}
