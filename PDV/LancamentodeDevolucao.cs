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
    public partial class LancamentodeDevolucao : Form
    {
        public LancamentodeDevolucao()
        {
            InitializeComponent();
        }

        private void LancamentodeDevolucao_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void BtFinalizar_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.Rows.Count > 0) { 

            //}
        }

        private void BtOriginais_Click(object sender, EventArgs e)
        {
            ItensOriginais itens = new ItensOriginais();
            string c = "select codigo, referencia, descricao, quantidade from produtos join saidadados on produtos.codigo = saidadados.produto " +
                        "where saidadados.documento = " + LbDocumento.Text;
            VendaDAO v = new VendaDAO();
            DataTable dt = v.ConsultaSaidas(c);
            itens.dataGridView1.DataSource = dt;

            itens.ShowDialog();
        }

        private void TfId_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfId.Text))
            {
                try
                {
                    int.Parse(TfId.Text);
                }
                catch
                {

                    MessageBox.Show("Produto não encontrado!");
                    TfId.Focus();
                    return;
                }


                string c = "select descricao from saidadados s join produtos p on p.codigo = s.produto where documento = " + LbDocumento.Text + " and s.produto = " + TfId.Text;
                VendaDAO v = new VendaDAO();
                DataTable dt = v.ConsultaSaidas(c);

                if (dt.Rows.Count > 0)
                {

                    DataRow row = null;
                    row = dt.Rows[0];
                    TfProduto.Text = row["descricao"].ToString();

                }
                else
                {
                    MessageBox.Show("Esse produto não pertence à venda original!");
                    TfId.Focus();
                    if (!string.IsNullOrEmpty(TfProduto.Text))
                    {
                        TfProduto.Text = string.Empty;
                    }
                }
            }
        }

        private void BtProcura_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfId.Text))
            {
                try
                {
                    int.Parse(TfId.Text);
                }
                catch
                {

                    MessageBox.Show("Produto não encontrado!");
                    TfId.Focus();
                    return;
                }


                string c = "select descricao from saidadados s join produtos p on p.codigo = s.produto where documento = " + LbDocumento.Text + " and s.produto = " + TfId.Text;
                VendaDAO v = new VendaDAO();
                DataTable dt = v.ConsultaSaidas(c);

                if (dt.Rows.Count > 0)
                {

                    DataRow row = null;
                    row = dt.Rows[0];
                    TfProduto.Text = row["descricao"].ToString();

                }
                else
                {
                    MessageBox.Show("Esse produto não pertence à venda original!");
                    TfId.Focus();
                    if (!string.IsNullOrEmpty(TfProduto.Text)) { 
                        TfProduto.Text = string.Empty;
                    }
                }
            }
        }
    }
}
