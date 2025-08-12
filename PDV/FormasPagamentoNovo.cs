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
    public partial class FormasPagamentoNovo : Form
    {
        FormasdePagamento formaPagamento;
        FormasdePagamentoDAO formasdePagamentoDAO;
        public FormasPagamentoNovo()
        {
            formasdePagamentoDAO = new FormasdePagamentoDAO();
            InitializeComponent();
        }

        private void BtOk_Click(object sender, EventArgs e)
        {

            formaPagamento = new FormasdePagamento();

            formaPagamento.descricao = TfDescricao.Text;
            formaPagamento.ativa = CbAtiva.Text;
            formaPagamento.avista = CbAvista.Text;

            if (formasdePagamentoDAO.validacoes(formaPagamento))
            {
                if (string.IsNullOrEmpty(TfCodigo.Text))
                {
                    formasdePagamentoDAO.incluirFormadePagamento(formaPagamento);
                    TfCodigo.Text = formaPagamento.id.ToString();
                }
                else
                {
                    formaPagamento.id = Convert.ToInt32(TfCodigo.Text);
                    formasdePagamentoDAO.atualizarFormadePagamento(formaPagamento);
                }
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FormasPagamentoNovo_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfCodigo.Text)) {
               DataTable dt = formasdePagamentoDAO.ListarFormasdePagamentoPorId(Convert.ToInt32(TfCodigo.Text));
               DataRow row = null;
               row = dt.Rows[0];

               TfDescricao.Text = row["descricao"].ToString();
               CbAtiva.Text = row["ativa"].ToString();
               CbAvista.Text = row["avista"].ToString();
            }
        }
    }
}
