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
        double quantidadeOriginal = 0;
        List<Produtos> produtos = new List<Produtos>();
        ItensOriginais itens;
        public LancamentodeDevolucao()
        {
            InitializeComponent();
            itens = new ItensOriginais();
        }

        private void LancamentodeDevolucao_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {

        }

        private void BtFinalizar_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.Rows.Count > 0) { 

            //}
        }

        private void BtOriginais_Click(object sender, EventArgs e)
        {

            string c = "select codigo, referencia, descricao, quantidade from produtos join saidadados on produtos.codigo = saidadados.produto " +
                        "where saidadados.documento = " + LbDocumento.Text;

            VendaDAO v = new VendaDAO();
            DataTable dt = v.ConsultaSaidas(c);

            itens.dataGridView1.AutoGenerateColumns = false;
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


                string c = "select codigo, referencia, descricao, quantidade from saidadados s join produtos p on p.codigo = s.produto where documento = " + LbDocumento.Text + " and s.produto = " + TfId.Text;
                VendaDAO v = new VendaDAO();
                DataTable dt = v.ConsultaSaidas(c);

                if (dt.Rows.Count > 0)
                {

                    DataRow row = null;
                    row = dt.Rows[0];
                    TfProduto.Text = row["descricao"].ToString();
                    quantidadeOriginal = double.Parse(row["quantidade"].ToString());
                    LbCodigo.Text = row["codigo"].ToString();
                    LbDescricao.Text = row["descricao"].ToString();
                    LbReferencia.Text = row["referencia"].ToString();

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
            else
            {
                TfProduto.Text = string.Empty;
                LbCodigo.Text = string.Empty;
                LbDescricao.Text = string.Empty;
                LbReferencia.Text = string.Empty;
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


                string c = "select codigo, referencia, descricao, quantidade from saidadados s join produtos p on p.codigo = s.produto where documento = " + LbDocumento.Text + " and s.produto = " + TfId.Text;
                VendaDAO v = new VendaDAO();
                DataTable dt = v.ConsultaSaidas(c);

                if (dt.Rows.Count > 0)
                {

                    DataRow row = null;
                    row = dt.Rows[0];
                    TfProduto.Text = row["descricao"].ToString();
                    LbCodigo.Text = row["codigo"].ToString();
                    LbDescricao.Text = row["descricao"].ToString();
                    LbReferencia.Text = row["referencia"].ToString();

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

        private void TfQuantidade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfQuantidade.Text))
            {
                try
                {
                    double quantidade = 0;
                    var produto = produtos.FirstOrDefault(p => p.codigo == Convert.ToInt32(TfId.Text));
                    var quantidadeProduto = produto != null ? produto.quantidade : 0;
                    quantidade = double.Parse(TfQuantidade.Text) + quantidadeProduto;


                    if (quantidade > quantidadeOriginal)
                    {
                        MessageBox.Show("A quantidade devolvida não pode ser maior que a quantidade original!");
                        TfQuantidade.Text = string.Empty;
                        TfQuantidade.Focus();
                    }
                }
                catch
                {

                    MessageBox.Show("Digite uma quantidade válida!");
                    TfQuantidade.Text = string.Empty;
                    TfQuantidade.Focus();
                }

            }
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfId.Text) && !string.IsNullOrEmpty(TfQuantidade.Text))
            {
                double soma = 0;

                string c = "select referencia from produtos where codigo = " + TfId.Text;
                ProdutoDAO pDAO = new ProdutoDAO();
                DataTable dt = pDAO.ListarProdutos(c);
                DataRow row = null;
                row = dt.Rows[0];

                Produtos p = new Produtos();
                p.codigo = int.Parse(TfId.Text);
                p.descricao = TfProduto.Text;
                p.referencia = row["referencia"].ToString();
                p.quantidade = double.Parse(TfQuantidade.Text);

                var produto = produtos.FirstOrDefault(p => p.codigo == Convert.ToInt32(TfId.Text));
                if (produto != null)
                {
                    produto.quantidade += p.quantidade;
                    foreach (DataGridViewRow row1 in dataGridView1.Rows)
                    {
                        int codigo = Convert.ToInt32(row1.Cells["codigo"].Value);
                        if (codigo == produto.codigo)
                        {
                            row1.Cells["quantidade"].Value = produto.quantidade;
                            LbCodigo.Text = string.Empty;
                            LbDescricao.Text = string.Empty;
                            LbReferencia.Text = string.Empty;
                            break;
                        }
                    }
                }
                else
                {
                    produtos.Add(p);

                    dataGridView1.Rows.Add(p.codigo, p.descricao, p.referencia, p.quantidade);
                    LbCodigo.Text = string.Empty;
                    LbDescricao.Text = string.Empty;
                    LbReferencia.Text = string.Empty;
                }

                quantidadeOriginal -= p.quantidade;

                TfId.Text = string.Empty;
                TfProduto.Text = string.Empty;
                TfQuantidade.Text = string.Empty;
                TfId.Focus();
            }
            else
            {
                MessageBox.Show("Preencha o código do produto e a quantidade para confirmar a devolução!");
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Deseja cancelar essa devolução?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Dispose();
                }
            }
            else
            {
                Dispose();
            }
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) { 
                dataGridView1.Rows.Clear();
                produtos.Clear();
            }
            TfId.Text = string.Empty;
            TfProduto.Text= string.Empty;
            TfQuantidade.Text = string.Empty;
        }
    }
}
