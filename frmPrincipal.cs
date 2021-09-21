using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Luciano
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btExecutar_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            c = Convert.ToInt32(txtC.Text);

            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
               
                Console.Write("Formam triângulo!");

                if ((a == b) && (b == c))
                {

                    MessageBox.Show("Triângulo Equilátero");

                }
                else if ((a == b) || (b == c) || (a == c))
                {

                    MessageBox.Show("Triângulo Isóceles");
                }
                else
                {

                    MessageBox.Show("Triângulo Escaleno");
                }

            }
            else
            {

                MessageBox.Show("Os valores não formam um triangulo");
            }
        }
    }
}
