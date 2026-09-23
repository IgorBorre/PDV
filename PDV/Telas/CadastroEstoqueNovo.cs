using PDV.Classes;
using System.Data;

namespace PDV
{
    public partial class CadastroEstoqueNovo : Form
    {
        readonly GrupoDAO grupoDAO;
        private readonly CadastroEstoque _cadastroEstoque;
        private readonly ProdutoDAO _produtoDAO;
        public CadastroEstoqueNovo(CadastroEstoque cadastroEstoque, ProdutoDAO produtoDAO)
        {
            InitializeComponent();
            grupoDAO = new();
            _cadastroEstoque = cadastroEstoque;
            _produtoDAO = produtoDAO;
        }

        private void CadastroEstoqueNovo_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfCodigo.Text))
            {
                /*se o campo TfCodigo estiver preenchido ao abrir a janela, a função de listar produtos 
                pelo id é chamada*/
                DataTable dt = _produtoDAO.ListarProdutoByiD(TfCodigo.Text);
                DataRow row = dt.Rows[0];

                //preenchendo os campos com os valores das linhas da tabela dt
                TfDescricao.Text = row["descricao"].ToString();
                TfEstoque.Text = row["estoque"].ToString();
                TfGrupo.Text = row["grupo"].ToString();
                TfIdGrupo.Text = row["idGrupo"].ToString();
                TfPreco.Text = row["preco"].ToString();
                TfReferencia.Text = row["referencia"].ToString();
                TfEstoque.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produtos p = new()
            {
                referencia = TfReferencia.Text,
                descricao = TfDescricao.Text
            };
            /*se o campo TfIdGrupo estiver preenchido, o id é convertido para int para inserção no banco,
            e o atributo grupo na classe Produtos é preenchido com o valor do campo TfGrupo*/
            if (!string.IsNullOrEmpty(TfIdGrupo.Text))
            {
                p.idGrupo = int.Parse(TfIdGrupo.Text);
                p.grupo = TfGrupo.Text;
            }

            if (_produtoDAO.Validacoes(TfDescricao.Text, TfEstoque.Text, TfPreco.Text))
            {
                p.estoque = double.Parse(TfEstoque.Text);
                p.preco = double.Parse(TfPreco.Text);

                //se o campo TfCodigo estiver vazio, o código chamado será o de inserção no banco
                if (string.IsNullOrEmpty(TfCodigo.Text))
                {
                    if (!_produtoDAO.ReferenciaExiste(p.referencia))
                    {
                        _produtoDAO.InserirProduto(p);
                        TfCodigo.Text = p.codigo.ToString();
                        if (!string.IsNullOrEmpty(_cadastroEstoque.c))
                        {
                            DataTable dt = _produtoDAO.ListarProdutos(_cadastroEstoque.c);
                            _cadastroEstoque.dataGridView1.DataSource = dt;
                            _cadastroEstoque.dataGridView1.ClearSelection();
                        }
                        else
                        {
                            DataTable dt = new();

                            dt.Columns.Add("codigo");
                            dt.Columns.Add("referencia");
                            dt.Columns.Add("descricao");
                            dt.Columns.Add("estoque");
                            dt.Columns.Add("preco");

                            DataRow row = dt.NewRow();

                            row["codigo"] = p.codigo;
                            row["referencia"] = p.referencia;
                            row["descricao"] = p.descricao;
                            row["estoque"] = p.estoque;
                            row["preco"] = p.preco.ToString("F2");

                            dt.Rows.Add(row);

                            _cadastroEstoque.dataGridView1.DataSource = dt;
                            _cadastroEstoque.dataGridView1.ClearSelection();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Referência já cadastrada!");
                        TfReferencia.Focus();
                    }
                }
                //se não, o código chamado será o de atualização das informações no banco
                else
                {
                    if (!_produtoDAO.ReferenciaExiste(p.referencia))
                    {
                        p.codigo = int.Parse(TfCodigo.Text);
                        _produtoDAO.AtualizarProduto(p);
                        DataTable dt = _produtoDAO.ListarProdutos(_cadastroEstoque.c);
                        _cadastroEstoque.dataGridView1.DataSource = dt;
                        _cadastroEstoque.dataGridView1.ClearSelection();
                    }
                    else { 
                        MessageBox.Show("Referência já cadastrada!");
                        TfReferencia.Focus();
                    }
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
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    TfIdGrupo.Text = row["id"].ToString();
                    TfGrupo.Text = row["nome"].ToString();
                }
                else
                {
                    MessageBox.Show("Grupo não encontado!");
                    TfIdGrupo.Text = string.Empty;
                    TfGrupo.Focus();
                }
            }
            else {
                TfIdGrupo.Text = string.Empty;
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
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    TfGrupo.Text = row["nome"].ToString();
                }
                else
                {
                    MessageBox.Show("Grupo não encontrado!");
                    TfIdGrupo.Focus();
                    TfGrupo.Text = string.Empty;
                }
            }
            else { 
                TfGrupo.Text = string.Empty;
            }
        }
    }
}
