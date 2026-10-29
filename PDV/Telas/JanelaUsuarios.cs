using System.Data;

namespace PDV.Telas
{
    public partial class JanelaUsuarios : Form
    {
        readonly VendaDAO _vendaDAO;
        public string c = string.Empty;
        public JanelaUsuarios(VendaDAO vendaDAO)
        {
            InitializeComponent();
            _vendaDAO = vendaDAO;
        }

        private void BtInserir_Click(object sender, EventArgs e)
        {
            JanelaUsuarioNovo janelaUsuarioNovo = new(this);
            janelaUsuarioNovo.Show();
        }

        private void BtProcurar_Click(object sender, EventArgs e)
        {
            c = "select codigo, nome from usuarios where 1" + _vendaDAO.ValidacaoUsuario(TfId.Text, TfUsuario.Text);

            DataTable dt = _vendaDAO.ConsultaSaidas(c);
            if (dt.Rows.Count > 0 && dt != null)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Nenhum usuário encontrado!");
                TfId.Text = string.Empty;
                TfUsuario.Text = string.Empty;
                TfId.Focus();
            }
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            TfId.Text = string.Empty;
            TfUsuario.Text = string.Empty;
            DataTable dt = (DataTable)dataGridView1.DataSource;
            dt.Rows.Clear();
            c = string.Empty;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            JanelaUsuarioNovo janelaUsuarioNovo = new(this);
            janelaUsuarioNovo.TfId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            janelaUsuarioNovo.TfUsuario.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            janelaUsuarioNovo.Show();
        }
    }
}
