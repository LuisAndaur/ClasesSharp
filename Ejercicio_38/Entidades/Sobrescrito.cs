using System;

namespace Entidades
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;
        


        public Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad
        {
            get { return this.miAtributo; }
        }

        public abstract string MiMetodo();

        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object obj)
        {
            if (obj is Sobrescrito)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }

    }
}
