using PDV.Classes;
using PDV.Classes_DAO;
using System.Data;

namespace PDV.Telas
{
    public partial class JanelaUsuarioNovo : Form
    {
        readonly JanelaUsuarios _janelaUsuarios;
        readonly UsuarioDAO _usuarioDAO;
        readonly VendaDAO _vendaDAO;
        public JanelaUsuarioNovo(JanelaUsuarios janelaUsuarios)
        {
            InitializeComponent();
            _janelaUsuarios = janelaUsuarios;
            _usuarioDAO = new();
            _vendaDAO = new();
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TfId.Text))
            {
                if (_usuarioDAO.Validacoes(TfUsuario.Text, TfSenha.Text))
                {
                    Usuarios u = new()
                    {
                        nome = TfUsuario.Text,
                        senha = TfSenha.Text
                    };
                    if (!_usuarioDAO.UsuarioExiste(u))
                    {
                        _usuarioDAO.InserirUsuario(u);
                        TfId.Text = u.codigo.ToString();

                        if (!string.IsNullOrEmpty(_janelaUsuarios.c))
                        {
                            DataTable dt = _vendaDAO.ConsultaSaidas(_janelaUsuarios.c);
                            _janelaUsuarios.dataGridView1.DataSource = dt;
                            _janelaUsuarios.dataGridView1.ClearSelection();
                        }
                        else
                        {
                            DataTable dt = new();

                            dt.Columns.Add("codigo");
                            dt.Columns.Add("nome");

                            DataRow row = dt.NewRow();

                            row["codigo"] = u.codigo;
                            row["nome"] = u.nome;

                            dt.Rows.Add(row);

                            _janelaUsuarios.dataGridView1.DataSource = dt;
                            _janelaUsuarios.dataGridView1.ClearSelection();
                        }
                    }
                    else {
                        MessageBox.Show("Já existe um usuário com esse nome!");
                    }
                }
            }
            else { 
                Usuarios u = new()
                {
                    codigo = int.Parse(TfId.Text),
                    nome = TfUsuario.Text,
                    senha = TfSenha.Text
                };
                if (!_usuarioDAO.UsuarioExiste(u))
                {
                    _usuarioDAO.AtualizaUsuario(u);
                    DataTable dt = _vendaDAO.ConsultaSaidas(_janelaUsuarios.c);
                    _janelaUsuarios.dataGridView1.DataSource = dt;
                }
                else { 
                    MessageBox.Show("Já existe um usuário com esse nome!");
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

        private void JanelaUsuarioNovo_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TfId.Text)) { 
                LbSenha.Text = "Nova Senha";
            }
        }
    }
}
