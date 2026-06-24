
namespace PDV
{
    public partial class Form1 : Form
    {
        private readonly VendaDAO _vendaDAO;

        public Form1(VendaDAO vendaDAO)
        {
            InitializeComponent();
            Conexao conexao = new();
            conexao.AbrirConexao();
            _vendaDAO = vendaDAO;
        }

        private void cadastroGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroGeral form = new();
            form.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroEstoque formEstoque = new();
            formEstoque.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrupoCadastro grupo = new();
            grupo.ShowDialog();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaVenda janelaVenda = new(_vendaDAO);
            janelaVenda.ShowDialog();
        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormasPagamento formasPagamento = new();
            formasPagamento.ShowDialog();
        }

        private void lançamentoDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaEntrada janelaEntrada = new();
            janelaEntrada.ShowDialog();
        }

        private void consultaDeSaídasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaConsultaSaidas janelaConsulta = new(_vendaDAO);
            janelaConsulta.Show();
        }

        private void consultaDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEntradas consultaEntradas = new();
            consultaEntradas.Show();
        }

        private void devoluçãoTrocaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaDevolucao janela = new(_vendaDAO);
            janela.Show();
        }

        private void cancelamentoDeEntradasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            JanelaCancelamentodeEntradas janelaCancelamentodeEntradas = new();
            janelaCancelamentodeEntradas.Show();
        }

        private void consultaDeCancelamentosToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ConsultaCancelamentoEntrada consulta = new();
            consulta.Show();
        }

        private void cancelamentoDeSaídasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            JanelaCancelamentodeSaidas cancelamento = new();
            cancelamento.Show();
        }

        private void consultaDeCancelamentosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            JanelaConsultaCancelamento janelaConsultaCancelamento = new(_vendaDAO);
            janelaConsultaCancelamento.Show();
        }

        private void consultaDeDevoluçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaConsultaDevolucao consultaDevolucao = new(_vendaDAO);
            consultaDevolucao.Show();
        }

        private void cancelamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelamentoDeDevolucao cancelamento = new();
            cancelamento.Show();
        }

        private void saídaDeDevoluçãoTrocaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaidaDeTroca s = new(_vendaDAO);
            s.Show();
        }
    }
}
