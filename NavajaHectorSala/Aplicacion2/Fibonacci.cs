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
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        string fibonacci(int numeroSucesiones)
        {
            int numeroAnterior, numeroSiguiente, numeroSuma;
            string texto = "0 ";

            numeroAnterior = 1;
            numeroSiguiente = 1;
            numeroSuma = 0;

            for (int i = 0; i < numeroSucesiones; i++)
            {

                numeroAnterior = numeroSiguiente;
                numeroSiguiente = numeroSuma;
                numeroSuma = numeroAnterior + numeroSiguiente;
                texto = texto + " + " + numeroSuma;
            }

            return texto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroSucesiones;

            numeroSucesiones = int.Parse(tNum.Text);

            MessageBox.Show(fibonacci(numeroSucesiones)+"");
        }

        private void tnum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
