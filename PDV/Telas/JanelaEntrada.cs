using PDV.Classes;
using System.Data;

namespace PDV
{
    public partial class JanelaEntrada : Form
    {
        readonly ClienteDAO clienteDAO;
        readonly ProdutoDAO produtoDAO;
        readonly List<Produtos> produtos = [];
        public JanelaEntrada()
        {
            InitializeComponent();
            clienteDAO = new();
            produtoDAO = new();
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
                    DataRow row = dt.Rows[0];

                    tfFornecedor.Text = (row["nome"]?.ToString() ?? string.Empty).ToUpper();
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
                    DataRow row = dt.Rows[0];

                    tfIdFornecedor.Text = row["codigo"].ToString();
                    tfFornecedor.Text = (row["nome"]?.ToString() ?? string.Empty).ToUpper();
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
                    DataRow row = dt.Rows[0];

                    tfProduto.Text = (row["descricao"]?.ToString() ?? string.Empty).ToUpper();
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
                Produtos p = new()
                {
                    codigo = Convert.ToInt32(tfIdProduto.Text),
                    descricao = tfProduto.Text,
                    quantidade = Double.Parse(tfQuantidade.Text)
                };

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


        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (produtos.Count > 0)
            {
                Entrada entrada = new();
                if (string.IsNullOrEmpty(tfIdFornecedor.Text))
                {
                    produtoDAO.Entrada(entrada, produtos);
                }
                else
                {
                    Clientes c = new()
                    {
                        codigo = Convert.ToInt32(tfIdFornecedor.Text),
                        nome = tfFornecedor.Text
                    };
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
            else
            {
                Dispose();
            }
        }

        private void tfIdFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void tfIdProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void tfQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

    }
}
