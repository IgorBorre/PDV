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
    public partial class JanelaCancelamentodeEntradas : Form
    {
        public JanelaCancelamentodeEntradas()
        {
            InitializeComponent();
        }

        private void BtProcurar_Click(object sender, EventArgs e)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            string c = "select documento, dataentrada, nomefornecedor from entrada where documento = " + TfDocumento.Text + " and cancelada = 'N'";
            DataTable dt = produtoDAO.ListarProdutos(c);
            if (dt.Rows.Count > 0)
            {
                DataRow row = null;
                row = dt.Rows[0];

                lbDocumento.Text = row["documento"].ToString();
                DateTime data = Convert.ToDateTime(row["dataentrada"]);
                lbData.Text = data.ToString("dd/MM/yyyy");
                lbFornecedor.Text = row["nomefornecedor"].ToString();
            }
            else
            {
                MessageBox.Show("Entrada não existente ou já cancelada!");
                TfDocumento.Focus();
                TfDocumento.Text = string.Empty;
                lbDocumento.Text = string.Empty;
                lbData.Text = string.Empty;
                lbFornecedor.Text = string.Empty;
                TfMotivo.Text = string.Empty;
            }
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbDocumento.Text) && TfMotivo.Text.Length > 15 && !string.IsNullOrEmpty(TfMotivo.Text))
            {
                ProdutoDAO produtoDAO = new ProdutoDAO();
                produtoDAO.CancelarEntrada(TfDocumento.Text, TfMotivo.Text);
                TfDocumento.Text = string.Empty;
                lbDocumento.Text = string.Empty;
                lbData.Text = string.Empty;
                lbFornecedor.Text = string.Empty;
                TfMotivo.Text = string.Empty;
                TfDocumento.Focus();
            }
            else {
                MessageBox.Show("Informe um número de documento e um motivo de pelo menos 15 caracteres para cancelar uma entrada!");
                TfDocumento.Focus();
            }
        }
    }
}
