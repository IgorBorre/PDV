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
    public partial class JanelaClienteVenda : Form
    {
        ClienteDAO clienteDAO;
        private JanelaVenda janelaVenda;
        public JanelaClienteVenda(JanelaVenda janela)
        {
            InitializeComponent();
            clienteDAO = new ClienteDAO();
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
                }
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.codigo = Convert.ToInt32(tfCodigo.Text);
            c.nome = tfNome.Text;
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
                string c = "select nome from clientes where codigo = " + tfCodigo.Text;
                DataTable dt = clienteDAO.ListarClientes(c);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = null;
                    row = dt.Rows[0];
                    tfNome.Text = row["nome"].ToString().ToUpper();
                    btOk.Enabled = true;
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
            btOk.Enabled = false;
        }
    }
}
