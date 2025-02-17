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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            dataGridView1.DataSource = clienteDAO.ListarClientes();
            dataGridView1.ClearSelection();
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
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CadastroGeralNovo form = new CadastroGeralNovo();

            form.TfCodigo.Text = dataGridView1.CurrentRow.Cells["Código"].Value.ToString();

            ClienteDAO clienteDAO = new ClienteDAO();

            form.ShowDialog();  
        }
    }
}
