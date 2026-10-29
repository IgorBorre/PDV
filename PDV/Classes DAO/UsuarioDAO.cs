using System.Data;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using PDV.Classes;
using PDV.Conexão;

namespace PDV.Classes_DAO
{
    internal class UsuarioDAO
    {
       readonly Conexao conexao;

        public UsuarioDAO()
        {
            conexao = new();
        }


        public static string HashSenha(string senha)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(senha);
            byte[] hash = SHA256.HashData(bytes);
            return Convert.ToBase64String(hash);
        }


        public void InserirUsuario(Usuarios u)
        {
            string comando = "INSERT INTO usuarios (nome, senha) values (@nome, @senha)";

            try
            {
                conexao.AbrirConexao();

                using (MySqlCommand cmd = new(comando, conexao.ObterConexao()))
                {
                    cmd.Parameters.AddWithValue("@nome", u.nome);
                    cmd.Parameters.AddWithValue("@senha", HashSenha(u.senha));

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT @@IDENTITY";
                    u.codigo = Convert.ToInt32(cmd.ExecuteScalar());
                    MessageBox.Show($"Usuário {u.codigo} cadastrado com sucesso!");

                }
                conexao.FecharConexao();
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao cadastrar usuário: " + e.Message);
            }
        }


        public void AtualizaUsuario(Usuarios u){
            if (!string.IsNullOrEmpty(u.nome))
            {
                string comando;
                if (string.IsNullOrEmpty(u.senha))
                {
                    comando = "Update usuarios set nome = @nome where codigo = @codigo";
                }
                else
                {
                    comando = "Update usuarios set nome = @nome, senha = @senha where codigo = @codigo";
                }
                try
                {
                    conexao.AbrirConexao();

                    using (MySqlCommand cmd = new(comando, conexao.ObterConexao()))
                    {
                        cmd.Parameters.AddWithValue("@codigo", u.codigo);
                        cmd.Parameters.AddWithValue("@nome", u.nome);
                        cmd.Parameters.AddWithValue("@senha", HashSenha(u.senha));


                        MessageBox.Show("Informações atualizadas!");

                        cmd.ExecuteNonQuery();
                    }
                    conexao.FecharConexao();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao atualizar usuário: " + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Não é permitido salvar um usuário sem nome!");
            }
        }


        public bool Validacoes(string nome, string senha) {
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha o nome de usuário e a senha");
                return false;
            }
            else
            {
                return true;
            }
        }


        public bool VerificaLogin(string nome, string senha) { 
            string comando = $"select * from usuarios where nome = '{nome}' and senha = '{HashSenha(senha)}'";

            VendaDAO vendaDAO = new();

            DataTable dt = vendaDAO.ConsultaSaidas(comando);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else {
                MessageBox.Show("Usuário ou senha incorretos");
                return false;
            }
        }


        public bool UsuarioExiste(Usuarios u)
        {
            string comando = $"select * from usuarios where nome = '{u.nome}'";

            VendaDAO vendaDAO = new();

            DataTable dt = vendaDAO.ConsultaSaidas(comando);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
