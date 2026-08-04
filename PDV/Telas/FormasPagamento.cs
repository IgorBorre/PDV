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
    public partial class FormasPagamento : Form
    {
        private FormasdePagamentoDAO formasdePagamentoDAO;
        public FormasPagamento()
        {
            InitializeComponent();
            formasdePagamentoDAO = new FormasdePagamentoDAO();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            FormasPagamentoNovo formasPagamentoNovo = new FormasPagamentoNovo();
            formasPagamentoNovo.ShowDialog();
        }

        private void FormasPagamento_Load(object sender, EventArgs e)
        {
            string c = "SELECT id, descricao, ativa from formas_pagamento where 1";
            formasdePagamentoDAO.ListarFormasdePagamento(c);
            dataGridView1.DataSource = formasdePagamentoDAO.ListarFormasdePagamento(c);
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        { }

        private void RbAtivas_CheckedChanged(object sender, EventArgs e)
        {
            string c = "SELECT id, descricao, ativa from formas_pagamento where ativa = 'Sim'";
            formasdePagamentoDAO.ListarFormasdePagamento(c);
            dataGridView1.DataSource = formasdePagamentoDAO.ListarFormasdePagamento(c);
            dataGridView1.ClearSelection();
        }

        private void RbInativas_CheckedChanged(object sender, EventArgs e)
        {
            string c = "SELECT id, descricao, ativa from formas_pagamento where ativa = 'Não'";
            formasdePagamentoDAO.ListarFormasdePagamento(c);
            dataGridView1.DataSource = formasdePagamentoDAO.ListarFormasdePagamento(c);
            dataGridView1.ClearSelection();
        }

        private void RbTodas_CheckedChanged(object sender, EventArgs e)
        {
            string c = "SELECT id, descricao, ativa from formas_pagamento where 1";
            formasdePagamentoDAO.ListarFormasdePagamento(c);
            dataGridView1.DataSource = formasdePagamentoDAO.ListarFormasdePagamento(c);
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormasPagamentoNovo formasPagamentoNovo = new FormasPagamentoNovo();
            formasPagamentoNovo.TfCodigo.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
            formasPagamentoNovo.ShowDialog();
        }
    }
}
