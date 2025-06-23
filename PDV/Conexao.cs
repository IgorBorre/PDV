using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Connection;

namespace PDV
{
    public class Conexao
    {
        private string str = "server=localhost;uid=root;pwd=masterkey;database=pdv";
        private MySqlConnection conexao;

        public Conexao()
        {
            conexao = new MySqlConnection(str);
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
