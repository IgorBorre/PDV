﻿using System;
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
    public partial class JanelaVenda : Form
    {
        ProdutoDAO produtoDAO;
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
                if (string.IsNullOrEmpty(TfId.Text.ToString()) && string.IsNullOrEmpty(TfQtd.Text.ToString()) && string.IsNullOrEmpty(TfPreco.Text.ToString()))
                {
                    this.Close();
                }
                else
                {
                    TfId.Text = string.Empty;
                    TfQtd.Text = string.Empty;
                    TfPreco.Text = string.Empty;
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
                DataTable dt = produtoDAO.ListarNomeById(TfId.Text.ToString());
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = null;
                    row = dt.Rows[0];
                    TfId.Text = row["descricao"].ToString().ToUpper();
                    TfQtd.Text = "1.0";
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
                p.descricao = TfId.Text.ToString();
                p.preco = double.Parse(TfPreco.Text);
                p.quantidade = double.Parse(TfQtd.Text);

                listBox1.Items.Add(p);
                TfId.Text = string.Empty;
                TfQtd.Text = string.Empty;
                TfPreco.Text = string.Empty;
            }
        }
    }
}
