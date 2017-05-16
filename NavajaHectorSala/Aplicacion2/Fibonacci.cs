using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaHectorSala.Fibonacci
{
    /// <summary>
    /// Clase que representa una aplicacion que muestra la sucesion de fibonacci.
    /// </summary>
    public partial class Fibonacci : Form
    {
        /// <summary>
        /// Constructor de la clase Fibonacci.
        /// </summary>
        public Fibonacci()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Realiza la operacion de sumas sucesivas que conforman fibonacci devolviendo
        /// tantos numeros de la sucesión como le indicamos por parametro.
        /// </summary>
        /// <remarks>No se han de utilizar numeros negativos.</remarks>
        /// <param name="numeroSucesiones">Numero de veces que realizara las sumas sucesivas.</param>
        /// <returns>Devuelve una cadena con los numeros de la sucesion de Fibonacci.</returns>
        string fibonacci(int numeroSucesiones)
        {
            int numeroAnterior, numeroSiguiente, numeroSuma;
            string texto;

            numeroAnterior = 1;
            numeroSiguiente = 1;
            numeroSuma = 0;
            texto = "";

            for (int i = 0; i < numeroSucesiones; i++)
            {

                numeroAnterior = numeroSiguiente;
                numeroSiguiente = numeroSuma;
                numeroSuma = numeroAnterior + numeroSiguiente;
                texto = texto  + numeroSuma + " + ";
            }
            return texto;
        }

        /// <summary>
        /// Evento que lanza un metodo de la clase Fibonacci.
        /// </summary>
        /// <param name="sender">Lanza el evento en el boton button1_Click</param>
        /// <param name="e">Si uso</param>
        private void button1_Click(object sender, EventArgs e)
        {
            int numeroSucesiones;
            bool correcto;

            correcto = int.TryParse(tNum.Text, out numeroSucesiones);

            if (correcto)
            {
                MessageBox.Show(fibonacci(numeroSucesiones) + "");
            }
            else
            {
                MessageBox.Show("No es un numero");
            }
        }

        private void tnum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
