using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NavajaHectorSala.Fibonacci;

namespace FibonacciTest
{
    /// <summary>
    /// Clase de prueba de la aplicacion Fibonacci.
    /// </summary>
    [TestClass]
    public class PruebaFibonacci
    {
        /// <summary>
        /// 0 sucesiones de fibonacci
        /// </summary>
        [TestMethod]
        public void FibonacciNum0()
        {
            LogicaFibonacci fibonacci = new LogicaFibonacci();
            int numero = 0;
            string mensajeResultado = "";

            string mensajeResultadoEsperado = "Introduce un numero distinto a cero";

            fibonacci.fibonacci(numero, out mensajeResultado);

            Assert.AreEqual(mensajeResultadoEsperado, mensajeResultado);
        }

        /// <summary>
        /// 1 sucesion de fibonacci
        /// </summary>
        [TestMethod]
        public void FibonacciPositivoNum1()
        {
            LogicaFibonacci fibonacci = new LogicaFibonacci();
            int numero = 1;
            string mensajeResultado = "";

            string mensajeResultadoEsperado = "1 + ";

            fibonacci.fibonacci(numero, out mensajeResultado);

            Assert.AreEqual(mensajeResultadoEsperado, mensajeResultado);
        }

        /// <summary>
        /// 5 sucesiones de fibonacci
        /// </summary>
        [TestMethod]
        public void FibonacciPositivoNum5()
        {
            LogicaFibonacci fibonacci = new LogicaFibonacci();
            int numero = 5;
            string mensajeResultado = "";

            string mensajeResultadoEsperado = "1 + 1 + 2 + 3 + 5 + ";

            fibonacci.fibonacci(numero, out mensajeResultado);

            Assert.AreEqual(mensajeResultadoEsperado, mensajeResultado);
        }

        /// <summary>
        /// Numero negativo de sucesiones de fibonacci
        /// </summary>
        [TestMethod]
        public void FibonacciNegativoNumMenos1()
        {
            LogicaFibonacci fibonacci = new LogicaFibonacci();
            int numero = -1;
            string mensajeResultado = "";

            string mensajeResultadoEsperado = "El numero introducido es negativo";

            fibonacci.fibonacci(numero, out mensajeResultado);

            Assert.AreEqual(mensajeResultadoEsperado, mensajeResultado);
        }
    }
}
