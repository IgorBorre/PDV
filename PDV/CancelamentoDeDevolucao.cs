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
    public partial class CancelamentoDeDevolucao : Form
    {
        public CancelamentoDeDevolucao()
        {
            InitializeComponent();
        }

        private void BtProcura_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfDocumento.Text))
            {
                string c = "select documento, nomeCliente, dataDevolucao from devolucao where cancelada = 'N' and documento = " + TfDocumento.Text;
                VendaDAO vendaDAO = new VendaDAO();
                DataTable dt = vendaDAO.ConsultaSaidas(c);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = null;
                    row = dt.Rows[0];

                    LbCliente.Text = row["nomeCliente"].ToString();
                    DateTime data = Convert.ToDateTime(row["dataDevolucao"].ToString());
                    LbData.Text = data.ToString("dd/MM/yyyy");
                    LbDocumento.Text = row["documento"].ToString();

                }
                else
                {
                    MessageBox.Show("Devolução não existe ou já cancelada!");
                    TfDocumento.Focus();
                }
            }
            else
            {
                MessageBox.Show("Digite um documento para procurar!");
                TfDocumento.Focus();
            }
        }

        private void BtExecutar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LbDocumento.Text)) {
                ProdutoDAO p = new ProdutoDAO();
                p.CancelarDevolucao(LbDocumento.Text);
                TfDocumento.Text = string.Empty;
                LbDocumento.Text = string.Empty;
                LbCliente.Text = string.Empty;
                LbData.Text = string.Empty;
                LbTotal.Text = "0,00";
            }
        }
    }
}
