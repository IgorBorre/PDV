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
        double acrescimo = 0;
        double total = 0;
        double subtotal = 0;
        bool atualizandoCampo = false; //variavel para verificar se o campo está sendo atualizado no momento ou não

        private JanelaVenda janelaVenda;
        public JanelaDesconto(JanelaVenda janelaVenda)
        {
            InitializeComponent();
            this.janelaVenda = janelaVenda;
        }

        private void JanelaDesconto_Load(object sender, EventArgs e)
        {

            this.TopMost = true;
            this.BringToFront();
            this.Focus();
        }

        private void TfDesconto_TextChanged(object sender, EventArgs e)
        {
            if (atualizandoCampo) return;

            if (!string.IsNullOrEmpty(TfDesconto.Text) && !string.IsNullOrEmpty(TfSubtotal.Text))
            {
                try
                {
                    atualizandoCampo = true;
                    subtotal = Convert.ToDouble(TfSubtotal.Text);
                    desconto = Convert.ToDouble(TfDesconto.Text);
                    total = subtotal - (subtotal * (desconto / 100));
                    TfTotal.Text = total.ToString();
                }
                catch { }

                finally { 
                    atualizandoCampo = false; 
                }
            }
            else
            {
                TfTotal.Text = subtotal.ToString();
            }
        }

        private void TfAcrescimo_TextChanged(object sender, EventArgs e)
        {
            if (atualizandoCampo) return;

            if (!string.IsNullOrEmpty(TfAcrescimo.Text) && !string.IsNullOrEmpty(TfSubtotal.Text))
            {
                try
                {
                    atualizandoCampo = true;
                    subtotal = Convert.ToDouble(TfSubtotal.Text);
                    acrescimo = Convert.ToDouble(TfAcrescimo.Text);
                    total = subtotal + (subtotal * (acrescimo / 100));
                    TfTotal.Text = total.ToString();
                }
                catch { }
                finally { 
                    atualizandoCampo = false; 
                }
            }
            else
            {
                TfTotal.Text = subtotal.ToString();
            }
        }

        private void TfTotal_TextChanged(object sender, EventArgs e)
        {
            if (atualizandoCampo) return;

            if (!string.IsNullOrEmpty(TfTotal.Text))
            {
                try
                {
                    atualizandoCampo = true;
                    subtotal = Convert.ToDouble(TfSubtotal.Text);
                    total = Convert.ToDouble(TfTotal.Text);

                    if (total < subtotal)
                    {
                        desconto = ((subtotal - total) / subtotal) * 100;
                        TfDesconto.Text = desconto.ToString();
                        TfAcrescimo.Text = "0";
                    }
                    else
                    {
                        acrescimo = ((total - subtotal) / subtotal) * 100;
                        TfAcrescimo.Text = acrescimo.ToString();
                        TfDesconto.Text = "0";
                    }
                }
                catch { }
                finally { atualizandoCampo = false; }
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

        private void TfSubtotal_Leave(object sender, EventArgs e)
        {

        }

        private void TfDesconto_Leave(object sender, EventArgs e)
        {
            
        }

        private void TfAcrescimo_Leave(object sender, EventArgs e)
        {
            
        }

        private void TfTotal_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
