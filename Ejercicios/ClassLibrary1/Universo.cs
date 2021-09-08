using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHeroe
{
    public class Universo
    {
        private int cantidadHeroes;
        private Heroe[] heroes;
              
        public Universo(int cantidadHeroes)
        {
            this.cantidadHeroes = cantidadHeroes;
            this.heroes = new Heroe[cantidadHeroes];
        }

        //public static bool operator +(Universo uni, Heroe unHeroe)
        //{
        //    for (int i = 0; i < uni.heroes.Length; i++)
        //    {
        //        if (uni.heroes[i] == null)
        //        {
        //            uni.heroes[i] = unHeroe;
        //            break;
        //        }
        //    }
        //}

        public static void AgregarHeroe(Universo uni, Heroe unHeroe)
        {

            for (int i = 0; i < uni.heroes.Length; i++)
            {
                if (uni.heroes[i] == null)
                {
                    uni.heroes[i] = unHeroe;
                    break;
                }
            }
        }

        public static string Enfrentar(Universo uni, int random1, int random2)
        {
            Heroe heroe1;
            Heroe heroe2;

            if ( random1>-1 && random1<= uni.cantidadHeroes && random2 > -1 && random2 <= uni.cantidadHeroes)
            {
                heroe1 = uni.ObtenerHeroe(random1);
                heroe2 = uni.ObtenerHeroe(random2);               

                if (heroe1.GetEsAyudante() == heroe2.GetEsAyudante())
                {
                    if (heroe1.GetNivelFuerza() > heroe2.GetNivelFuerza())
                    {
                        return $"El ganador es {heroe1.GetNombre()}.";
                    }
                    else
                    {
                        if (heroe1.GetNivelFuerza() < heroe2.GetNivelFuerza())
                        {
                            return $"El ganador es {heroe2.GetNombre()}.";
                        }
                        else
                        {
                            return $"La lucha fue un empate entre {heroe1.GetNombre()} y {heroe2.GetNombre()}.";
                        }
                    }
                }
                else
                {
                    if (heroe1.GetEsAyudante() == true)
                    {
                        return $"El ganador es {heroe2.GetNombre()}.";
                    }
                    else
                    {
                        return $"El ganador es {heroe1.GetNombre()}.";
                    }
                }
            }
            return String.Empty;
        }

        private Heroe ObtenerHeroe(int posicion)
        {
            Heroe unHeroe;
            for (int i = 0; i < this.heroes.Length; i++)
            {
                if ( i == (posicion-1) && this.heroes[i]!=null)
                {
                     return unHeroe = this.heroes[i];
                }
            }
            return null;
        }
    }
}
