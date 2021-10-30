using System;

namespace Prueba333
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pepe pepe = new Pepe();
            Pepe pepe2 = new Pepe();
            Console.WriteLine(pepe.Equals(pepe2));
        }
    }

    public class Pepe
    {
        //public static bool operator ==(Pepe a, Pepe b)
        //{
        //    return true;
        //}

        //public static bool operator !=(Pepe a, Pepe b)
        //{
        //    return true;
        //}

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

    }


}
