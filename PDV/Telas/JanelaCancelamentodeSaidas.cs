using System.Data;

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

                VendaDAO vendaDAO = new();
                string c = "select documento, dataSaida, valortotal from saida where cancelada = 'N' " +
                    vendaDAO.Criterios(TfDocumento.Text, false);
                DataTable dt = vendaDAO.ConsultaSaidas(c);
                if (dt.Rows.Count > 0)
                {
                    if (vendaDAO.SaidaPossuiDevolucao(TfDocumento.Text))
                    {
                        string c2 = $"select s.documento, s.dataSaida, s.valortotal from saida s join devolucao d on d.doc_original = {TfDocumento.Text} " +
                            $"where d.cancelada = 'S' and s.cancelada = 'N'";

                        DataTable dt2 = vendaDAO.ConsultaSaidas(c2);

                        if (dt2.Rows.Count > 0)
                        {

                            DataRow row = dt.Rows[0];

                            LbDocumento.Text = row["documento"].ToString();
                            DateTime data = Convert.ToDateTime(row["dataSaida"]);
                            LbData.Text = data.ToString("dd/MM/yyyy");
                            LbValor.Text = row["valortotal"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Essa saída possui uma devolução, cancele a devolução primeiro para poder cancelar essa saída!");
                            TfDocumento.Text = string.Empty;
                            TfDocumento.Focus();
                        }
                    }
                    else {
                        DataRow row = dt.Rows[0];

                        LbDocumento.Text = row["documento"].ToString();
                        DateTime data = Convert.ToDateTime(row["dataSaida"]);
                        LbData.Text = data.ToString("dd/MM/yyyy");
                        LbValor.Text = row["valortotal"].ToString();
                    }

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
            if (!string.IsNullOrEmpty(LbDocumento.Text) && !string.IsNullOrEmpty(TfMotivo.Text) && TfMotivo.Text.Length > 15)
            {
                VendaDAO vendaDAO = new();
                vendaDAO.CancelarVenda(LbDocumento.Text, TfMotivo.Text);
                TfDocumento.Text = string.Empty;
                LbDocumento.Text = string.Empty;
                LbData.Text = string.Empty;
                LbValor.Text = string.Empty;
                TfMotivo.Text = string.Empty;
                TfDocumento.Focus();
            }
            else { 
                MessageBox.Show("Informe um número de documento e um motivo de pelo menos 15 caracteres para cancelar a saída!");
            }
        }
    }
}
