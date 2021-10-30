using Microsoft.VisualStudio.TestTools.UnitTesting;
using Libro_Core;
using System.Collections.Generic;

namespace TestProjectLibro
{
    [TestClass]
    public class LibroTest
    {
        [ExpectedException(typeof(TituloNoValidoException))]
        [TestMethod]
        public void PropiedadTituloTest_01()
        {
            Libro newLibro = new Libro();
            string auxTitulo = string.Empty;
            
            newLibro.Titulo = auxTitulo;
        }

        [DataRow("", false)]
        [DataRow(null, false)]
        [TestMethod]
        public void BuscarTest_ParametroIsEmptyOrNull(string buscado, bool colorear)
        {
            Libro auxLibro = new Libro();
            List<Hoja> auxHojas = new List<Hoja>();
            
            auxHojas = auxLibro.Buscar(buscado, colorear);
            Assert.AreEqual(auxHojas.Count, 0); 
            Assert.IsFalse(colorear);
        }
    }
}
