using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class LancamentodeDevolucao : Form
    {
        double quantidadeOriginal = 0;
        
        public List<Produtos> produtos = [];

        private readonly JanelaDevolucao janela;

       private readonly ItensOriginais itens = new();

        private readonly VendaDAO _vendaDAO;
        public LancamentodeDevolucao(JanelaDevolucao janela, VendaDAO vendaDAO)
        {
            InitializeComponent();
            this.janela = janela;
            _vendaDAO = vendaDAO;
        }

        private void LancamentodeDevolucao_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }


        private void BtFinalizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("Não é possível realizar uma devolução/troca sem produtos!");
            }
            else { 
                ProdutoDAO p = new();
                Devolucao d = new()
                {
                    valor = double.Parse(LbTotal.Text)
                };
                Entrada entrada = new();

                if (string.IsNullOrEmpty(LbIdCliente.Text))
                {
                    p.Devolucao(d, entrada, produtos, LbDocumento.Text);
                    Dispose();
                    if (LbTroca.Text == "Troca")
                    {
                        JanelaVenda janelaVenda = new(_vendaDAO);
                        janelaVenda.LbDocumento.Text = d.documento.ToString();
                        janelaVenda.Show();
                        janelaVenda.TfId.Focus();
                    }

                    janela.LbCliente.Text = string.Empty;
                    janela.LbData.Text = string.Empty;
                    janela.LbDesc.Text = "0,00";
                    janela.LbSubtotal.Text = "0,00";
                    janela.LbTotal.Text = "0,00";
                    janela.LbDocumento.Text = string.Empty;
                    janela.TfDocumento.Text = string.Empty;
                    janela.TfDocumento.Focus();
                }
                else {
                    Clientes c = new()
                    {
                        codigo = int.Parse(LbIdCliente.Text),
                        nome = LbNomeCliente.Text
                    };
                    p.Devolucao(d, entrada, produtos, LbDocumento.Text, c);
                    Dispose();
                    if (LbTroca.Text == "Troca")
                    {
                        JanelaVenda janelaVenda = new(_vendaDAO);
                        janelaVenda.LbDocumento.Text = d.documento.ToString();
                        janelaVenda.Show();
                        janelaVenda.TfId.Focus();
                    }

                    janela.LbCliente.Text = string.Empty;
                    janela.LbData.Text = string.Empty;
                    janela.LbDesc.Text = "0,00";
                    janela.LbSubtotal.Text = "0,00";
                    janela.LbTotal.Text = "0,00";
                    janela.LbDocumento.Text = string.Empty;
                    janela.TfDocumento.Text = string.Empty;
                    janela.TfDocumento.Focus();
                }

            }
        }

        private void BtOriginais_Click(object sender, EventArgs e)
        {

            string c = "select codigo, referencia, descricao, quantidade, valor from produtos join saidadados on produtos.codigo = saidadados.produto " +
                        "where saidadados.documento = " + LbDocumento.Text;

            VendaDAO v = new();
            DataTable dt = v.ConsultaSaidas(c);

            itens.dataGridView1.AutoGenerateColumns = false;
            itens.dataGridView1.DataSource = dt;


            itens.ShowDialog();
        }

        private void TfId_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfId.Text))
            {
                try
                {
                    int.Parse(TfId.Text);
                }
                catch
                {

                    MessageBox.Show("Produto não encontrado!");
                    TfId.Focus();
                    return;
                }


                string c = "select codigo, referencia, descricao, quantidade, valor from saidadados s join produtos p on p.codigo = s.produto where documento = " + LbDocumento.Text + " and s.produto = " + TfId.Text;
                VendaDAO v = new();
                DataTable dt = v.ConsultaSaidas(c);

                if (dt.Rows.Count > 0)
                {

                    DataRow row = dt.Rows[0];
                    TfProduto.Text = row["descricao"].ToString();
                    quantidadeOriginal = double.Parse(row["quantidade"].ToString() ?? "0");
                    LbCodigo.Text = row["codigo"].ToString();
                    LbDescricao.Text = row["descricao"].ToString();
                    LbReferencia.Text = row["referencia"].ToString();
                    TfValor.Text = row["valor"].ToString();

                }
                else
                {
                    MessageBox.Show("Esse produto não pertence à venda original!");
                    TfId.Focus();
                    if (!string.IsNullOrEmpty(TfProduto.Text))
                    {
                        TfProduto.Text = string.Empty;
                    }
                }
            }
            else
            {
                TfProduto.Text = string.Empty;
                LbCodigo.Text = string.Empty;
                LbDescricao.Text = string.Empty;
                LbReferencia.Text = string.Empty;
            }
        }

        private void BtProcura_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfId.Text))
            {
                try
                {
                    int.Parse(TfId.Text);
                }
                catch
                {

                    MessageBox.Show("Produto não encontrado!");
                    TfId.Focus();
                    return;
                }


                string c = "select codigo, referencia, descricao, quantidade, valor from saidadados s join produtos p on p.codigo = s.produto where documento = " + LbDocumento.Text + " and s.produto = " + TfId.Text;
                VendaDAO v = new();
                DataTable dt = v.ConsultaSaidas(c);

                if (dt.Rows.Count > 0)
                {

                    DataRow row = dt.Rows[0];
                    TfProduto.Text = row["descricao"].ToString();
                    LbCodigo.Text = row["codigo"].ToString();
                    LbDescricao.Text = row["descricao"].ToString();
                    LbReferencia.Text = row["referencia"].ToString();
                    TfValor.Text = row["valor"].ToString();

                }
                else
                {
                    MessageBox.Show("Esse produto não pertence à venda original!");
                    TfId.Focus();
                    if (!string.IsNullOrEmpty(TfProduto.Text))
                    {
                        TfProduto.Text = string.Empty;
                    }
                }
            }
        }

        private void TfQuantidade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfQuantidade.Text))
            {
                try
                {
                    double quantidade = 0;
                    var produto = produtos.FirstOrDefault(p => p.codigo == Convert.ToInt32(TfId.Text));
                    var quantidadeProduto = produto != null ? produto.quantidade : 0;
                    quantidade = double.Parse(TfQuantidade.Text) + quantidadeProduto;


                    if (quantidade > quantidadeOriginal)
                    {
                        MessageBox.Show("A quantidade devolvida não pode ser maior que a quantidade original!");
                        TfQuantidade.Text = string.Empty;
                        TfQuantidade.Focus();
                    }
                }
                catch
                {

                    MessageBox.Show("Digite uma quantidade válida!");
                    TfQuantidade.Text = string.Empty;
                    TfQuantidade.Focus();
                }

            }
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfId.Text) && !string.IsNullOrEmpty(TfQuantidade.Text))
            {

                string c = "select referencia from produtos where codigo = " + TfId.Text;
                ProdutoDAO pDAO = new();
                DataTable dt = pDAO.ListarProdutos(c);
                DataRow row = dt.Rows[0];

                Produtos p = new()
                {
                    codigo = int.Parse(TfId.Text),
                    descricao = TfProduto.Text,
                    referencia = row["referencia"].ToString() ?? "Sem referência",
                    quantidade = double.Parse(TfQuantidade.Text),
                    preco = double.Parse(TfValor.Text)
                };

                var produto = produtos.FirstOrDefault(p => p.codigo == Convert.ToInt32(TfId.Text));
                if (produto != null)
                {
                    produto.quantidade += p.quantidade;
                    foreach (DataGridViewRow row1 in dataGridView1.Rows)
                    {
                        int codigo = Convert.ToInt32(row1.Cells["codigo"].Value);
                        if (codigo == produto.codigo)
                        {
                            row1.Cells["quantidade"].Value = produto.quantidade;
                            LbTotal.Text = (double.Parse(LbTotal.Text) + (p.quantidade * p.preco)).ToString();
                            LbCodigo.Text = string.Empty;
                            LbDescricao.Text = string.Empty;
                            LbReferencia.Text = string.Empty;
                            TfValor.Text = string.Empty;
                            break;
                        }
                    }
                }
                else
                {
                    produtos.Add(p);

                    dataGridView1.Rows.Add(p.codigo, p.descricao, p.referencia, p.quantidade, p.preco);
                    LbCodigo.Text = string.Empty;
                    LbDescricao.Text = string.Empty;
                    LbReferencia.Text = string.Empty;
                    TfValor.Text = string.Empty;
                    LbTotal.Text = (double.Parse(LbTotal.Text) + (p.quantidade * p.preco)).ToString();
                }

                quantidadeOriginal -= p.quantidade;

                TfId.Text = string.Empty;
                TfProduto.Text = string.Empty;
                TfQuantidade.Text = string.Empty;
                TfId.Focus();
            }
            else
            {
                MessageBox.Show("Preencha o código do produto e a quantidade para confirmar a devolução!");
            }
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Deseja cancelar essa devolução?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Dispose();
                }
            }
            else
            {
                Dispose();
            }
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) { 
                dataGridView1.Rows.Clear();
                produtos.Clear();
            }
            TfId.Text = string.Empty;
            TfProduto.Text= string.Empty;
            TfQuantidade.Text = string.Empty;
            LbIdCliente.Text = string.Empty;
            LbNomeCliente.Text = string.Empty;
            TfValor.Text = string.Empty;
            LbTotal.Text = "0";
        }
    }
}
