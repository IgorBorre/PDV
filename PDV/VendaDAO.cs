using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV
{
    public class VendaDAO
    {
        private Conexao con;

        public VendaDAO() { 
            con = new Conexao();
        }

        public void Venda(Clientes c, Venda v, List<Produtos> produtos) {
            string comandoSaida = "insert into saida (clienteId, clienteNome, dataSaida) values (@clienteId, @clienteNome, @dataSaida)";
            string comandoSaidaDados = "insert into saidadados (documento, produto, produtoNome, quantidade) values (@documento, @produto, @produtoNome, @quantidade)";
            string updateProdutos = "update produtos set estoque = estoque - @quantidade where codigo = @codigo";

            v.dataVenda = DateTime.Now.Date;

            try
            {
                con.AbrirConexao();

                using (MySqlCommand cmd = new MySqlCommand(comandoSaida, con.ObterConexao())) {
                    cmd.Parameters.AddWithValue("@clienteId", c.codigo);
                    cmd.Parameters.AddWithValue("@clienteNome", c.nome);
                    cmd.Parameters.AddWithValue("@dataSaida", v.dataVenda);

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT @@IDENTITY";
                    v.codigo = Convert.ToInt32(cmd.ExecuteScalar());
                }

                foreach (Produtos p in produtos)
                {
                    using (MySqlCommand cmd = new MySqlCommand(comandoSaidaDados, con.ObterConexao()))
                    {
                        cmd.Parameters.AddWithValue("@documento", v.codigo);
                        cmd.Parameters.AddWithValue("@produto", p.codigo);
                        cmd.Parameters.AddWithValue("@produtoNome", p.descricao);
                        cmd.Parameters.AddWithValue("@quantidade", p.quantidade);

                        cmd.ExecuteNonQuery();

                    }

                    using (MySqlCommand cmd = new MySqlCommand(updateProdutos, con.ObterConexao())) {
                        cmd.Parameters.AddWithValue("@quantidade", p.quantidade);
                        cmd.Parameters.AddWithValue("@codigo", p.codigo);
                        
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        public void Venda(Venda v, List<Produtos> produtos) {
            string comandoSaida = "insert into saida (dataSaida) values (@dataSaida)";
            string comandoSaidaDados = "insert into saidadados (documento, produto, produtoNome, quantidade) values (@documento, @produto, @produtoNome, @quantidade)";
            string updateProdutos = "update produtos set estoque = estoque - @quantidade where codigo = @codigo";

            v.dataVenda = DateTime.Now.Date;

            try
            {
                con.AbrirConexao();

                using (MySqlCommand cmd = new MySqlCommand(comandoSaida, con.ObterConexao()))
                {
                    cmd.Parameters.AddWithValue("@dataSaida", v.dataVenda);

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT @@IDENTITY";
                    v.codigo = Convert.ToInt32(cmd.ExecuteScalar());
                }

                foreach (Produtos p in produtos)
                {
                    using (MySqlCommand cmd = new MySqlCommand(comandoSaidaDados, con.ObterConexao()))
                    {
                        cmd.Parameters.AddWithValue("@documento", v.codigo);
                        cmd.Parameters.AddWithValue("@produto", p.codigo);
                        cmd.Parameters.AddWithValue("@produtoNome", p.descricao);
                        cmd.Parameters.AddWithValue("@quantidade", p.quantidade);
                        cmd.ExecuteNonQuery();

                    }

                    using (MySqlCommand cmd = new MySqlCommand(updateProdutos, con.ObterConexao()))
                    {
                        cmd.Parameters.AddWithValue("@quantidade", p.quantidade);
                        cmd.Parameters.AddWithValue("@codigo", p.codigo);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Documento " + v.codigo.ToString() + " gravado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
