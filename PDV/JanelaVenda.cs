using System.Data;
using System.Globalization;

namespace PDV
{
    public partial class JanelaVenda : Form
    {
        public double subtotal = 0;
        private readonly ProdutoDAO produtoDAO;
        private readonly VendaDAO _vendaDAO;
        private readonly List<Produtos> listaProdutos = [];
        int id = 0;
        double quantidade = 0;
        double total;
        double troca = 0;

        public JanelaVenda(VendaDAO vendaDAO)
        {
            InitializeComponent();
            produtoDAO = new ProdutoDAO();
            _vendaDAO = vendaDAO;
        }

        private void LimparCampos()
        {
            TfId.Text = string.Empty;
            TfQtd.Text = string.Empty;
            TfPreco.Text = string.Empty;
            listBox1.Items.Clear();
            listaProdutos.Clear();
            lblQtd.Text = "0,00";

            lblTotal.Text = troca.ToString("F2");
            lbDesconto.Text = "0,00";
            lbAcrescimo.Text = "0,00";

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

        private void JanelaVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (string.IsNullOrEmpty(TfId.Text.ToString()) && string.IsNullOrEmpty(TfQtd.Text.ToString()) && string.IsNullOrEmpty(TfPreco.Text.ToString())
                    && listBox1.Items.Count <= 0 && string.IsNullOrEmpty(lbIdCliente.Text))
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

        private JanelaPagamento ValidarJanelaPagamento()
        {
            JanelaPagamento janelaPagamento = new();
            janelaPagamento.LbTotal.Text = lblTotal.Text;
            janelaPagamento.LbFalta.Text = lblTotal.Text;
            janelaPagamento.ShowDialog();

            return janelaPagamento;

        }

        private void F5_Click(object sender, EventArgs e)
        {
        
            if (listaProdutos.Count > 0)
            {
                if (string.IsNullOrEmpty(LbDocumento.Text))
                {
                    var janelaPagamento = ValidarJanelaPagamento();
                    if (janelaPagamento.DialogResult == DialogResult.OK)
                    {
                        Venda v = new()
                        {
                            valorTotal = double.Parse(lblTotal.Text),
                            desconto = double.Parse(lbDesconto.Text),
                            acrescimo = double.Parse(lbAcrescimo.Text),
                            subtotal = subtotal
                        };
                        var clientes = string.IsNullOrEmpty(lbIdCliente.Text) && string.IsNullOrEmpty(lbNomeCliente.Text) 
                            ? null : new Clientes(Convert.ToInt32(lbIdCliente.Text), lbNomeCliente.Text);
                        _vendaDAO.Venda(v, listaProdutos, clientes, janelaPagamento.listaFormasdePagamento, null);
                        LimparCampos();
                        subtotal = 0;
                    }
                }
                else 
                {
                    if (total > 0)
                    {
                        var janelaPagamento = ValidarJanelaPagamento();
                        if (janelaPagamento.DialogResult == DialogResult.OK)
                        {
                            Venda v = new()
                            {
                                valorTotal = double.Parse(lblTotal.Text),
                                desconto = double.Parse(lbDesconto.Text),
                                acrescimo = double.Parse(lbAcrescimo.Text),
                                subtotal = subtotal
                            };
                            var clientes = string.IsNullOrEmpty(lbIdCliente.Text) && string.IsNullOrEmpty(lbNomeCliente.Text)
                            ? null : new Clientes(Convert.ToInt32(lbIdCliente.Text), lbNomeCliente.Text);
                            _vendaDAO.Venda(v, listaProdutos, clientes, janelaPagamento.listaFormasdePagamento, LbDocumento.Text);
                            Dispose();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Não há valor a parcelar!");

                        Venda v = new()
                        {
                            valorTotal = double.Parse(lblTotal.Text),
                            desconto = double.Parse(lbDesconto.Text),
                            acrescimo = double.Parse(lbAcrescimo.Text),
                            subtotal = subtotal
                        };
                        var clientes = string.IsNullOrEmpty(lbIdCliente.Text) && string.IsNullOrEmpty(lbNomeCliente.Text)
                            ? null : new Clientes(Convert.ToInt32(lbIdCliente.Text), lbNomeCliente.Text);
                        _vendaDAO.Venda(v, listaProdutos, clientes, null, LbDocumento.Text);
                        Dispose();

                    }

                
                }
               
            }
            else {
                MessageBox.Show("Não é possível finalizar uma saída sem produto!");
            }

            
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfId.Text))
            {
                //tenta converter o texto do campo TfId em int para fazer a pesquisa no banco
                //se nao conseguir, joga uma mensagem de erro ao procurar o produto
                try
                {
                    id = int.Parse(TfId.Text);
                }
                catch
                {
                    MessageBox.Show("Produto não encontrado!");
                    TfId.Focus();
                    return;
                }
                DataTable dt = produtoDAO.ListarNomeById(TfId.Text);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    var descricao = row["descricao"]?.ToString()?.ToUpper() ?? "Sem descrição";              
                    TfId.Text = descricao;
                    TfQtd.Text = "1,0";
                    TfPreco.Text = row["preco"].ToString();
                    lbDetalhesCodigo.Text = id.ToString();
                    lbDetalhesDesc.Text = descricao;
                    lbDetalhesReferencia.Text = row["referencia"]?.ToString()?.ToUpper() ?? "Sem referência";
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
            total = double.Parse(lblTotal.Text);

            if (e.KeyCode == Keys.Enter)
            {
                if (_vendaDAO.Validações(Convert.ToDouble(TfPreco.Text), Convert.ToDouble(TfQtd.Text)))
                {

                    Produtos p = new()
                    {
                        codigo = id,
                        descricao = TfId.Text.ToString(),
                        preco = double.Parse(TfPreco.Text),
                        quantidade = double.Parse(TfQtd.Text)
                    };
                    quantidade += p.quantidade;
                    total += p.preco * p.quantidade;
                    subtotal += p.preco * p.quantidade;

                    lblQtd.Text = quantidade.ToString("N2");
                    lblQtd.Visible = true;

                    lblTotal.Text = total.ToString("N2");
                    lblTotal.Visible = true;


                    lbDesconto.Text = "0,00";
                    lbAcrescimo.Text = "0,00";

                    listaProdutos.Add(p);
                    listBox1.Items.Clear();
                    foreach (var produtos in listaProdutos)
                    {
                        string linha =
                        produtos.codigo.ToString().PadLeft(0) +
                        produtos.descricao.PadLeft(33) +
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
            JanelaClienteVenda janelaClienteVenda = new(this);
            janelaClienteVenda.Show();
        }

        private void F4_Click(object sender, EventArgs e)
        {
            JanelaDesconto janelaDesconto = new(this);
            janelaDesconto.Show();
            janelaDesconto.TfSubtotal.Text = subtotal.ToString("F2");
            janelaDesconto.TfTotal.Text = lblTotal.Text;
        }

        private void JanelaVenda_Load(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(LbDocumento.Text)) {
                string c = "select idCliente, nomeCliente, valor from devolucao where documento = " + LbDocumento.Text;
                DataTable dt = _vendaDAO.ConsultaSaidas(c);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    
                    troca = (Convert.ToDouble(row["valor"])) * -1;

                    lblTotal.Text = troca.ToString("F2");
                    lblTotal.Visible = true;
                    lbIdCliente.Text = row["idCliente"].ToString();
                    lbIdCliente.Visible = true;
                    lbNomeCliente.Text = row["nomeCliente"].ToString();
                    lbNomeCliente.Visible = true;
                }
            }
                                
        } 
    } 
} 
