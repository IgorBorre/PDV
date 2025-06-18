using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.LinkLabel;

namespace PDV
{
    public partial class JanelaVenda : Form
    {
        ProdutoDAO produtoDAO;
        VendaDAO vendaDAO;
        List<Produtos> listaProdutos = new List<Produtos>();
        int id = 0;
        double quantidade = 0;
        double total = 0;
        public JanelaVenda()
        {
            InitializeComponent();
            produtoDAO = new ProdutoDAO();
            vendaDAO = new VendaDAO();
        }

        private void LimparCampos()
        {
            TfId.Text = string.Empty;
            TfQtd.Text = string.Empty;
            TfPreco.Text = string.Empty;
            listBox1.Items.Clear();
            listaProdutos.Clear();
            lblQtd.Text = string.Empty;
            lblQtd.Visible = false;

            lblTotal.Text = string.Empty;
            lblTotal.Visible = false;

            lbDetalhesDesc.Text = string.Empty;
            lbDetalhesDesc.Visible = false;
            lbDetalhesCodigo.Text = string.Empty;
            lbDetalhesCodigo.Visible = false;
            lbDetalhesEstoque.Text = string.Empty;
            lbDetalhesEstoque.Visible = false;
            lbDetalhesPreco.Text = string.Empty;
            lbDetalhesPreco.Visible = false;
            lbDetalhesReferencia.Text = string.Empty;
            lbDetalhesReferencia.Visible = false;
            lbIdCliente.Text = string.Empty;
            lbIdCliente.Visible = false;
            lbNomeCliente.Text = string.Empty;
            lbNomeCliente.Visible = false;
            TfId.Focus();
            quantidade = 0;
            total = 0;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void JanelaVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (string.IsNullOrEmpty(TfId.Text.ToString()) && string.IsNullOrEmpty(TfQtd.Text.ToString()) && string.IsNullOrEmpty(TfPreco.Text.ToString()) && listBox1.Items.Count <= 0 && string.IsNullOrEmpty(lbIdCliente.Text))
                {
                    this.Close();
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Cancelar venda?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (resultado == DialogResult.Yes)
                    {
                        LimparCampos();
                    }

                }
            }

            if (e.KeyCode == Keys.F3)
            {
                F3.PerformClick();
            }

            if (e.KeyCode == Keys.F4)
            {
                F4.PerformClick();
            }

            if (e.KeyCode == Keys.F5)
            {
                F5.PerformClick();
            }

            if (e.KeyCode == Keys.F6)
            {
                F5.PerformClick();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void F4_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void F5_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void F6_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void F5_Click(object sender, EventArgs e)
        {
            Venda v = new Venda();
            if (listaProdutos.Count > 0)
            {
                if (string.IsNullOrEmpty(lbIdCliente.Text) && string.IsNullOrEmpty(lbNomeCliente.Text))
                {
                    vendaDAO.Venda(v, listaProdutos);
                }
                else
                {
                    Clientes c = new Clientes(Convert.ToInt32(lbIdCliente.Text), lbNomeCliente.Text);
                    vendaDAO.Venda(c, v, listaProdutos);
                }

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Não é possível finalizar uma venda sem produto!");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfId.Text.ToString()))
            {
                try
                {
                    id = int.Parse(TfId.Text.ToString());
                }
                catch
                {
                    MessageBox.Show("Produto não encontrado!");
                    TfId.Focus();
                    return;
                }
                DataTable dt = produtoDAO.ListarNomeById(TfId.Text.ToString());
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = null;
                    row = dt.Rows[0];
                    TfId.Text = row["descricao"].ToString().ToUpper();
                    TfQtd.Text = "1,0";
                    TfPreco.Text = row["preco"].ToString();
                    lbDetalhesCodigo.Text = id.ToString();
                    lbDetalhesDesc.Text = row["descricao"].ToString().ToUpper();
                    lbDetalhesReferencia.Text = row["referencia"].ToString().ToUpper();
                    lbDetalhesPreco.Text = row["preco"].ToString();
                    lbDetalhesEstoque.Text = row["estoque"].ToString();

                    lbDetalhesCodigo.Visible = true;
                    lbDetalhesDesc.Visible = true;
                    lbDetalhesEstoque.Visible = true;
                    lbDetalhesPreco.Visible = true;
                    lbDetalhesReferencia.Visible = true;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado!");
                    TfId.Focus();
                }
            }

        }

        private void TfPreco_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (vendaDAO.Validações(Convert.ToDouble(TfPreco.Text), Convert.ToDouble(TfQtd.Text)))
                {
                    Produtos p = new Produtos();
                    p.codigo = id;
                    p.descricao = TfId.Text.ToString();
                    p.preco = double.Parse(TfPreco.Text);
                    p.quantidade = double.Parse(TfQtd.Text);
                    quantidade += p.quantidade;
                    total += p.preco * p.quantidade;

                    lblQtd.Text = quantidade.ToString();
                    lblQtd.Visible = true;

                    lblTotal.Text = total.ToString();
                    lblTotal.Visible = true;


                    listaProdutos.Add(p);
                    listBox1.Items.Clear();
                    foreach (var produtos in listaProdutos)
                    {
                        string linha =
                        produtos.codigo.ToString().PadLeft(0) +
                        produtos.descricao.ToString().PadLeft(33) +
                        produtos.quantidade.ToString().PadLeft(35) +
                        produtos.preco.ToString("C", new CultureInfo("pt-BR")).PadLeft(19);

                        listBox1.Items.Add(linha);
                    }
                    TfId.Text = string.Empty;
                    TfQtd.Text = string.Empty;
                    TfPreco.Text = string.Empty;

                    lbDetalhesDesc.Text = string.Empty;
                    lbDetalhesDesc.Visible = false;
                    lbDetalhesCodigo.Text = string.Empty;
                    lbDetalhesCodigo.Visible = false;
                    lbDetalhesEstoque.Text = string.Empty;
                    lbDetalhesEstoque.Visible = false;
                    lbDetalhesPreco.Text = string.Empty;
                    lbDetalhesPreco.Visible = false;
                    lbDetalhesReferencia.Text = string.Empty;
                    lbDetalhesReferencia.Visible = false;
                    TfId.Focus();
                }
            }
        }

        private void F3_Click(object sender, EventArgs e)
        {
            JanelaClienteVenda janelaClienteVenda = new JanelaClienteVenda(this);
            janelaClienteVenda.Show();
            janelaClienteVenda.TopMost = true;
            janelaClienteVenda.BringToFront();
            janelaClienteVenda.Focus();
        }

        private void F4_Click(object sender, EventArgs e)
        {
            JanelaDesconto janelaDesconto = new JanelaDesconto(this);
            janelaDesconto.Show();
            janelaDesconto.TopMost = true;
            janelaDesconto.BringToFront();
            janelaDesconto.Focus();
            janelaDesconto.TfSubtotal.Text = lblTotal.Text;
            janelaDesconto.TfTotal.Text = lblTotal.Text;
        }

        private void JanelaVenda_Load(object sender, EventArgs e)
        {

        }
    }
}
