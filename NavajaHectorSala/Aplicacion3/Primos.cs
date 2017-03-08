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
    public partial class Primos : Form
    {
        public Primos()
        {
            InitializeComponent();
        }

        string sacarPrimos(int num1, int num2)
        {
            int n = 2, contador = 0;
            bool primo;
            string cadenaPrimos;

            primo = true;
            cadenaPrimos = "";

            for (int i = num1; i <= num2; i++)
            {
                while (n < i && primo)
                {
                    if (i % n == 0)
                    {
                        primo = false;
                    }
                    n++;
                }
                n = 2;
                if (primo)
                {
                    contador++;
                    cadenaPrimos = cadenaPrimos + i + ", ";
                }
                primo = true;
            }
            return cadenaPrimos;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            bool correcto, correcto2;

            correcto = int.TryParse(tNum1.Text, out num1);

            correcto2 = int.TryParse(tNum2.Text, out num2);

            if (correcto && correcto2)
            {
                MessageBox.Show(sacarPrimos(num1, num2));
            }
            else
            {
                MessageBox.Show("No es un numero");
            }

            
        }

        private void tNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
