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

        private void lan�amentoDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaEntrada janelaEntrada = new JanelaEntrada();
            janelaEntrada.ShowDialog();
        }

        private void consultaDeSa�dasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaConsultaSaidas janelaConsulta = new JanelaConsultaSaidas();
            janelaConsulta.Show();
        }

        private void consultaDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEntradas consultaEntradas = new ConsultaEntradas();
            consultaEntradas.Show();
        }

        private void cancelamentoDeSa�dasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaCancelamentodeSaidas cancelamento = new JanelaCancelamentodeSaidas();
            cancelamento.Show();
        }

        private void consultaDeCancelamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaConsultaCancelamento janelaConsultaCancelamento = new JanelaConsultaCancelamento();
            janelaConsultaCancelamento.Show();
        }
    }
}
