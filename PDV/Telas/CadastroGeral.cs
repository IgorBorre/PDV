using PDV.Classes;
using System.Data;

namespace PDV
{
    public partial class CadastroGeral : Form
    {
        public string comando = "";
        private readonly ClienteDAO _clienteDAO;

        public CadastroGeral(ClienteDAO clienteDAO)
        {
            InitializeComponent();
            TFTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            _clienteDAO = clienteDAO;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //filtros para a pesquisa de clientes no banco 
            comando = "select codigo, nome, telefone, identificacao from clientes where 1" + _clienteDAO.Criterios(TFCodigo.Text, TFNome.Text, TFTelefone.Text, TFCpf.Text);

            DataTable dt = _clienteDAO.ListarClientes(comando);

            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Cliente não encontrado!");
                TFCodigo.Text = string.Empty;
                TFCpf.Text = string.Empty;
                TFNome.Text = string.Empty;
                TFTelefone.Text = string.Empty;
                TFCodigo.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //percorre os elementos do forms
            foreach (Control control in this.Controls)
            {
                //se for um TextBox vai apagar o texto
                if (control is TextBox textBox)
                {

                    textBox.Text = string.Empty;
                }//se for um MaskedTextBox vai apagar o texto
                else if (control is MaskedTextBox maskedTextBox)
                {
                    maskedTextBox.Text = string.Empty;
                }
            }
            if (dataGridView1.Rows.Count > 0)
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                if (dt != null)
                    dt.Rows.Clear();
                else
                    dataGridView1.Rows.Clear();
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroGeralNovo cadastro = new(this);
            cadastro.ShowDialog();
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            //para não gerar a tabela com a primeira liha já selecionada
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //abre a janela de cadastro preenchendo o código do cliente na célula selecionada
            CadastroGeralNovo form = new(this);

            form.TfCodigo.Text = dataGridView1.CurrentRow.Cells["Código"].Value.ToString();

            form.ShowDialog();
        }

        private void TFCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroGeral_Load(object sender, EventArgs e)
        {

        }

        private void TFNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroGeral_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TFCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void TFTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void TFNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void TFCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            Clientes c = new()
            {
                codigo = Convert.ToInt32(dataGridView1.SelectedCells[0].Value)
            };
            ClienteDAO clienteDAO = new();
            clienteDAO.SelectExclusao(c);

            DataTable dt = _clienteDAO.ListarClientes(comando);
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            BtExcluir.Enabled = dataGridView1.SelectedRows.Count > 0;
        }
    }
}
