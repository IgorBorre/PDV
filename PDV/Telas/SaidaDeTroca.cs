
using System.Data;

namespace PDV
{
    public partial class SaidaDeTroca : Form
    {
        private readonly string c = "select d.documento, d.nomeCliente, d.dataDevolucao, d.valor from devolucao d left join saida s on s.doc_original = d.documento " +
            "where s.doc_original is null and d.documento = ";
        private readonly VendaDAO _vendaDAO;
        public SaidaDeTroca(VendaDAO vendaDAO)
        {
            InitializeComponent();
            _vendaDAO = vendaDAO;
        }

        private void BtProcurar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfDocumento.Text))
            {
                DataTable dt = _vendaDAO.ConsultaSaidas(c + TfDocumento.Text);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    LbCliente.Text = row["nomeCliente"].ToString();
                    DateTime data = Convert.ToDateTime(row["dataDevolucao"]);
                    LbData.Text = data.ToString("dd/MM/yyyy");
                    LbTotal.Text = Convert.ToDouble(row["valor"]).ToString("F2");
                    LbDocumento.Text = row["documento"].ToString();
                }
                else
                {
                    MessageBox.Show("Devolução não encontrada ou já possui saída!!");
                    LbDocumento.Text = string.Empty;
                    LbCliente.Text = string.Empty;
                    LbData.Text = string.Empty;
                    LbTotal.Text = "0,00";
                    TfDocumento.Focus();
                }
            }
            else
            {
                MessageBox.Show("Informe um número de documento de devolução para realizar a busca!!");
                TfDocumento.Focus();
            }
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            TfDocumento.Text = string.Empty;
            if (!string.IsNullOrEmpty(LbDocumento.Text))
            {
                LbCliente.Text = string.Empty;
                LbData.Text = string.Empty;
                LbTotal.Text = "0,00";
                LbDocumento.Text = string.Empty;
            }
            TfDocumento.Focus();
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LbDocumento.Text))
            {
                JanelaVenda janelaVenda = new(_vendaDAO);
                janelaVenda.LbDocumento.Text = LbDocumento.Text;
                janelaVenda.Show();
                TfDocumento.Text = string.Empty;
                LbDocumento.Text = string.Empty;
                LbCliente.Text = string.Empty;
                LbData.Text = string.Empty;
                LbTotal.Text = "0,00";
            }
            else
            {
                MessageBox.Show("Informe um documento de devolução!!");
                TfDocumento.Focus();
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfDocumento.Text) || !string.IsNullOrEmpty(LbDocumento.Text))
            {
                DialogResult resultado = MessageBox.Show("Cancelar operação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    TfDocumento.Text = string.Empty;
                    LbDocumento.Text = string.Empty;
                    LbCliente.Text = string.Empty;
                    LbData.Text = string.Empty;
                    LbTotal.Text = "0,00";
                    TfDocumento.Focus();
                }
            }
            else {
                Dispose();
            }
        }
    }
}
