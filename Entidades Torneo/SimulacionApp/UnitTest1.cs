using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace SimulacionApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Torneo.JugarPartido(1);

            Assert.AreEqual(Torneo.ListaEquipos[0].Estadistica.PartJugados, 1);
            Assert.AreEqual(Torneo.ListaEquipos[1].Estadistica.PartJugados, 1);
            Assert.AreEqual(Torneo.ListaEquipos[2].Estadistica.PartJugados, 1);
            Assert.AreEqual(Torneo.ListaEquipos[3].Estadistica.PartJugados, 1);


        }

        [ExpectedException(typeof(Exception_FechaNumeroInvalido))]
        [TestMethod]
        public void TestJugarPartido_FechaInvalida_Exception()
        {
            //Arrange
            int fecha = -1;

            //Act
            Torneo.JugarPartido(fecha);
        }
    }
}
