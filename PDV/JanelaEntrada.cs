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
                List<Produtos> produtos = new List<Produtos>();
                Produtos p = new Produtos();

                p.codigo = Convert.ToInt32(tfIdProduto.Text);
                p.descricao = tfProduto.Text;
                p.quantidade = Double.Parse(tfQuantidade.Text);

                produtos.Add(p);

                string linha = p.codigo.ToString() + " " + p.descricao.ToString()
                    + " "+ p.quantidade.ToString();
                listBox1.Items.Add(linha);

                tfIdProduto.Text = string.Empty;
                tfProduto.Text = string.Empty;
                tfQuantidade.Text = string.Empty;
                tfIdProduto.Focus();
            }
            else {
                MessageBox.Show("Preencha todos os campos do produto a ser lançado!");
            }
        }
    }
}
