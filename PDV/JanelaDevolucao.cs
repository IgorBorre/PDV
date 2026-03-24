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
    public partial class JanelaDevolucao : Form
    {
        public JanelaDevolucao()
        {
            InitializeComponent();
        }

        private void BtProcurar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfDocumento.Text))
            {
                VendaDAO vendaDao = new VendaDAO();
                string c = "select clienteNome, dataSaida, subtotal, desconto, acrescimo, valortotal from saida where cancelada = 'N' " +
                    vendaDao.Criterios(TfDocumento.Text);

                DataTable dt;
                dt = vendaDao.ConsultaSaidas(c);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = null;
                    row = dt.Rows[0];

                    LbCliente.Text = row["clienteNome"].ToString();
                    DateTime data = Convert.ToDateTime(row["dataSaida"]);
                    LbData.Text = data.ToString("dd/MM/yyyy");
                    LbSubtotal.Text = row["subtotal"].ToString();

                    string desconto = row["desconto"].ToString();
                    float desconto1 = float.Parse(desconto);

                    string acrescimo = row["acrescimo"].ToString();
                    float acrescimo1 = float.Parse(acrescimo);

                    LbDocumento.Text = TfDocumento.Text;

                    if (desconto1 > 0)
                    {
                        LbDesc.Text = row["desconto"].ToString();
                    }
                    if (acrescimo1 > 0)
                    {
                        LbDesc.Text = row["acrescimo"].ToString();
                    }

                    LbTotal.Text = row["valortotal"].ToString();

                }
                else
                {
                    MessageBox.Show("Documento não existente ou já foi devolvido!");
                    TfDocumento.Focus();
                }
            }
            else
            {
                MessageBox.Show("Informe um documento de venda para realizar uma devolução/troca!");
                TfDocumento.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Deseja cancelar essa operação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {
                TfDocumento.Text = string.Empty;
                LbCliente.Text = string.Empty;
                LbData.Text = string.Empty;
                LbSubtotal.Text = "0,00";
                LbDesc.Text = "0,00";
                LbTotal.Text = "0,00";
                TfDocumento.Focus();
            }

        }

        private void JanelaDevolucao_Load(object sender, EventArgs e)
        {
            RbTroca.Checked = true;
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LbDocumento.Text))
            {
                LancamentodeDevolucao lancamento = new LancamentodeDevolucao();
                lancamento.LbDocumento.Text = LbDocumento.Text;

                string c = "select codigo, referencia, descricao, quantidade from produtos join saidadados on produtos.codigo = saidadados.produto " +
                        "where saidadados.documento = " + LbDocumento.Text;
                VendaDAO v = new VendaDAO();
                DataTable dt = v.ConsultaSaidas(c);
                lancamento.LbDocumento.Text = LbDocumento.Text;

                if (RbDevolucaototal.Checked) { 
                    
                    lancamento.dataGridView1.DataSource = dt;
                    foreach (DataRow row in dt.Rows) { 
                        Produtos p = new Produtos();
                        p.codigo = Convert.ToInt32(row["codigo"]);
                        p.referencia = row["referencia"].ToString();
                        p.descricao = row["descricao"].ToString();
                        p.quantidade = Convert.ToDouble(row["quantidade"]);
                        lancamento.produtos.Add(p);
                    }

                    lancamento.TfId.Enabled = false;
                    lancamento.TfProduto.Enabled = false;
                    lancamento.BtProcura.Enabled = false;
                    lancamento.TfQuantidade.Enabled = false;
                    lancamento.BtOriginais.Enabled = false;
                    lancamento.BtConfirmar.Enabled = false;
                }
                lancamento.Show();
            }
            else
            {
                MessageBox.Show("Informe um documento de venda para realizar uma devolução/troca!");
                TfDocumento.Focus();
            }
        }
    }
}
