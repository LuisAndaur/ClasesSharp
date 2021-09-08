using System;

namespace Clase_03_30_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //clases estáticas (static)

            int cantidad = 0;
            Factura factura;

            Console.WriteLine("Ingrese la cantidad de items");
            string cantidadString = Console.ReadLine();
            int.TryParse(cantidadString, out cantidad);

            DetalleFactura[] detalles = new DetalleFactura[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese el nombre del producto");
                string auxNombre = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad del producto");
                string auxCantProducto = Console.ReadLine();
                Console.WriteLine("Ingrese el precio unitario");
                string auxPrecioUnit = Console.ReadLine();

                detalles[i] = new DetalleFactura(int.Parse(auxCantProducto), auxNombre, float.Parse(auxPrecioUnit));

            }

            factura = new Factura(new DateTime(), detalles);






        }
    }
}
