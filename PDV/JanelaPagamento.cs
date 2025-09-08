using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Internal;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class JanelaPagamento : Form
    {
        private FormasdePagamentoDAO formasdePagamentoDAO;

        public List<FormasdePagamento> listaFormasdePagamento = new List<FormasdePagamento>();
        public JanelaPagamento()
        {
            InitializeComponent();
            formasdePagamentoDAO = new FormasdePagamentoDAO();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void JanelaPagamento_Load(object sender, EventArgs e)
        {

            //Assim que a janela abrir lista todas as formas de pagamento ativas cadastradas no sistema
            this.TopMost = true;
            this.BringToFront();
            this.Focus();
            string c = "SELECT id, descricao FROM formas_pagamento WHERE ativa = 'Sim'";
            formasdePagamentoDAO.ListarFormasdePagamento(c);
            dataGridView1.DataSource = formasdePagamentoDAO.ListarFormasdePagamento(c);
            BtFinalizar.Enabled = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            double falta = Convert.ToDouble(LbFalta.Text);
            //Faz a verificação se o valor da venda já foi antingido ou superado para não permitir mais pagamentos
            if (falta > 0)
            {
                DataTable dt = formasdePagamentoDAO.ListarAvista(Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value));
                DataRow row = null;
                row = dt.Rows[0];

                ConfirmarPagamento confirmarPagamento = new ConfirmarPagamento(this);

                //Se a forma de pagamento for à vista, mantém o número de parcelas em 1 como padrão
                if (row["avista"].ToString() == "Sim")
                {
                    confirmarPagamento.TfParcelas.Enabled = false;
                    confirmarPagamento.ShowDialog(this);
                }
                else
                {
                    confirmarPagamento.ShowDialog(this);
                }

                //Se a janela ConfirmarPagamento retornar Ok, adiciona a forma de pagamento na lista
                if (confirmarPagamento.DialogResult == DialogResult.OK)
                {
                    FormasdePagamento f = new FormasdePagamento(
                        Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value),
                        dataGridView1.CurrentRow.Cells["descricao"].Value.ToString(),
                        confirmarPagamento.Parcelas,
                        confirmarPagamento.ValorPago
                        );

                    listaFormasdePagamento.Add(f);
                    listBox1.Items.Clear();

                    //For para concatenar as informações da forma de pagamento em uma única linha para depois inserir a linha na Listbox
                    foreach (var formasdepagamento in listaFormasdePagamento)
                    {

                        string linha =
                        formasdepagamento.id.ToString().PadLeft(0) +
                        formasdepagamento.descricao.PadLeft(25) +
                        formasdepagamento.parcelas.ToString().PadLeft(55) +
                        formasdepagamento.valor.ToString("C", new CultureInfo("pt-BR")).PadLeft(23);

                        listBox1.Items.Add(linha);
                    }

                    double pago = confirmarPagamento.ValorPago;
                    int parcelas = confirmarPagamento.Parcelas;

                    double aux = Convert.ToDouble(LbFalta.Text);
                    double falta2 = aux - confirmarPagamento.ValorPago;

                    // Atualiza o valor pago na venda
                    LbPago.Text = (Convert.ToDouble(LbPago.Text) + confirmarPagamento.ValorPago).ToString("F2");


                    double total = Convert.ToDouble(LbTotal.Text);

                    // se o valor pago for igual ou maior que o valor total da venda, habilita o botão finalizar
                    if (Convert.ToDouble(LbPago.Text) >= total)
                    {
                        BtFinalizar.Enabled = true;
                    }


                    if (falta2 > 0)
                    {
                        // se o valor da variável falta for maior que 0, atualizar a label com o valor da variável falta
                        LbFalta.Text = falta2.ToString("F2");
                    }
                    else
                    {
                        // se for menor que 0, a label falta recebe 0 e o valor excedente é mostrado na label troco
                        LbFalta.Text = "0,00";
                        double troco = (Convert.ToDouble(LbPago.Text) - total);
                        LbTroco.Text = troco.ToString("F2");
                    }
                }
            }
            else
            {
                MessageBox.Show("Pagamento já efetuado!");
            }

        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listaFormasdePagamento.Clear();
            LbFalta.Text = LbTotal.Text;
            LbPago.Text = "0,00";
            BtFinalizar.Enabled = false;
            LbTroco.Text = "0,00";
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Finalizar pagamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                Dispose();
            }
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            double falta = Convert.ToDouble(LbFalta.Text);
            //Faz a verificação se o valor da venda já foi antingido ou superado para não permitir mais pagamentos
            if (falta > 0)
            {
                DataTable dt = formasdePagamentoDAO.ListarAvista(Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value));
                DataRow row = null;
                row = dt.Rows[0];

                ConfirmarPagamento confirmarPagamento = new ConfirmarPagamento(this);

                //Se a forma de pagamento for à vista, mantém o número de parcelas em 1 como padrão
                if (row["avista"].ToString() == "Sim")
                {
                    confirmarPagamento.TfParcelas.Enabled = false;
                    confirmarPagamento.ShowDialog(this);
                }
                else
                {
                    confirmarPagamento.ShowDialog(this);
                }

                //Se a janela ConfirmarPagamento retornar Ok, adiciona a forma de pagamento na lista
                if (confirmarPagamento.DialogResult == DialogResult.OK)
                {
                    FormasdePagamento f = new FormasdePagamento(
                        Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigo"].Value),
                        dataGridView1.CurrentRow.Cells["descricao"].Value.ToString(),
                        confirmarPagamento.Parcelas,
                        confirmarPagamento.ValorPago
                        );

                    listaFormasdePagamento.Add(f);
                    listBox1.Items.Clear();

                    //For para concatenar as informações da forma de pagamento em uma única linha para depois inserir a linha na Listbox
                    foreach (var formasdepagamento in listaFormasdePagamento)
                    {

                        string linha =
                        formasdepagamento.id.ToString().PadLeft(0) +
                        formasdepagamento.descricao.PadLeft(25) +
                        formasdepagamento.parcelas.ToString().PadLeft(55) +
                        formasdepagamento.valor.ToString("C", new CultureInfo("pt-BR")).PadLeft(23);

                        listBox1.Items.Add(linha);
                    }

                    double pago = confirmarPagamento.ValorPago;
                    int parcelas = confirmarPagamento.Parcelas;

                    double aux = Convert.ToDouble(LbFalta.Text);
                    double falta2 = aux - confirmarPagamento.ValorPago;

                    // Atualiza o valor pago na venda
                    LbPago.Text = (Convert.ToDouble(LbPago.Text) + confirmarPagamento.ValorPago).ToString("F2");


                    double total = Convert.ToDouble(LbTotal.Text);

                    // se o valor pago for igual ou maior que o valor total da venda, habilita o botão finalizar
                    if (Convert.ToDouble(LbPago.Text) >= total)
                    {
                        BtFinalizar.Enabled = true;
                    }


                    if (falta2 > 0)
                    {
                        // se o valor da variável falta for maior que 0, atualizar a label com o valor da variável falta
                        LbFalta.Text = falta2.ToString("F2");
                    }
                    else
                    {
                        // se for menor que 0, a label falta recebe 0 e o valor excedente é mostrado na label troco
                        LbFalta.Text = "0,00";
                        double troco = (Convert.ToDouble(LbPago.Text) - total);
                        LbTroco.Text = troco.ToString("F2");
                    }
                }
            }
            else
            {
                MessageBox.Show("Pagamento já efetuado!");
            }
        }
    }
}
