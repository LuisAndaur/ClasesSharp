using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGatoVeterinario
{
    class Veterinario
    {
        Gato[] gatitos;

        public Veterinario(int cantidad)
        {
            this.gatitos = new Gato[cantidad];
        }

        public void AgregarGatito(Gato gato)
        {
            for (int i = 0; i < this.gatitos.Length; i++)
            {
                if (this.gatitos[i]==null)
                {
                    this.gatitos[i] = gato;
                    break;
                }
            }
        }

        public void MostrarGatito()
        {
            for (int i = 0; i < this.gatitos.Length; i++)
            {
                if (this.gatitos[i]!=null)
                {
                    Console.WriteLine(this.gatitos[i].GatoToString());
                }
            }
        }

    }
}
