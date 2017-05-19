using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaHectorSala.Primos
{
    /// <summary>
    /// Clase que representa una aplicacion que muestra los numeros primos dentro de un rango.
    /// </summary>
    public partial class Primos : Form
    {
        /// <summary>
        /// Constructor de la clase Primos.
        /// </summary>
        public Primos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que lanza un metodo de la clase Primos.
        /// </summary>
        /// <remarks>Se debe introducir el numero más pequeño en el primer textbox y el mas grande en el segundo.</remarks>
        /// <param name="sender">Lanza el evento en el boton button1_Click.</param>
        /// <param name="e">Si uso.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            bool correcto, correcto2;

            correcto = int.TryParse(tNum1.Text, out num1);
            correcto2 = int.TryParse(tNum2.Text, out num2);

            try
            {
                if (correcto && correcto2)
                {
                    MessageBox.Show(LogicaPrimos.sacarPrimos(num1, num2));
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

        private void tNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
