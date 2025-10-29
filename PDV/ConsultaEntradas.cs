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
    public partial class ConsultaEntradas : Form
    {
        ProdutoDAO produtoDAO;
        public ConsultaEntradas()
        {
            InitializeComponent();
            produtoDAO = new ProdutoDAO();
        }

        private void ConsultaEntradas_Load(object sender, EventArgs e)
        {
            TfData1.Text = DateTime.Now.ToString();
            TfData2.Text = DateTime.Now.ToString();
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
                DateTime date2 = DateTime.ParseExact(TfData2.Text, "dd/MM/yyyy", null);
                data2 = date2.ToString("yyyy-MM-dd");
            }

            string c = "select documento, nomefornecedor, dataentrada from entrada where cancelada = 'N'" + produtoDAO.CriteriosConsulta(TfDocumento.Text, TfFornecedor.Text, data1,
                data2);

            DataTable dt = produtoDAO.ListarProdutos(c);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Nenhuma entrada encontrada nessas condições!");
                TfDocumento.Focus();
                dataGridView1.DataSource = null;
            }

        }

        private void TfIdFornecedor_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfIdFornecedor.Text))
            {
                ClienteDAO clienteDAO = new ClienteDAO();
                DataTable dt = clienteDAO.ClienteByID(TfIdFornecedor.Text);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = null;
                    row = dt.Rows[0];

                    TfFornecedor.Text = row["nome"].ToString();
                }
                else {
                    MessageBox.Show("Fornecedor não encontrado!");
                    TfIdFornecedor.Text = string.Empty;
                    TfFornecedor.Text = string.Empty;
                    TfIdFornecedor.Focus();
                }
            }
            else
            {
                TfFornecedor.Text = string.Empty;
            }
        }

        private void TfFornecedor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TfIdFornecedor.Text)) { 
                ClienteDAO clienteDAO = new ClienteDAO();
                DataTable dt = clienteDAO.CodigoByNome(TfFornecedor.Text);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = null;
                    row = dt.Rows[0];

                    TfIdFornecedor.Text = row["codigo"].ToString();
                    TfFornecedor.Text = row["nome"].ToString();
                }
                else { 
                    MessageBox.Show("Fornecedor não encontrado!");
                    TfIdFornecedor.Text = string.Empty;
                    TfFornecedor.Text = string.Empty;
                    TfFornecedor.Focus();
                }
            }
        }
    }
}
