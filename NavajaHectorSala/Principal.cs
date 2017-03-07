using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaHectorSala
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // namespace.subnamespace.nombreformulario = new namespace.subnamespace.nombreformulario();

            NavajaHectorSala.Factorial.Factorial Formulario = new NavajaHectorSala.Factorial.Factorial();
            Formulario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavajaHectorSala.Fibonacci.Fibonacci Formulario = new NavajaHectorSala.Fibonacci.Fibonacci();
            Formulario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NavajaHectorSala.Primos.Primos Formulario = new NavajaHectorSala.Primos.Primos();
            Formulario.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NavajaHectorSala.Palindromo.Palindromo Formulario = new NavajaHectorSala.Palindromo.Palindromo();
            Formulario.ShowDialog();
        }
    }
}
