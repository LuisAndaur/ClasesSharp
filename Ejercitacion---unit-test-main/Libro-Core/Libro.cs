using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro_Core
{
    public class Libro
    {
        private string titulo;
        List<Hoja> hojasLibro;

        public Libro()
        {
            this.hojasLibro = new List<Hoja>();
            for (int numero = 0; numero < 10; numero++)
            {
                this.hojasLibro.Add(new Hoja(numero));
            }
        }


        /// <summary>
        /// Titulo del libro.
        /// </summary>
        /// <remarks>
        /// set: 
        /// El título del libro no puede tomar un valor nulo ni vacío,si lo es
        /// debe lanzarse una excepción “TituloNoValidoException”.
        /// get: 
        /// La lectura de la propiedad debe retornar el valor del titulo.
        /// </remarks>
        public string Titulo
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.titulo = value;
                }
                else
                {
                    throw new TituloNoValidoException("El titulo no debe ser null ni vacio");
                }
            }
            get
            {
                return this.titulo;
            }
        }


        public List<Hoja> Hojas
        {
            get
            {
                return hojasLibro;
            }
        }

        /// <summary>
        /// Busca aquellas hojas que contengan el texto indicado 
        /// y colorea los renglones que contienen el texto.
        /// </summary>
        /// <param name="buscado">
        /// Texto a buscar.
        /// </param>       
        /// <param name="colorear">
        /// Indica si desea colorear el renglón que contiene el texto encontrado.
        /// </param>
        /// <remarks>
        /// Si el parámetro "buscado" es nulo o vacio , el método debe 
        /// retornar un una lista con cero ítems.
        /// </remarks>
        /// <returns>
        /// Lista de hojas que contienen el texto buscado, en caso de 
        /// no encontrarlo debe retornar una lista con cero ítems
        /// </returns>
        public List<Hoja> Buscar(string buscado, bool colorear)
        {
            List<Hoja> auxHojas = new List<Hoja>();
            if (!string.IsNullOrEmpty(buscado))
            {
                foreach (Hoja hoja in hojasLibro)
                {
                    foreach (Renglon renglones in hoja.Renglones)
                    {
                        if (renglones.Texto.Contains(buscado))
                        {
                            renglones.Coloreado = true;
                            auxHojas.Add(hoja);                            
                        }
                    }
                }
                return auxHojas;
            }
            return auxHojas;
        }


        /// <summary>
        /// Busca aquellas hojas del libro que contengan el texto indicado
        /// sin colorearlas (esto es colorear = false)
        /// </summary>
        /// <param name="buscado">
        /// Texto a buscar.
        /// </param>
        /// <remarks>
        /// Si el parámetro "buscado" es null, el método debe 
        /// retornar un una lista con cero ítems.
        /// </remarks>
        /// <returns>
        /// Lista de hojas que contienen el texto buscado, en caso de 
        /// no encontrarlo debe retornar una lista con cero ítems, 
        /// nunca retorna null.
        /// </returns>
        public List<Hoja> Buscar(string buscado)
        {
            List<Hoja> auxHojas = new List<Hoja>();
            if (!string.IsNullOrEmpty(buscado))
            {
                foreach (Hoja hoja in hojasLibro)
                {
                    foreach (Renglon renglones in hoja.Renglones)
                    {
                        if (renglones.Texto.Contains(buscado) && !renglones.Coloreado)
                        {
                            auxHojas.Add(hoja);
                        }
                    }
                }
                return auxHojas;
            }
            return auxHojas;
        }


        /// <summary>
        /// Reemplaza un texto por otro en cada una de las hojas del libro.
        /// </summary>
        /// <param name="buscado">
        /// Texto a buscar.
        /// </param>
        /// <param name="reemplazo">
        /// Texto de reemplazo.
        /// </param>
        /// <returns>
        /// Lista de hojas que contienen el texto buscado. 
        /// En caso de no encontrarlo debe retornar una lista con cero ítems
        /// Si alguno de los parámetros es nulo debe retornar una lista con cero ítems.
        /// </returns>
        public List<Hoja> Reemplazar(string buscado, string reemplazo)
        {
            List<Hoja> auxHojas = new List<Hoja>();
            if (!string.IsNullOrEmpty(buscado) && !string.IsNullOrEmpty(reemplazo))
            {
                foreach (Hoja hoja in hojasLibro)
                {
                    foreach (Renglon renglones in hoja.Renglones)
                    {
                        if (renglones.Texto.Contains(buscado))
                        {
                            renglones.Texto = reemplazo;
                        }
                    }
                }
                return auxHojas;
            }
            return auxHojas;
        }


        /// <summary>
        /// Retorna las hojas del libro que posea la mayor cantidad de renglones.
        /// </summary>
        /// <example>
        /// Si las hojas 2 y 6 contienen 100 renglones y el resto 90 renglones, 
        /// el método debe retornar una lista con dos hojas, la 2 y la 6.
        /// </example>
        /// <returns></returns>
        public List<Hoja> TraerHojasConMasRenglones()
        {
            List<Hoja> auxHojas = new List<Hoja>();            
            Queue<int> hojas = new Queue<int>();
            int maxRenglones = 1;
            
            foreach (Hoja hoja in hojasLibro)
            {                
                if (hoja.Renglones.Count > maxRenglones)
                {
                    maxRenglones = hoja.Renglones.Count;
                    hojas.Enqueue(hoja.Numero);                }
            }
            return auxHojas;

            if (hojas.Count < 1)
            {

            }
            else
            {
                return auxHojas;
            }

  
        }


        /// <summary>
        /// Elimina las hojas que están repetidas.
        /// Dos hojas están repetidas cunado poseen el mismo número de hoja,
        /// en otras palabras elimina las copias y deja la original.
        /// Por ejemplo si hay 3 hojas repartidas solo deja una, 
        /// eliminando las 2 copias.
        /// </summary>
        /// <returns>
        /// Retorna la lista de hojas que fueron eliminadas. 
        /// En caso de no encontrar hojas repetidas, debe retornar una lista con cero ítems, 
        /// nunca retorna null.
        /// </returns>
        public List<Hoja> EliminarHojasRepetidas()
        {
            List<Hoja> auxHojas = new List<Hoja>();

            for (int i = 0; i < auxHojas.; i++)
            {

            }
                return auxHojas;

            return auxHojas;
        }
    }
}
