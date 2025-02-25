using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PDV
{
    public class GrupoDAO
    {
        private Conexao conexao;
        public GrupoDAO() { 
            conexao  = new Conexao();
        }

        public void InserirGrupo(Grupo g) {
            string comando = "insert into grupos (nome) values (@nome)";

            try
            {
                conexao.AbrirConexao();

                using (MySqlCommand cmd = new MySqlCommand(comando, conexao.ObterConexao()))
                {
                    cmd.Parameters.AddWithValue("@nome", g.nome);
                    cmd.ExecuteNonQuery();


                    cmd.CommandText = "Select @@IDENTITY";
                    g.id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conexao.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao criar grupo: " + e.Message);
            }
        
        }

        public void AtualizarGrupo(Grupo g) {
            string comando = "update grupos set nome = @nome where id = @id";

            try
            {
                conexao.AbrirConexao();

                using (MySqlCommand cmd = new MySqlCommand(comando, conexao.ObterConexao()))
                {
                    cmd.Parameters.AddWithValue("@nome", g.nome);
                    cmd.Parameters.AddWithValue("@id", g.id);
                    cmd.ExecuteNonQuery();
                }
                conexao.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao atualizar grupo: " + e.Message);
            }
        }
    }
}
