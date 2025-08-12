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
            //double aux1;
            double pago = Convert.ToDouble(TfValor.Text);
            double aux = Convert.ToDouble(janelaPagamento.LbFalta.Text);
            double falta = aux - pago;
            janelaPagamento.LbPago.Text = (Convert.ToDouble(janelaPagamento.LbPago.Text) + pago).ToString("F2");
            janelaPagamento.LbFalta.Text = falta.ToString("F2");
            Dispose();
        }
    }
}
