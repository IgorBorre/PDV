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
    public partial class CadastroGeralNovo : Form
    {
        private ClienteDAO clientedao;
        public CadastroGeralNovo()
        {
            InitializeComponent();
            clientedao = new ClienteDAO();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtOK_Click(object sender, EventArgs e)
        {

            Clientes c = new Clientes();

            c.nome = TfNome.Text;
            TfTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            c.telefone = TfTelefone.Text;
            c.estado = CBEstado.Text;
            c.complemento = TfComplemento.Text;
            c.logradouro = CBLogradouro.Text;
            c.situacao = CBSituacao.Text;
            c.identificacao = TfIdentificacao.Text;
            c.cep = TfCep.Text;
            c.bairro = TfBairro.Text;
            c.cidade = TfCidade.Text;
            c.rua = TfRua.Text;
            TfNascimento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            c.nascimento = TfNascimento.Text;
            c.referencia = TfReferencia.Text;
            c.numero = TfNumero.Text;

            if (TfCodigo.Text == "")
            {
                if (!clientedao.Validacoes(c))
                {
                    clientedao.InserirCliente(c);
                    TfCodigo.Text = c.codigo.ToString();
                }
                
            }
            else
            {
                if (!clientedao.Validacoes(c))
                {
                    c.codigo = Convert.ToInt32(TfCodigo.Text);
                    clientedao.AtualizarCliente(c);
                }
            }


        }

        private void TfTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
