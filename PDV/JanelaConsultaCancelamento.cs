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
    public partial class JanelaConsultaCancelamento : Form
    {
        public JanelaConsultaCancelamento()
        {
            InitializeComponent();
        }

        private void BtProcurar_Click(object sender, EventArgs e)
        {
            string data1 = null;
            string data2 = null;

            if (TfData1.MaskCompleted)
            {
                DateTime date = DateTime.ParseExact(TfData1.Text, "dd/MM/yyyy", null);
                data1 = date.ToString("yyyy-MM-dd");
            }

            if (TfData2.MaskCompleted)
            {
                DateTime date = DateTime.ParseExact(TfData2.Text, "dd/MM/yyyy", null);
                data2 = date.ToString("yyyy-MM-dd");
            }

            VendaDAO vendaDAO = new VendaDAO();
            string c = "select * from cancelamentoLog where 1" + vendaDAO.Validacoes(TfDocumento.Text, data1, data2);

            DataTable dt;
            dt = vendaDAO.ConsultaSaidas(c);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nenhum cancelamento encontrado nessas condições!");
                dataGridView1.DataSource = null;
                TfDocumento.Focus();
            }
            dataGridView1.ClearSelection();
        }

        private void JanelaConsultaCancelamento_Load(object sender, EventArgs e)
        {
            TfData1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TfData2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            TfDocumento.Text = string.Empty;
            TfData1.Text = string.Empty;
            TfData2.Text = string.Empty;
            dataGridView1.DataSource = null;
        }
    }
}
