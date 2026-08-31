using MySql.Data.MySqlClient;

namespace PDV.Conexão
{
    public class Conexao
    {
        private readonly string str = "server=localhost;uid=root;pwd=masterkey;database=pdv";
        private readonly MySqlConnection conexao;

        public Conexao()
        {
            conexao = new(str);
        }

        public void AbrirConexao()
        {
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao conetar com o banco: " + e);
            }
        }

        public MySqlConnection ObterConexao() { 
            return conexao;
        }

        public void FecharConexao()
        {
            conexao.Close();
        }
    }
}
