using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_03
{
    class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Mostrar()
        {            
            return $"Titular {titular}: $ {cantidad}";
        }

        public double Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                return this.cantidad += cantidad;
            }
            else
            {
                return this.cantidad;
            }
        }

        public double Retirar(double cantidad)
        {
            return this.cantidad -= cantidad;
        }



    }
}
