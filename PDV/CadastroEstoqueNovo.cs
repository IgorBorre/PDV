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
    public partial class CadastroEstoqueNovo : Form
    {
        ProdutoDAO produtoDAO;
        public CadastroEstoqueNovo()
        {
            InitializeComponent();
            produtoDAO = new ProdutoDAO();
        }

        private void CadastroEstoqueNovo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produtos p = new Produtos();
            p.referencia = TfReferencia.Text;
            p.descricao = TfDescricao.Text;
            p.estoque = int.Parse(TfEstoque.Text);
            p.preco = double.Parse(TfPreco.Text);
            

            if (string.IsNullOrEmpty(TfCodigo.Text))
            {
                if (produtoDAO.Validacoes(p))
                {
                    produtoDAO.InserirProduto(p);
                    TfCodigo.Text = p.codigo.ToString();
                }
            }
            else
            {
                if (produtoDAO.Validacoes(p))
                {
                    p.codigo = int.Parse(TfCodigo.Text);
                    produtoDAO.AtualizarProduto(p);
                }

            }
        }
    }
}
