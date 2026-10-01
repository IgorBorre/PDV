

using PDV.Classes_DAO;

namespace PDV.Telas
{
    public partial class JanelaLogin : Form
    {
        VendaDAO _vendaDAO;
        public JanelaLogin(VendaDAO vendaDAO)
        {
            InitializeComponent();
            _vendaDAO = vendaDAO;
        }

        private void TfUsuario_Enter(object sender, EventArgs e)
        {
            if (TfUsuario.Text == "Nome de usuário")
                TfUsuario.Text = string.Empty;
        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new();
            if(usuarioDAO.VerificaLogin(TfUsuario.Text, TfSenha.Text))
            {
                Form1 form1 = new(_vendaDAO);
                form1.Show();
            }
        }

        private void TfUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TfUsuario.Text))
                TfUsuario.Text = "Nome de usuário";
        }

        private void TfSenha_Enter(object sender, EventArgs e)
        {
            if (TfSenha.Text == "Senha")
                TfSenha.Text = string.Empty;

            TfSenha.UseSystemPasswordChar = true;
        }

        private void TfSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TfSenha.Text))
            {
                TfSenha.Text = "Senha";
                TfSenha.UseSystemPasswordChar = false;
            }
        }

    }
}
