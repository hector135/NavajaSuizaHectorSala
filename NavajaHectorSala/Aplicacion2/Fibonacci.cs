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
        /// Evento que lanza un metodo de la clase Fibonacci.
        /// </summary>
        /// <param name="sender">Lanza el evento en el boton button1_Click</param>
        /// <param name="e">Si uso</param>
        private void button1_Click(object sender, EventArgs e)
        {
            LogicaFibonacci fibonacci = new LogicaFibonacci();
            int numeroSucesiones;
            bool correcto;
            string resultado;

            correcto = int.TryParse(tNum.Text, out numeroSucesiones);

            try
            {
                if (correcto)
                {
                    fibonacci.fibonacci(numeroSucesiones, out resultado);
                    MessageBox.Show(resultado);
                }
                else
                {
                    MessageBox.Show("No es un numero");
                }
            }
            catch (Exception Exception)
            {
                MessageBox.Show("Se ha producido un error" + Exception.Message);
            }
        }

        private void tnum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
