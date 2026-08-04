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
    public partial class JanelaConsultaDevolucao : Form
    {
        private readonly VendaDAO _vendaDAO;
        public JanelaConsultaDevolucao(VendaDAO vendaDAO)
        {
            InitializeComponent();
            _vendaDAO = vendaDAO;
        }

        private void JanelaConsultaDevolucao_Load(object sender, EventArgs e)
        {
            TfData1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TfData2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void BtProcura_Click(object sender, EventArgs e)
        {
            string? data1 = TfData1.MaskCompleted ? DateTime.Parse(TfData1.Text).ToString("yyyy-MM-dd") : null;
            string? data2 = TfData2.MaskCompleted ? DateTime.Parse(TfData2.Text).ToString("yyyy-MM-dd") : null;

            string c = "select documento, nomeCliente, dataDevolucao, doc_original from devolucao where 1" +
                _vendaDAO.Criterios(TfDocumento.Text, true, TfIdCliente.Text, data1, data2);
            DataTable dt = _vendaDAO.ConsultaSaidas(c);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Devolução não encontrada nas condições informadas!");
            }

        }

        private void TfIdCliente_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfIdCliente.Text))
            {
                string c = "select nome from clientes where codigo = " + TfIdCliente.Text;
                DataTable dt = _vendaDAO.ConsultaSaidas(c);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = null;
                    row = dt.Rows[0];
                    TfCliente.Text = row["nome"].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                    TfIdCliente.Focus();
                    if (!string.IsNullOrEmpty(TfCliente.Text))
                    {
                        TfCliente.Text = string.Empty;
                    }
                }
            }
            else
            {
                TfCliente.Text = string.Empty;
            }
        }

        private void TfCliente_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfCliente.Text) && string.IsNullOrEmpty(TfIdCliente.Text))
            {
                string c = "select codigo, nome from clientes where nome like '%" + TfCliente.Text + "%'";

                DataTable dt = _vendaDAO.ConsultaSaidas(c);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = null;
                    row = dt.Rows[0];
                    TfIdCliente.Text = row["codigo"].ToString();
                    TfCliente.Text = row["nome"].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                    TfCliente.Focus();
                    if (!string.IsNullOrEmpty(TfIdCliente.Text))
                    {
                        TfIdCliente.Text = string.Empty;
                    }
                }
            }
            if (!string.IsNullOrEmpty(TfIdCliente.Text) && string.IsNullOrEmpty(TfCliente.Text)) { 
                TfIdCliente.Text = string.Empty;
            }
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) {
                dataGridView1.DataSource = null;
            }

            TfDocumento.Text = string.Empty;
            TfIdCliente.Text = string.Empty;
            TfCliente.Text = string.Empty;
            TfData1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TfData2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
