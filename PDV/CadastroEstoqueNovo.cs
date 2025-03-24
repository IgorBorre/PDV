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
        GrupoDAO grupoDAO;
        public CadastroEstoqueNovo()
        {
            InitializeComponent();
            produtoDAO = new ProdutoDAO();
            grupoDAO = new GrupoDAO();
        }

        private void CadastroEstoqueNovo_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfCodigo.Text))
            {
                DataTable dt = produtoDAO.ListarProdutoByiD(TfCodigo.Text);
                DataRow row = null;
                row = dt.Rows[0];

                TfDescricao.Text = row["descricao"].ToString();
                TfEstoque.Text = row["estoque"].ToString();
                TfGrupo.Text = row["grupo"].ToString();
                TfIdGrupo.Text = row["idGrupo"].ToString();
                TfPreco.Text = row["preco"].ToString();
                TfReferencia.Text = row["referencia"].ToString();
            }
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

            if (!string.IsNullOrEmpty(TfIdGrupo.Text))
            {
                p.idGrupo = int.Parse(TfIdGrupo.Text);
                p.grupo = TfGrupo.Text;
            }


            if (produtoDAO.Validacoes(TfDescricao.Text, TfEstoque.Text, TfPreco.Text))
            {


                p.estoque = double.Parse(TfEstoque.Text);
                p.preco = double.Parse(TfPreco.Text);

                if (string.IsNullOrEmpty(TfCodigo.Text))
                {

                    produtoDAO.InserirProduto(p);
                    TfCodigo.Text = p.codigo.ToString();

                }
                else
                {

                    p.codigo = int.Parse(TfCodigo.Text);
                    produtoDAO.AtualizarProduto(p);


                }
            }
        }

        private void TfGrupo_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfIdGrupo.Text.ToString()))
            {

                DataTable dt = grupoDAO.BuscarNomeGrupo(TfIdGrupo.Text);
                DataRow row = null;
                row = dt.Rows[0];
                TfGrupo.Text = row["nome"].ToString();
            }

        }

        private void TfIdGrupo_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfGrupo.Text)) {
                DataTable dt = grupoDAO.BuscarIdGrupo(TfGrupo.Text);
                DataRow row = null;
                row = dt.Rows[0];
                TfIdGrupo.Text = row["id"].ToString();
                TfGrupo.Text = row["nome"].ToString();
            }
        }
    }
}
