using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaHectorSala.Factorial
{
    /// <summary>
    /// Clase que representa una aplicacion que realiza el factorial de un numero.
    /// </summary>
    public partial class Factorial : Form
    {
        /// <summary>
        /// Constructor de la clase Factorial.
        /// </summary>
        public Factorial()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Realiza la factorizacion de un numero entero.
        /// </summary>
        /// <param name="num">Valor a partir del cual se realiza la factorizacion.</param>
        /// <returns>Devuelve el resultado de la factorizacion.</returns>
        int iterativoFactorial(int num)
        {
            int resultado = 1;

            for (int i = num; i > 0; i--)
            {
                resultado = resultado * i;
            }
            return resultado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            bool correcto;

            correcto = int.TryParse(tNum.Text, out num);

            if (correcto)
            {
                MessageBox.Show(iterativoFactorial(num) + "");
            }
            else
            {
                MessageBox.Show("No es un numero");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
