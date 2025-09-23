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
    public partial class JanelaEntrada : Form
    {
        ClienteDAO clienteDAO;
        ProdutoDAO produtoDAO;
        List<Produtos> produtos = new List<Produtos>();
        public JanelaEntrada()
        {
            InitializeComponent();
            clienteDAO = new ClienteDAO();
            produtoDAO = new ProdutoDAO();
        }

        private void tfIdFornecedor_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tfIdFornecedor.Text))
            {
                try
                {
                    Convert.ToInt32(tfIdFornecedor.Text);
                }
                catch
                {
                    MessageBox.Show("Cadastro não encontrado!");
                    tfIdFornecedor.Focus();
                    return;
                }
                DataTable dt = clienteDAO.NomeById(tfIdFornecedor.Text);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = null;
                    row = dt.Rows[0];

                    tfFornecedor.Text = row["nome"].ToString().ToUpper();
                }
                else
                {
                    MessageBox.Show("Cadastro não encontrado");
                    tfFornecedor.Text = string.Empty;
                    tfIdFornecedor.Text = string.Empty;
                    tfIdFornecedor.Focus();
                }
            }
            else
            {
                tfFornecedor.Text = string.Empty;
            }

        }

        private void tfFornecedor_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tfFornecedor.Text))
            {
                DataTable dt = clienteDAO.CodigoByNome(tfFornecedor.Text);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = null;
                    row = dt.Rows[0];

                    tfIdFornecedor.Text = row["codigo"].ToString();
                    tfFornecedor.Text = row["nome"].ToString().ToUpper();
                }
                else
                {
                    MessageBox.Show("Cadastro não encontrado");
                    tfFornecedor.Text = string.Empty;
                    tfIdFornecedor.Text = string.Empty;
                    tfFornecedor.Focus();
                }
            }
            else
            {
                tfIdFornecedor.Text = string.Empty;
            }
        }

        private void tfIdProduto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tfIdProduto.Text))
            {

                try
                {
                    Convert.ToInt32(tfIdProduto.Text);
                }
                catch
                {
                    MessageBox.Show("Produto não encontrado!");
                    tfIdProduto.Text = string.Empty;
                    tfProduto.Text = string.Empty;
                    tfIdProduto.Focus();
                    return;
                }

                DataTable dt = produtoDAO.ListarNomeById(tfIdProduto.Text);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = null;
                    row = dt.Rows[0];

                    tfProduto.Text = row["descricao"].ToString().ToUpper();
                    tfQuantidade.Text = "1";
                    tfQuantidade.Focus();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado!");
                    tfIdProduto.Text = string.Empty;
                    tfIdProduto.Focus();
                    tfProduto.Text = string.Empty;
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tfIdProduto.Text) || !string.IsNullOrEmpty(tfProduto.Text) || !string.IsNullOrEmpty(tfQuantidade.Text))
            {
                tfIdProduto.Text = string.Empty;
                tfProduto.Text = string.Empty;
                tfQuantidade.Text = string.Empty;
                tfIdProduto.Focus();
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tfIdProduto.Text) && !string.IsNullOrEmpty(tfQuantidade.Text))
            {
                Produtos p = new Produtos();

                p.codigo = Convert.ToInt32(tfIdProduto.Text);
                p.descricao = tfProduto.Text;
                p.quantidade = Double.Parse(tfQuantidade.Text);

                produtos.Add(p);

                dataGridView1.Rows.Add(p.codigo.ToString(), p.descricao, p.quantidade.ToString());

                dataGridView1.ClearSelection();

                tfIdProduto.Text = string.Empty;
                tfProduto.Text = string.Empty;
                tfQuantidade.Text = string.Empty;
                tfIdProduto.Focus();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos do produto a ser lançado!");
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            if (produtos.Count > 0)
            {
                produtos.Clear();
                dataGridView1.Rows.Clear();
            }
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        { }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        { }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (produtos.Count > 0)
            {
                Entrada entrada = new Entrada();
                if (string.IsNullOrEmpty(tfIdFornecedor.Text))
                {
                    produtoDAO.Entrada(entrada, produtos);
                }
                else
                {
                    Clientes c = new Clientes();
                    c.codigo = Convert.ToInt32(tfIdFornecedor.Text);
                    c.nome = tfFornecedor.Text;
                    produtoDAO.Entrada(entrada, c, produtos);
                    tfIdFornecedor.Text = string.Empty;
                    tfFornecedor.Text = string.Empty;
                }
                produtos.Clear();
                dataGridView1.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Não é possível finalizar um lançamento de entrada sem produtos!");
                tfIdProduto.Focus();
            }
        }

        private void btCancelarTudo_Click(object sender, EventArgs e)
        {
            if (produtos.Count > 0 || !string.IsNullOrEmpty(tfIdFornecedor.Text) || !string.IsNullOrEmpty(tfIdProduto.Text))
            {
                DialogResult resultado = MessageBox.Show("Cancelar entrada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    produtos.Clear();
                    dataGridView1.Rows.Clear();

                    tfFornecedor.Text = string.Empty;
                    tfIdFornecedor.Text = string.Empty;
                    tfIdProduto.Text = string.Empty;
                    tfProduto.Text = string.Empty;
                    tfQuantidade.Text = string.Empty;

                    tfIdProduto.Focus();
                }
            }
            else {
                Dispose();
            }
        }
    }
}
