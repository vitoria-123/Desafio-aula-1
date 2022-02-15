using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_aula_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, soma;
            if (txtNumero1.Text == string.Empty){
                MessageBox.Show("Texto em branco na 1 caixa");
            }
            else
            {
                if (txtNumero2.Text == string.Empty)
                {
                    MessageBox.Show("Texto em branco na 2 caixa");
                }
            }
            n1 = Convert.ToDouble(txtNumero1.Text);
            n2 = Convert.ToDouble(txtNumero2.Text);
            soma = n1 + n2;
            txtSoma.Text = Convert.ToString(soma);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            txtSoma.Text = string.Empty;
        }
    }
}
