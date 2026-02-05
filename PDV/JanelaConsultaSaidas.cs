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
    public partial class JanelaConsultaSaidas : Form
    {
        public VendaDAO vendaDAO;
        public JanelaConsultaSaidas()
        {
            InitializeComponent();
            vendaDAO = new VendaDAO();
        }

        private void btProcurar_Click(object sender, EventArgs e)
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
                DateTime date2 = DateTime.ParseExact(TfData2.Text, "dd/MM/yyyy", null);
                data2 = date2.ToString("yyyy-MM-dd");
            }

            string c = "select documento, clienteNome, dataSaida, subtotal, desconto, acrescimo, valortotal from saida where cancelada = 'N'" + vendaDAO.Criterios(
                TfDocumento.Text, TfCliente.Text, data1, data2);
            DataTable dt = vendaDAO.ConsultaSaidas(c);

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
                ClienteDAO clienteDAO = new ClienteDAO();
                DataTable dt = clienteDAO.ClienteByID(TfIdCliente.Text);
                DataRow row = null;
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
            if (string.IsNullOrEmpty(TfIdCliente.Text) && !string.IsNullOrEmpty(TfCliente.Text)) { 
                ClienteDAO clienteDAO = new ClienteDAO();
                DataTable dt = clienteDAO.CodigoByNome(TfCliente.Text);
                DataRow row = null;
                row = dt.Rows[0];

                TfIdCliente.Text = row["codigo"].ToString();
                TfCliente.Text = row["nome"].ToString();
            }
        }
    }
}
