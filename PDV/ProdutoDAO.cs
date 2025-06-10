using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PDV
{
    public class ProdutoDAO
    {
        private Conexao conexao;

        public ProdutoDAO()
        {
            conexao = new Conexao();
        }

        public void InserirProduto(Produtos p) {
            string comando = "insert into produtos (referencia, descricao, estoque, preco, idGrupo, grupo) values " +
                "(@referencia, @descricao, @estoque, @preco, @idGrupo, @grupo)";

            try
            {
                conexao.AbrirConexao();

                using (MySqlCommand cmd = new MySqlCommand(comando, conexao.ObterConexao()))
                {
                    cmd.Parameters.AddWithValue("@referencia", p.referencia);
                    cmd.Parameters.AddWithValue("@descricao", p.descricao);
                    cmd.Parameters.AddWithValue("@estoque", p.estoque);
                    cmd.Parameters.AddWithValue("@preco", p.preco);
                    cmd.Parameters.AddWithValue("@idGrupo", p.idGrupo == null ? (object)DBNull.Value : p.idGrupo);
                    cmd.Parameters.AddWithValue("@grupo", p.grupo);
                    cmd.ExecuteNonQuery();


                    cmd.CommandText = "Select @@IDENTITY";
                    p.codigo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conexao.FecharConexao();
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao inserir produto: " + e);
            }

        }

        public void AtualizarProduto(Produtos p)
        {
            string comando = "update produtos set referencia = @referencia, descricao = @descricao, estoque = @estoque, preco = @preco, idGrupo = @idGrupo, " +
                "grupo = @grupo where codigo = @codigo";
            try
            {
                conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand(comando, conexao.ObterConexao()))
                {
                    cmd.Parameters.AddWithValue("@referencia", p.referencia);
                    cmd.Parameters.AddWithValue("@descricao", p.descricao);
                    cmd.Parameters.AddWithValue("@estoque", p.estoque);
                    cmd.Parameters.AddWithValue("@preco", p.preco);
                    cmd.Parameters.AddWithValue("@codigo", p.codigo);
                    cmd.Parameters.AddWithValue("@idGrupo", p.idGrupo);
                    cmd.Parameters.AddWithValue("@grupo", p.grupo);
                    cmd.ExecuteNonQuery();
                }
                conexao.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao atualizar produto: " + e);
            }
        }


        public DataTable ListarProdutos(string c)
        {
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

        public DataTable ListarProdutoByiD(string codigo) { 
            
            string comando = "select * from produtos where codigo = " + codigo;
            return ListarProdutos(comando);


        }

        public DataTable ListarNomeById(string id)
        {
            string comando = "select descricao, referencia, estoque, preco from produtos where codigo = " + id;
            return ListarProdutos(comando);
       }

        public bool Validacoes(string descricao, string estoque, string preco) {
            if (string.IsNullOrEmpty(descricao) || string.IsNullOrEmpty(estoque)
                || string.IsNullOrEmpty(preco)) {
                MessageBox.Show("Os campos Descrição, Estoque e Preço não podem ser vazios!");
                return false;
            }
            else
            {
                return true;
            }
        
        }

        public string Criterios(string codigo, string referencia, string descricao, string grupo) {
            string a = "";

            if (!string.IsNullOrEmpty(codigo)) { 
                a += " and codigo = " + codigo;
            }
            if (!string.IsNullOrEmpty(referencia)) { 
                a += " and referencia like '%"  + referencia + "%'";
            }
            if (!string.IsNullOrEmpty(descricao)) { 
                a += " and descricao like '%" + descricao + "%'";
            }
            if (!string.IsNullOrEmpty(grupo)) { 
                a += " and grupo like '%" + grupo + "%'";
            }
            return a;
        }

    }
}
