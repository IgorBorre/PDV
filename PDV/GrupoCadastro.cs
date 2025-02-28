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
    public partial class GrupoCadastro : Form
    {
        GrupoDAO grupoDAO;
        public GrupoCadastro()
        {
            InitializeComponent();
            grupoDAO = new GrupoDAO();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GrupoCadastroNovo grupoCadastroNovo = new GrupoCadastroNovo();
            grupoCadastroNovo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c = "select * from grupos where 1" + grupoDAO.Criterios(TfId.Text, TfNome.Text);
            dataGridView1.DataSource = grupoDAO.BuscarGrupo(c);
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrupoCadastro_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GrupoCadastroNovo form = new GrupoCadastroNovo();

            form.TfCodigo.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();

            form.ShowDialog();
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
