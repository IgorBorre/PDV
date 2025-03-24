using System;
using System.Collections.Generic;
using System.Data;
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


        public DataTable BuscarGrupo(string c) {
            
            DataTable dt = new DataTable();
            try
            {
                conexao.AbrirConexao();
                using (MySqlCommand command = new MySqlCommand(c, conexao.ObterConexao()))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }
                }
                conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;

        }

        public DataTable BuscarGrupoById(string id) { 
            string comando = "select * from grupos where id = " + id;
            return BuscarGrupo(comando);
        }

        public DataTable BuscarNomeGrupo(string id) { 
            string comando = "select nome from grupos where id = " + id;
            return BuscarGrupo(comando);
        }

        public DataTable BuscarIdGrupo(string nome) {
            string comando = "select * from grupos where nome like '%" + nome + "%'";
            return BuscarGrupo(comando);
        }

        public string Criterios(string codigo, string nome) {
            string a = "";

            if (!string.IsNullOrEmpty(codigo)) { 
                a += " and id = " + codigo;
            }
            if (!string.IsNullOrEmpty(nome)) { 
                a += " and nome like '%" + nome + "%'";
            }

            return a;
        }

        public bool Validacoes(Grupo g)
        {
            if (string.IsNullOrEmpty(g.nome))
            {
                MessageBox.Show("Nome do grupo não pode ser vazio");
                return false;
            }
            return true;
        }
    }
}
