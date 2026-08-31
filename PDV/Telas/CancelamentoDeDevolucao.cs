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
                string c1 = "select s.documento, s.valortotal, s.cancelada from saida s join devolucao d on s.doc_original = d.documento" +
                    $" where s.doc_original = {TfDocumento.Text} and s.cancelada = 'N'";
                string c = "select documento, nomeCliente, dataDevolucao, valor from devolucao where cancelada = 'N' and documento = " + TfDocumento.Text;

                VendaDAO vendaDAO = new();

                DataTable dt1 = vendaDAO.ConsultaSaidas(c1);
                if (dt1.Rows.Count > 0)
                {
                    MessageBox.Show("Essa devolução possui uma saída vinculada à ela, para cancelar essa devolução cancele primeiro a saída dessa devolução!");
                    TfDocumento.Focus();
                }
                else
                {
                    DataTable dt = vendaDAO.ConsultaSaidas(c);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        LbCliente.Text = row["nomeCliente"].ToString();
                        DateTime data = Convert.ToDateTime(row["dataDevolucao"].ToString());
                        LbData.Text = data.ToString("dd/MM/yyyy");
                        LbDocumento.Text = row["documento"].ToString();
                        LbTotal.Text = Convert.ToDouble(row["valor"]).ToString("F2");

                    }
                    else
                    {
                        MessageBox.Show("Devolução não existe ou já cancelada!");
                        TfDocumento.Focus();
                    }
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
                ProdutoDAO p = new();
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
