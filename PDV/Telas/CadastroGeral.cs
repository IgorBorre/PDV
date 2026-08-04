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
    public partial class CadastroGeral : Form
    {



        public CadastroGeral()
        {
            InitializeComponent();
            TFTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //filtros para a pesquisa de clientes no banco
            string c = "";
            ClienteDAO clienteDAO = new ClienteDAO();
            c = "select codigo, nome, telefone, identificacao from clientes where 1" + clienteDAO.Criterios(TFCodigo.Text, TFNome.Text, TFTelefone.Text, TFCpf.Text);

            DataTable dt = clienteDAO.ListarClientes(c);

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
            if (dataGridView1.Rows.Count > 0) { 
                DataTable dt = (DataTable)dataGridView1.DataSource;
                dt.Rows.Clear();
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroGeralNovo cadastro = new CadastroGeralNovo();
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
            CadastroGeralNovo form = new CadastroGeralNovo();

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
    }
}
