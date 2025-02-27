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
            string c = "select codigo, referencia, descricao, estoque, preco from produtos where 1" + produtoDAO.Criterios(TfCodigo.Text, TfReferencia.Text, TfDescricao.Text, TfGrupo.Text);
            dataGridView1.DataSource = produtoDAO.ListarProdutos(c);
            dataGridView1.ClearSelection();
        }

        private void CadastroEstoque_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CadastroEstoqueNovo cadastroEstoqueNovo = new CadastroEstoqueNovo();

            cadastroEstoqueNovo.TfCodigo.Text = dataGridView1.CurrentRow.Cells["Código"].Value.ToString();
            
            cadastroEstoqueNovo.ShowDialog();
        }
    }
}
