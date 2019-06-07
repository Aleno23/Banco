using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocios;

namespace NegociosTest
{
    [TestClass]
    public class ClsEmpleadoTest
    {
        private readonly ClsEmpleado _clsEmpleado = new ClsEmpleado();

        
        [TestMethod]
        public void WhenSumarThenResultadoIsOK()
        {
            //Arrange
            int x = 1;
            int y = 2;
            int resultadoEsperado = 3;

            //act
            var resultado = _clsEmpleado.Sumar(x, y);

            //assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void WhenSumarXMenor0ThenResultadoIs0()
        {
            //Arrange
            int x = -1;
            int y = 2;
            int resultadoEsperado = 0;

            //act
            var resultado = _clsEmpleado.Sumar(x, y);

            //assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void WhenSumarYMenor0ThenResultadoIs0()
        {
            //Arrange
            int x = 1;
            int y = -1;
            int resultadoEsperado = -1;

            //act
            var resultado = _clsEmpleado.Sumar(x, y);

            //assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
