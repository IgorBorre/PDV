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
        List<Produtos> listaProdutos = new List<Produtos>();
        int id = 0;
        double quantidade = 0;
        double total = 0;
        public JanelaVenda()
        {
            InitializeComponent();
            produtoDAO = new ProdutoDAO();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void JanelaVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (string.IsNullOrEmpty(TfId.Text.ToString()) && string.IsNullOrEmpty(TfQtd.Text.ToString()) && string.IsNullOrEmpty(TfPreco.Text.ToString()) && listBox1.Items.Count <= 0)
                {
                    this.Close();
                }
                else
                {
                    TfId.Text = string.Empty;
                    TfQtd.Text = string.Empty;
                    TfPreco.Text = string.Empty;
                    listBox1.Items.Clear();
                    listaProdutos.Clear();
                    lblQtd.Text = string.Empty ;
                    lblQtd.Visible = false;

                    lblTotal.Text = string.Empty;
                    lblTotal.Visible = false;
                    TfId.Focus();
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

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfId.Text.ToString()))
            {
                id = int.Parse(TfId.Text.ToString());
                DataTable dt = produtoDAO.ListarNomeById(TfId.Text.ToString());
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = null;
                    row = dt.Rows[0];
                    TfId.Text = row["descricao"].ToString().ToUpper();
                    TfQtd.Text = "1,0";
                    TfPreco.Text = row["preco"].ToString();
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

            if (e.KeyCode == Keys.Enter) {
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
                TfId.Focus();
            }
        }
    }
}
