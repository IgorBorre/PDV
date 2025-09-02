using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Internal;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class JanelaPagamento : Form
    {
        private FormasdePagamentoDAO formasdePagamentoDAO;
        public JanelaPagamento()
        {
            InitializeComponent();
            formasdePagamentoDAO = new FormasdePagamentoDAO();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void JanelaPagamento_Load(object sender, EventArgs e)
        {


            this.TopMost = true;
            this.BringToFront();
            this.Focus();
            string c = "SELECT id, descricao FROM formas_pagamento WHERE ativa = 'Sim'";
            formasdePagamentoDAO.ListarFormasdePagamento(c);
            dataGridView1.DataSource = formasdePagamentoDAO.ListarFormasdePagamento(c);
            BtFinalizar.Enabled = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            double falta = Convert.ToDouble(LbFalta.Text);
            if (falta > 0)
            {
                ConfirmarPagamento confirmarPagamento = new ConfirmarPagamento(this);
                confirmarPagamento.Show();
                //confirmarPagamento.ShowDialog();
                confirmarPagamento.TopMost = true;
                confirmarPagamento.BringToFront();
                confirmarPagamento.Focus();
                confirmarPagamento.TfValor.Text = LbFalta.Text;

                /*if (confirmarPagamento.DialogResult == DialogResult.OK)
                {
                    double pago = confirmarPagamento.ValorPago;
                    int parcelas = confirmarPagamento.Parcelas;
                }*/
            }
            else
            {
                MessageBox.Show("Pagamento já efetuado!");
            }

        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            LbFalta.Text = LbTotal.Text;
            LbPago.Text = "0,00";
            BtFinalizar.Enabled = false;
            LbTroco.Text = "0,00";
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtFinalizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
