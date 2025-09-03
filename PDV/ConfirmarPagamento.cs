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

            ValorPago = Convert.ToDouble(TfValor.Text);
            Parcelas = Convert.ToInt32(TfParcelas.Text);


            if (ValorPago > 0 && Parcelas > 0)
            {

                this.DialogResult = DialogResult.OK;

                Dispose();
            }
            else
            {
                MessageBox.Show("Valores inválidos!");
                TfValor.Focus();
            }
        }

        private void ConfirmarPagamento_Load(object sender, EventArgs e)
        {
            //this.Show();
            //this.ShowDialog();
            this.TopMost = true;
            this.BringToFront();
            this.Focus();
            TfValor.Text = janelaPagamento.LbFalta.Text;
        }
    }
}
