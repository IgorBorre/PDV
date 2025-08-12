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
            string c = "SELECT id, descricao FROM formas_pagamento WHERE ativa = 'Sim'";
            formasdePagamentoDAO.ListarFormasdePagamento(c);
            dataGridView1.DataSource = formasdePagamentoDAO.ListarFormasdePagamento(c);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ConfirmarPagamento confirmarPagamento = new ConfirmarPagamento(this);
            confirmarPagamento.Show();
            confirmarPagamento.TopMost = true;
            confirmarPagamento.BringToFront();
            confirmarPagamento.Focus();

            confirmarPagamento.TfValor.Text = LbFalta.Text;
        }
    }
}
