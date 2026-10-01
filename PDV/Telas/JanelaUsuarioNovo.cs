using PDV.Classes;
using PDV.Classes_DAO;

namespace PDV.Telas
{
    public partial class JanelaUsuarioNovo : Form
    {
        readonly JanelaUsuarios _janelaUsuarios;
        readonly UsuarioDAO _usuarioDAO;
        public JanelaUsuarioNovo(JanelaUsuarios janelaUsuarios)
        {
            InitializeComponent();
            _janelaUsuarios = janelaUsuarios;
            _usuarioDAO = new();
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TfId.Text)) { 
                if(_usuarioDAO.Validacoes(TfUsuario.Text, TfSenha.Text))
                {
                    Usuarios u = new()
                    {
                        nome = TfUsuario.Text,
                        senha = TfSenha.Text
                    };
                    _usuarioDAO.InserirUsuario(u);
                    TfId.Text = u.id.ToString();
                }
            }
        }

        private void TfSenha_TextChanged(object sender, EventArgs e)
        {
            TfSenha.UseSystemPasswordChar = true;
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
