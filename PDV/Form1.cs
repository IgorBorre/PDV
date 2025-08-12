using MySql.Data.MySqlClient;

namespace PDV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Conexao conexao = new Conexao();
            conexao.AbrirConexao();
        }

        private void cadastroGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroGeral form = new CadastroGeral();
            form.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroEstoque formEstoque = new CadastroEstoque();
            formEstoque.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrupoCadastro grupo = new GrupoCadastro();
            grupo.ShowDialog();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaVenda janelaVenda = new JanelaVenda();
            janelaVenda.ShowDialog();
        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormasPagamento formasPagamento = new FormasPagamento();
            formasPagamento.ShowDialog();
        }
    }
}
