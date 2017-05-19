using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NavajaHectorSala.Factorial;

namespace FactorialTest
{
    /// <summary>
    /// Clase de prueba de la aplicacion Factorial.
    /// </summary>
    [TestClass]
    public class PruebaFactorial
    {
        /// <summary>
        /// Factorial de 0
        /// </summary>
        [TestMethod]
        public void FactorialNum0()
        {
            LogicaFactorial factorial = new LogicaFactorial();
            int numero = 0;
            int resultado = 0;
            string mensajeResultado = "";

            int resultadoEsperado = 0;
            string mensajeResultadoEsperado = "El factorial de 0 es: 0";

            factorial.iterativoFactorial(numero, out resultado, out mensajeResultado);

            Assert.AreEqual(resultadoEsperado, resultado);
            Assert.AreEqual(mensajeResultadoEsperado, mensajeResultado);
        }

        /// <summary>
        /// Factorial de 1
        /// </summary>
        [TestMethod]
        public void FactorialPositivoNum1()
        {
            LogicaFactorial factorial = new LogicaFactorial();
            int numero = 1;
            int resultado = 0;
            string mensajeResultado = "";

            int resultadoEsperado = 1;
            string mensajeResultadoEsperado = "El factorial de 1 es: 1";

            factorial.iterativoFactorial(numero, out resultado, out mensajeResultado);

            Assert.AreEqual(resultadoEsperado, resultado);
            Assert.AreEqual(mensajeResultadoEsperado, mensajeResultado);
        }

        /// <summary>
        /// Factorial de 5
        /// </summary>
        [TestMethod]
        public void FactorialPositivoNum5()
        {
            LogicaFactorial factorial = new LogicaFactorial();
            int numero = 5;
            int resultado = 0;
            string mensajeResultado = "";

            int resultadoEsperado = 120;
            string mensajeResultadoEsperado = "El factorial de 5 es: 120";

            factorial.iterativoFactorial(numero, out resultado, out mensajeResultado);

            Assert.AreEqual(resultadoEsperado, resultado);
            Assert.AreEqual(mensajeResultadoEsperado, mensajeResultado);
        }

        /// <summary>
        /// Factorial de -1
        /// </summary>
        [TestMethod]
        public void FactorialNegativoMenos1()
        {
            LogicaFactorial factorial = new LogicaFactorial();
            int numero = -1;
            int resultado = 0;
            string mensajeResultado = "";

            string mensajeResultadoEsperado = "El numero introducido es negativo";

            factorial.iterativoFactorial(numero, out resultado, out mensajeResultado);

            Assert.AreEqual(mensajeResultadoEsperado, mensajeResultado);
        }

        /// <summary>
        /// Factorial MaxValue
        /// </summary>
        [TestMethod]
        public void FactorialPositivoNumMaxValue()
        {
            LogicaFactorial factorial = new LogicaFactorial();
            int numero = int.MaxValue;
            int resultado = 0;
            string mensajeResultado = "";

            int resultadoEsperado = 0;

            factorial.iterativoFactorial(numero, out resultado, out mensajeResultado);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
