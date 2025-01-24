using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PDV
{
    public class Conexao
    {
        private string str = "server=localhost;uid=root;pwd=masterkey;database=pdv;Port=3305;";
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
    }
}
