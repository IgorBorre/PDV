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
    public partial class ConfirmarPagamento : Form
    {
        private JanelaPagamento janelaPagamento;
        public double ValorPago;
        public int Parcelas;
        public ConfirmarPagamento(JanelaPagamento janelaPagamento)
        {
            InitializeComponent();
            this.janelaPagamento = janelaPagamento;
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
           
            double pago = Convert.ToDouble(TfValor.Text);
            int parcelas = Convert.ToInt32(TfParcelas.Text);

            if (pago > 0 && parcelas > 0)
            {
                ValorPago = pago;
                Parcelas = parcelas;
                double aux = Convert.ToDouble(janelaPagamento.LbFalta.Text);
                double falta = aux - pago;

                // Atualiza o valor pago na venda
                janelaPagamento.LbPago.Text = (Convert.ToDouble(janelaPagamento.LbPago.Text) + pago).ToString("F2");


                double total = Convert.ToDouble(janelaPagamento.LbTotal.Text);

                // se o valor pago for igual ou maior que o valor total da venda, habilita o botão finalizar
                if (Convert.ToDouble(janelaPagamento.LbPago.Text) >= total)
                {
                    janelaPagamento.BtFinalizar.Enabled = true;
                }


                if (falta > 0)
                {
                    // se o valor da variável falta for maior que 0, atualizar a label com o valor da variável falta
                    janelaPagamento.LbFalta.Text = falta.ToString("F2");
                }
                else
                {
                    // se for menor que 0, a label falta recebe 0 e o valor excedente é mostrado na label troco
                    janelaPagamento.LbFalta.Text = "0,00";
                    double troco = (Convert.ToDouble(janelaPagamento.LbPago.Text) - total);
                    janelaPagamento.LbTroco.Text = troco.ToString("F2");
                }
                this.DialogResult = DialogResult.OK;

                Dispose();
            }
            else
            {
                MessageBox.Show("Valores inválidos!");
                TfValor.Focus();
            }
        }
    }
}
