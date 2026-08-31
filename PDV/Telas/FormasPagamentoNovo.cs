using PDV.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace PDV
{
    public partial class FormasPagamentoNovo : Form
    {
        private FormasdePagamento formaPagamento;
        private readonly FormasdePagamentoDAO formasdePagamentoDAO;
        private readonly FormasPagamento _forma;
        public FormasPagamentoNovo(FormasPagamento forma)
        {
            formasdePagamentoDAO = new FormasdePagamentoDAO();
            InitializeComponent();
            _forma = forma;
        }

        private void BtOk_Click(object sender, EventArgs e)
        {

            formaPagamento = new FormasdePagamento(TfDescricao.Text, CbAtiva.Text, CbAvista.Text);


            if (formasdePagamentoDAO.validacoes(formaPagamento))
            {
                string c = "";
                if (string.IsNullOrEmpty(TfCodigo.Text))
                {
                    formasdePagamentoDAO.incluirFormadePagamento(formaPagamento);
                    TfCodigo.Text = formaPagamento.id.ToString();

                    if (_forma.RbTodas.Checked)
                    {
                        c = "SELECT id, descricao, ativa from formas_pagamento where 1";
                    }else if (_forma.RbAtivas.Checked)
                    {
                        c = "SELECT id, descricao, ativa from formas_pagamento where ativa = 'Sim'";
                    }
                    else if (_forma.RbInativas.Checked)
                    {
                        c = "SELECT id, descricao, ativa from formas_pagamento where ativa = 'Não'";
                    }
                    formasdePagamentoDAO.ListarFormasdePagamento(c);
                    _forma.dataGridView1.DataSource = formasdePagamentoDAO.ListarFormasdePagamento(c);
                    _forma. dataGridView1.ClearSelection();
                }
                else
                {
                    formaPagamento.id = Convert.ToInt32(TfCodigo.Text);
                    formasdePagamentoDAO.atualizarFormadePagamento(formaPagamento);

                    if (_forma.RbTodas.Checked)
                    {
                        c = "SELECT id, descricao, ativa from formas_pagamento where 1";
                    }
                    else if (_forma.RbAtivas.Checked)
                    {
                        c = "SELECT id, descricao, ativa from formas_pagamento where ativa = 'Sim'";
                    }
                    else if (_forma.RbInativas.Checked)
                    {
                        c = "SELECT id, descricao, ativa from formas_pagamento where ativa = 'Não'";
                    }
                    formasdePagamentoDAO.ListarFormasdePagamento(c);
                    _forma.dataGridView1.DataSource = formasdePagamentoDAO.ListarFormasdePagamento(c);
                    _forma.dataGridView1.ClearSelection();
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
               DataRow row = dt.Rows[0];

               TfDescricao.Text = row["descricao"].ToString();
               CbAtiva.Text = row["ativa"].ToString();
               CbAvista.Text = row["avista"].ToString();
            }
        }
    }
}
