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

            //se a data não estiver preenchida, exclui as '//' do texto para salvar null no banco
            if (TfNascimento.Text == "  /  /") { 

                TfNascimento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; 
            }

            /*atribui os valores dos campos para os atributos da classe para que sejam passados nas 
            funções de insert e update*/
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
            c.nascimento = TfNascimento.Text;
            c.referencia = TfReferencia.Text;
            c.numero = TfNumero.Text;

            //se o campo TfCodigo estiver vazio, o código chamado será o de inserção no banco
            if (string.IsNullOrEmpty(TfCodigo.Text))
            {
                if (!clientedao.Validacoes(c))
                {
                    clientedao.InserirCliente(c);
                    TfCodigo.Text = c.codigo.ToString();
                }

            }
            //se não, o código chamado será o de atualização das informações no banco
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

        private void CadastroGeralNovo_Load(object sender, EventArgs e)
        {
            /*se ao abrir a janela, o campo TfCodigo estiver preenchido, faz um select no banco 
            com as informações do cliente buscando pelo id*/
            if (!string.IsNullOrEmpty(TfCodigo.Text)) { 
                DataTable dt = clientedao.ClienteByID(TfCodigo.Text);
                DataRow row = null;
                row = dt.Rows[0];

                //preenche os campos com as informações das linhas da tabela que vai ser criada com o select
                TfNome.Text = row["nome"].ToString();
                TfIdentificacao.Text = row["identificacao"].ToString();
                TfCidade.Text = row["cidade"].ToString();
                TfCep.Text = row["cep"].ToString();
                TfBairro.Text = row["bairro"].ToString();
                TfComplemento.Text = row["complemento"].ToString();
                TfNascimento.Text = row["nascimento"].ToString();
                TfNumero.Text = row["numero"].ToString();
                TfReferencia.Text = row["referencia"].ToString();
                TfRua.Text = row["rua"].ToString();
                TfTelefone.Text = row["telefone"].ToString();
                CBEstado.SelectedItem = row["estado"].ToString();
                CBLogradouro.SelectedItem = row["logradouro"].ToString();
                CBSituacao.SelectedItem = row["situacao"].ToString();
            }
        }
    }
}
