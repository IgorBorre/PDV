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
    public partial class JanelaCancelamentodeSaidas : Form
    {
        public JanelaCancelamentodeSaidas()
        {
            InitializeComponent();
        }

        private void JanelaCancelamentodeSaidas_Load(object sender, EventArgs e)
        {
        }

        private void BtProcurar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfDocumento.Text))
            {

                VendaDAO vendaDAO = new VendaDAO();
                string c = "select documento, dataSaida, valortotal from saida where cancelada = 'N' " +
                    vendaDAO.Criterios(TfDocumento.Text);
                DataTable dt;
                dt = vendaDAO.ConsultaSaidas(c);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = null;
                    row = dt.Rows[0];

                    LbDocumento.Text = row["documento"].ToString();
                    DateTime data = Convert.ToDateTime(row["dataSaida"]);
                    LbData.Text = data.ToString("dd/MM/yyyy");
                    LbValor.Text = row["valortotal"].ToString();

                }
                else
                {
                    MessageBox.Show("Saída não existente ou já cancelada!");
                    TfDocumento.Focus();

                    LbDocumento.Text = string.Empty;
                    LbData.Text = string.Empty;
                    LbValor.Text = string.Empty;
                    TfMotivo.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Digite um número de documento para realizar a procura!");
            }

        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            TfDocumento.Text = string.Empty;
            LbDocumento.Text = string.Empty;
            LbData.Text = string.Empty;
            LbValor.Text = string.Empty;
            TfMotivo.Text = string.Empty;
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LbDocumento.Text)) { 
                VendaDAO vendaDAO = new VendaDAO();
                vendaDAO.CancelarVenda(LbDocumento.Text);
                TfDocumento.Text = string.Empty;
                LbDocumento.Text = string.Empty;
                LbData.Text = string.Empty;
                LbValor.Text = string.Empty;
                TfMotivo.Text = string.Empty;
                TfDocumento.Focus();
            }
        }
    }
}
