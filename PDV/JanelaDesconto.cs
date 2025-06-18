using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class JanelaDesconto : Form
    {
        double desconto = 0;
        double aux = 0;
        double acrescimo = 0;
        double total = 0;
        double subtotal = 0;

        private JanelaVenda janelaVenda;
        public JanelaDesconto(JanelaVenda janelaVenda)
        {
            InitializeComponent();
            this.janelaVenda = janelaVenda;
        }

        private void JanelaDesconto_Load(object sender, EventArgs e)
        {

        }

        private void TfDesconto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfDesconto.Text) && !string.IsNullOrEmpty(TfSubtotal.Text))
            {
                subtotal = Convert.ToDouble(TfSubtotal.Text);
                desconto = Convert.ToDouble(TfDesconto.Text);
                total = subtotal - (subtotal * (desconto / 100));
                TfTotal.Text = total.ToString();
            }
            else
            {
                TfTotal.Text = subtotal.ToString();
            }
        }

        private void TfAcrescimo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfAcrescimo.Text) && !string.IsNullOrEmpty(TfSubtotal.Text))
            {
                subtotal = Convert.ToDouble(TfSubtotal.Text);
                acrescimo = Convert.ToDouble(TfAcrescimo.Text);
                total = subtotal + (subtotal * (acrescimo / 100));
                TfTotal.Text = total.ToString();
            }
            else
            {
                TfTotal.Text = subtotal.ToString();
            }
        }

        private void TfTotal_TextChanged(object sender, EventArgs e)
        {
           if (!string.IsNullOrEmpty(TfTotal.Text))
            {
                if (Convert.ToDouble(TfTotal.Text) < Convert.ToDouble(TfSubtotal.Text))
                {
                    subtotal = Convert.ToDouble(TfSubtotal.Text);
                    total = Convert.ToDouble(TfTotal.Text);
                    desconto = ((subtotal - total) / subtotal) * 100;
                    TfDesconto.Text = desconto.ToString();
                    TfAcrescimo.Text = "0";
                }
                else { 
                    subtotal = Convert.ToDouble(TfSubtotal.Text);
                    total = Convert.ToDouble(TfTotal.Text);
                    acrescimo = ((total - subtotal) / subtotal) * 100;
                    TfAcrescimo.Text = acrescimo.ToString();
                    TfDesconto.Text = "0";
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(TfTotal.Text) <= 0)
            {
                MessageBox.Show("O total não pode ser menor ou igual a zero.");
            }
            else
            {
                janelaVenda.lblTotal.Text = string.Empty;
                janelaVenda.lblTotal.Text = TfTotal.Text;
                Dispose();
            }
        }
    }
}
