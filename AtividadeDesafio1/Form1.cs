using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeDesafio1
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void txtCalcular_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double p, a, i;

            p = double.Parse(TxtPeso.Text);
            a = double.Parse(TxtAltura.Text);
            i = p / (a * a);

            lbnResultado.Text = i.ToString();

            if (i <= 18.5)
            {
                TxtImc.Text= i.ToString();
                lbnResultado.Text = "Voce está abaixo do peso! ";
            }
            else if (i > 18.6 && i <= 24.9)
            {
                TxtImc.Text = i.ToString();

                lbnResultado.Text = " Voce está com o peso ideal! ";
            }
            else if (i > 24.9 && i <= 29.9)
            {
                TxtImc.Text = i.ToString();

                lbnResultado.Text = "Voce está levemente acima do peso! ";
            }
            else if (i > 30.0 && i <= 34.9)
            {
                TxtImc.Text = i.ToString();

                lbnResultado.Text = " Voce está com grau 1 de Obesidade! ";
            }
            else if (i > 35.0 && i <= 39.9)
            {

                TxtImc.Text = i.ToString();

                lbnResultado.Text = "Voce esta com grau 2 de Obesidade (Severa) ";
            }
            else
            {
                TxtImc.Text = i.ToString();

                lbnResultado.Text = "Voce está com grau 3 de Obesidade (Morbida) ";
            }

            if (a <= 0 || p <= 0)
            {
                TxtPeso.Clear();
                TxtAltura.Clear();
                lbnResultado.Text = "";
                TxtImc.Text = "";
                MessageBox.Show("A sua altura ou Peso está Inválidos!");
            }
        }
    }
}
