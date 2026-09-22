
using PDV.Classes;
using System.Data;

namespace PDV.Telas
{
    public partial class ProcuraDetalhada : Form
    {
        VendaDAO _vendaDAO;
        JanelaDevolucao _janelaDevolucao;
        public ProcuraDetalhada(VendaDAO vendaDAO, JanelaDevolucao janelaDevolucao)
        {
            InitializeComponent();
            _vendaDAO = vendaDAO;
            _janelaDevolucao = janelaDevolucao;
        }

        private void ProcuraDetalhada_Load(object sender, EventArgs e)
        {
            TfData1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TfData2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void TfCliente_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfCliente.Text))
            {
                ClienteDAO clienteDAO = new();
                DataTable dt = clienteDAO.NomeById(TfCliente.Text);

                if (dt.Rows.Count > 0 && dt != null)
                {
                    DataRow row = dt.Rows[0];
                    TfClienteNome.Text = row["nome"].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                    TfCliente.Focus();
                }
            }
        }

        private void TfClienteNome_Leave(object sender, EventArgs e)
        {           
                ClienteDAO clienteDAO = new();
                DataTable dt = clienteDAO.CodigoByNome(TfClienteNome.Text);

                if (dt.Rows.Count > 0 && dt != null)
                {
                    DataRow row = dt.Rows[0];
                    TfCliente.Text = row["codigo"].ToString();
                    TfClienteNome.Text = row["nome"].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                    TfClienteNome.Focus();
                }            
        }


        private void BtProcurar_Click(object sender, EventArgs e)
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

            string comando = "select documento, clienteNome, dataSaida, valortotal from saida where 1" +
                _vendaDAO.ValidacaoDetalhada(TfCliente.Text, data1, data2);

            DataTable dt = _vendaDAO.ConsultaSaidas(comando);

            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Nenhuma venda encontrada!");
            }
        }

        private void BtImportar_Click(object sender, EventArgs e)
        {
            _janelaDevolucao.TfDocumento.Text = dataGridView1.SelectedRows[0].Cells["documento"].Value.ToString();
            _janelaDevolucao.BtProcurar.PerformClick();
            Dispose();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            BtImportar.Enabled = dataGridView1.SelectedRows.Count > 0;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtImportar.PerformClick();
        }
    }
}
