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
            double n1, n2, soma, sub, mult, div;
            if (txtNumero1.Text == string.Empty && txtNumero2.Text == string.Empty && txtOperacao.Text == string.Empty)
            {
                MessageBox.Show("As caixas estão em branco");
            }
            else if (txtNumero1.Text == string.Empty)
            {
                MessageBox.Show("Texto em branco na 1 caixa");
            }
            else if (txtNumero2.Text == string.Empty)
            {
                MessageBox.Show("Texto em branco na 2 caixa");
            }
            else if (txtOperacao.Text == string.Empty)
            {
                MessageBox.Show("Qual operação você gostaria de realizar?");
            }
            else
            {
                if (txtOperacao.Text == "+")
                {
                    n1 = Convert.ToDouble(txtNumero1.Text);
                    n2 = Convert.ToDouble(txtNumero2.Text);
                    soma = n1 + n2;
                    txtResultado.Text = Convert.ToString(soma);
                }
                else if (txtOperacao.Text == "-")
                {
                    n1 = Convert.ToDouble(txtNumero1.Text);
                    n2 = Convert.ToDouble(txtNumero2.Text);
                    sub = n1 - n2;
                    txtResultado.Text = Convert.ToString(sub);
                }
                else if (txtOperacao.Text == "*" || txtOperacao.Text == "x" || txtOperacao.Text == "X" || txtOperacao.Text == ".")
                {
                    n1 = Convert.ToDouble(txtNumero1.Text);
                    n2 = Convert.ToDouble(txtNumero2.Text);
                    mult = n1 * n2;
                    txtResultado.Text = Convert.ToString(mult);
                }
                else if (txtOperacao.Text == "/")
                {
                    if (txtNumero2.Text == "0")
                    {
                        MessageBox.Show("Não existe divisão por zero");
                        txtNumero2.Text = string.Empty;
                    }
                    else
                    {
                        n1 = Convert.ToDouble(txtNumero1.Text);
                        n2 = Convert.ToDouble(txtNumero2.Text);
                        div = n1 / n2;
                        txtResultado.Text = Convert.ToString(div);
                    }
                }
                else if (txtOperacao.Text == "%")
                {
                    int nu1, nu2, mod;
                    nu1 = Convert.ToInt16(txtNumero1.Text);
                    nu2 = Convert.ToInt16(txtNumero2.Text);
                    mod = nu1 % nu2;
                    txtResultado.Text = Convert.ToString(mod);
                }
                else
                {
                    MessageBox.Show("Digite uma operação válida");
                    txtOperacao.Focus();
                    txtOperacao.Text = string.Empty;
                }
            }
        }
    

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            txtResultado.Text = string.Empty;
            txtNumero1.Focus();
        }
    }
}
