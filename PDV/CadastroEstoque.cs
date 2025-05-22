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
    public partial class CadastroEstoque : Form
    {
        private ProdutoDAO produtoDAO;
        public CadastroEstoque()
        {
            InitializeComponent();
            produtoDAO = new ProdutoDAO();
        }

        private void CadastroEstoque_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //for que percorre o form e limpa todos os campos
            foreach (Control control in this.Controls)
            {

                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroEstoqueNovo cadastroEstoqueNovo = new CadastroEstoqueNovo();
            cadastroEstoqueNovo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //filtros para a pesquisa dos produtos no banco
            string c = "select codigo, referencia, descricao, estoque, preco from produtos where 1" + produtoDAO.Criterios(TfCodigo.Text, TfReferencia.Text, TfDescricao.Text, TfGrupo.Text);
            DataTable dt = produtoDAO.ListarProdutos(c);

            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Produto não encontrado!");
                TfCodigo.Text = string.Empty;
                TfDescricao.Text = string.Empty;
                TfGrupo.Text = string.Empty; ;
                TfReferencia.Text = string.Empty;
                TfCodigo.Focus();
            }
        }

        private void CadastroEstoque_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //duplo clique na linha da tabela abre a janela de cadastro de produtos com o código do produto
            //selecionado
            CadastroEstoqueNovo cadastroEstoqueNovo = new CadastroEstoqueNovo();

            cadastroEstoqueNovo.TfCodigo.Text = dataGridView1.CurrentRow.Cells["Código"].Value.ToString();

            cadastroEstoqueNovo.ShowDialog();
        }

        private void CadastroEstoque_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TfCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void TfGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void TfReferencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void TfDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
