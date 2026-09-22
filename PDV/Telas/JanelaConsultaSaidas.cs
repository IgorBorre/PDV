using PDV.Relatórios;
using QuestPDF.Fluent;
using System.Data;

namespace PDV
{
    public partial class JanelaConsultaSaidas : Form
    {
        private readonly VendaDAO _vendaDAO;
        public JanelaConsultaSaidas(VendaDAO vendaDAO)
        {
            InitializeComponent();
            _vendaDAO = vendaDAO;
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {

            string? data1 = null;
            string? data2 = null;

            if (TfData1.MaskCompleted)
            {
                DateTime date = DateTime.ParseExact(TfData1.Text, "dd/MM/yyyy", null);
                data1 = date.ToString("yyyy-MM-dd");
            }

            if (TfData2.MaskCompleted)
            {
                DateTime date2 = DateTime.ParseExact(TfData2.Text, "dd/MM/yyyy", null);
                data2 = date2.ToString("yyyy-MM-dd");
            }

            string c = "select documento, clienteNome, dataSaida, subtotal, desconto, acrescimo, valortotal from saida where cancelada = 'N'" + _vendaDAO.Criterios(
                TfDocumento.Text, false, TfCliente.Text, data1, data2);
            DataTable dt = _vendaDAO.ConsultaSaidas(c);

            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Nenhuma saída encontrada nessas condições!");
            }
        }

        private void JanelaConsultaSaidas_Load(object sender, EventArgs e)
        {
            TfData1.Text = DateTime.Now.ToString();
            TfData2.Text = DateTime.Now.ToString();
        }

        private void TfIdCliente_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfIdCliente.Text))
            {
                ClienteDAO clienteDAO = new();
                DataTable dt = clienteDAO.ClienteByID(TfIdCliente.Text);
                DataRow row;
                row = dt.Rows[0];

                TfCliente.Text = row["nome"].ToString();
            }
            else
            {
                TfCliente.Text = string.Empty;
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            TfIdCliente.Text = string.Empty;
            TfCliente.Text = string.Empty;
            TfDocumento.Text = string.Empty;

            DataTable dt = (DataTable)dataGridView1.DataSource;
            dt.Rows.Clear();
            TfDocumento.Focus();

        }

        private void TfCliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TfIdCliente.Text) && !string.IsNullOrEmpty(TfCliente.Text))
            {
                ClienteDAO clienteDAO = new();
                DataTable dt = clienteDAO.CodigoByNome(TfCliente.Text);
                DataRow row;
                row = dt.Rows[0];

                TfIdCliente.Text = row["codigo"].ToString();
                TfCliente.Text = row["nome"].ToString();
            }
            if (string.IsNullOrEmpty(TfCliente.Text))
            {
                TfIdCliente.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string doc = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() ?? "sem documento";
            var documento = new RelatorioSaida(doc, _vendaDAO.GetListProdutos(doc), _vendaDAO.GetListPagamento(doc), _vendaDAO.GetCliente(doc));
            documento.GeneratePdfAndShow();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            BtPDF.Enabled = dataGridView1.SelectedRows.Count > 0;
            BtDevolucao.Enabled = dataGridView1.SelectedRows.Count > 0;
            BtCancelar.Enabled = dataGridView1.SelectedRows.Count > 0;
        }

        private void BtDevolucao_Click(object sender, EventArgs e)
        {
            JanelaDevolucao devolucao = new(_vendaDAO);
            devolucao.TfDocumento.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() ?? "sem documento";
            devolucao.Show();
            devolucao.BtProcurar.PerformClick();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            JanelaCancelamentodeSaidas janelaCancelamento = new();
            janelaCancelamento.TfDocumento.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() ?? "sem documento";
            janelaCancelamento.Show();
            janelaCancelamento.BtProcurar.PerformClick();
            janelaCancelamento.TfMotivo.Focus();
        }
    }
}
