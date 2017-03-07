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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        int iterativoFactorial(int num)
        {
            int resultado = 1;

            for (int i = num; i > 0; i--)
            {
                resultado = resultado * i;
            }
            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;

            num = int.Parse(tNum.Text);

            MessageBox.Show(iterativoFactorial(num)+"");
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
