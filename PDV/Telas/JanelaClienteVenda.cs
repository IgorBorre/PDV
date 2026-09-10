using PDV.Classes;
using System.Data;

namespace PDV
{
    public partial class JanelaClienteVenda : Form
    {
        readonly ClienteDAO clienteDAO;
        private readonly JanelaVenda janelaVenda;
        public JanelaClienteVenda(JanelaVenda janela)
        {
            InitializeComponent();
            clienteDAO = new();
            this.janelaVenda = janela;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tfCodigo.Text) && string.IsNullOrEmpty(tfNome.Text))
            {
                Dispose();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Cancelar inclusão de cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    tfCodigo.Text = string.Empty;
                    tfNome.Text = string.Empty;
                    btOk.Enabled = false;
                }
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Clientes c = new()
            {
                codigo = Convert.ToInt32(tfCodigo.Text),
                nome = tfNome.Text
            };
            janelaVenda.lbIdCliente.Text = c.codigo.ToString();
            janelaVenda.lbNomeCliente.Text = c.nome.ToUpper();
            janelaVenda.lbIdCliente.Visible = true;
            janelaVenda.lbNomeCliente.Visible = true;
            Dispose();
        }

        private void tfCodigo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tfCodigo.Text))
            {
                if (!string.IsNullOrEmpty(tfNome.Text))
                {
                    tfNome.Text = string.Empty;
                }

                string comando = "select nome, situacao from clientes where codigo = " + tfCodigo.Text;
                DataTable dt = clienteDAO.ListarClientes(comando);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    string situacao = row["situacao"].ToString().ToUpper();
                    if (situacao == "NORMAL")
                    {
                        tfNome.Text = row["nome"].ToString().ToUpper();
                        btOk.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Cliente bloqueado!");
                        tfCodigo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                    tfCodigo.Focus();
                }
            }
        }

        private void JanelaClienteVenda_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void JanelaClienteVenda_Load(object sender, EventArgs e)
        {

            this.TopMost = true;
            this.BringToFront();
            this.Focus();
            btOk.Enabled = false;
        }

        private void tfCodigo_TextChanged(object sender, EventArgs e)
        {
            btOk.Enabled = false;
        }
    }
}
