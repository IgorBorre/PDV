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
                /*se o campo TfCodigo estiver preenchido ao abrir a janela, a função de listar produtos 
                pelo id é chamada*/
                DataTable dt = produtoDAO.ListarProdutoByiD(TfCodigo.Text);
                DataRow row = null;
                row = dt.Rows[0];

                //preenchendo os campos com os valores das linhas da tabela dt
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

            /*se o campo TfIdGrupo estiver preenchido, o id é convertido para int para inserção no banco,
            e o atributo grupo na classe Produtos é preenchido com o valor do campo TfGrupo*/
            if (!string.IsNullOrEmpty(TfIdGrupo.Text))
            {
                p.idGrupo = int.Parse(TfIdGrupo.Text);
                p.grupo = TfGrupo.Text;
            }


            if (produtoDAO.Validacoes(TfDescricao.Text, TfEstoque.Text, TfPreco.Text))
            {


                p.estoque = double.Parse(TfEstoque.Text);
                p.preco = double.Parse(TfPreco.Text);

                //se o campo TfCodigo estiver vazio, o código chamado será o de inserção no banco
                if (string.IsNullOrEmpty(TfCodigo.Text))
                {

                    produtoDAO.InserirProduto(p);
                    TfCodigo.Text = p.codigo.ToString();

                }
                //se não, o código chamado será o de atualização das informações no banco
                else
                {

                    p.codigo = int.Parse(TfCodigo.Text);
                    produtoDAO.AtualizarProduto(p);


                }
            }
        }

        private void TfGrupo_Enter(object sender, EventArgs e)
        {

        }

        private void TfIdGrupo_Enter(object sender, EventArgs e)
        {
        }

        private void TfGrupo_Leave(object sender, EventArgs e)
        {
            /*se o campo TfGrupo estiver preenchdo, ao clicar com o cursor fora do campo, a função
            de buscar o id do grupo a partir do nome será chamada*/
            if (!string.IsNullOrEmpty(TfGrupo.Text))
            {

                /*preenche tanto o id do grupo quanto o nome do grupo nos campos TfIdGrupo e TfGrupo
                de acordo com o conteudo das linhas id e nome na tabela dt*/
                DataTable dt = grupoDAO.BuscarIdGrupo(TfGrupo.Text);
                DataRow row = null;
                row = dt.Rows[0];
                TfIdGrupo.Text = row["id"].ToString();
                TfGrupo.Text = row["nome"].ToString();
            }
            
        }

        private void TfIdGrupo_Leave(object sender, EventArgs e)
        {

            /*se o campo TfIdGrupo estiver preenchdo, ao clicar com o cursor fora do campo, a função
            de buscar o nome do grupo a partir do id será chamada*/
            if (!string.IsNullOrEmpty(TfIdGrupo.Text.ToString()))
            {

                //preenche o nome do grupo no campo TfGrupo com o conteudo da linha nome na tabela dt
                DataTable dt = grupoDAO.BuscarNomeGrupo(TfIdGrupo.Text);
                DataRow row = null;
                row = dt.Rows[0];
                TfGrupo.Text = row["nome"].ToString();
            }
        }
    }
}
