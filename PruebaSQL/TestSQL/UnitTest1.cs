using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Entidades;

namespace TestSQL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTraerDatos()
        {
            List<string> aux = ConexionDB.TraerDatos();

            Assert.IsTrue(aux.Count>0);
        }

        [TestMethod]
        public void TestTraerDatos2()
        {
            List<string> aux = ConexionDB.TraerDatos();

            Assert.IsTrue(aux.Count > 0);

        }
    }
}
