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

        public void Venda(Clientes c, Venda v, List<Produtos> produtos, List<FormasdePagamento> formaspag) {
            string comandoSaida = "insert into saida (clienteId, clienteNome, dataSaida, valortotal, desconto, acrescimo, subtotal) values (@clienteId, @clienteNome, @dataSaida, @valortotal, @desconto, @acrescimo, @subtotal)";
            string comandoSaidaDados = "insert into saidadados (documento, produto, produtoNome, quantidade) values (@documento, @produto, @produtoNome, @quantidade)";
            string updateProdutos = "update produtos set estoque = estoque - @quantidade where codigo = @codigo";
            string comandoPagsaida = "insert into pagsaida (documento, idpagamento, descpagamento, valor, parcelas) values (@documento, @idpagamento, @descpagamento, @valor, @parcelas)";

            v.dataVenda = DateTime.Now.Date;

            try
            {
                con.AbrirConexao();

                using (MySqlCommand cmd = new MySqlCommand(comandoSaida, con.ObterConexao())) {
                    cmd.Parameters.AddWithValue("@clienteId", c.codigo);
                    cmd.Parameters.AddWithValue("@clienteNome", c.nome);
                    cmd.Parameters.AddWithValue("@dataSaida", v.dataVenda);
                    cmd.Parameters.AddWithValue("@valortotal", v.valorTotal);
                    cmd.Parameters.AddWithValue("@desconto", v.desconto);
                    cmd.Parameters.AddWithValue("@acrescimo", v.acrescimo);
                    cmd.Parameters.AddWithValue("@subtotal", v.subtotal);


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

                foreach (FormasdePagamento f in formaspag)
                {
                    using (MySqlCommand cmd = new MySqlCommand(comandoPagsaida, con.ObterConexao()))
                    {
                        cmd.Parameters.AddWithValue("@documento", v.codigo);
                        cmd.Parameters.AddWithValue("@idpagamento", f.id);
                        cmd.Parameters.AddWithValue("@descpagamento", f.descricao);
                        cmd.Parameters.AddWithValue("@valor", f.valor);
                        cmd.Parameters.AddWithValue("@parcelas", f.parcelas);
                        cmd.ExecuteNonQuery();
                    }

                }
                con.FecharConexao();
                MessageBox.Show("Documento " + v.codigo.ToString() + " gravado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }



        public void Venda(Venda v, List<Produtos> produtos, List<FormasdePagamento> formaspag) {
            string comandoSaida = "insert into saida (dataSaida, valortotal, desconto, acrescimo, subtotal) values (@dataSaida, @valortotal, @desconto, @acrescimo, @subtotal)";
            string comandoSaidaDados = "insert into saidadados (documento, produto, produtoNome, quantidade) values (@documento, @produto, @produtoNome, @quantidade)";
            string updateProdutos = "update produtos set estoque = estoque - @quantidade where codigo = @codigo";
            string comandoPagsaida = "insert into pagsaida (documento, idpagamento, descpagamento, valor, parcelas) values (@documento, @idpagamento, @descpagamento, @valor, @parcelas)";

            v.dataVenda = DateTime.Now.Date;

            try
            {
                con.AbrirConexao();

                using (MySqlCommand cmd = new MySqlCommand(comandoSaida, con.ObterConexao()))
                {
                    cmd.Parameters.AddWithValue("@dataSaida", v.dataVenda);
                    cmd.Parameters.AddWithValue("@valortotal", v.valorTotal);
                    cmd.Parameters.AddWithValue("@desconto", v.desconto);
                    cmd.Parameters.AddWithValue("@acrescimo", v.acrescimo);
                    cmd.Parameters.AddWithValue("@subtotal", v.subtotal);

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

                foreach (FormasdePagamento f in formaspag) {
                    using (MySqlCommand cmd = new MySqlCommand(comandoPagsaida, con.ObterConexao())) { 
                        cmd.Parameters.AddWithValue("@documento", v.codigo);
                        cmd.Parameters.AddWithValue("@idpagamento", f.id);
                        cmd.Parameters.AddWithValue("@descpagamento", f.descricao);
                        cmd.Parameters.AddWithValue("@valor", f.valor);
                        cmd.Parameters.AddWithValue("@parcelas", f.parcelas);
                        cmd.ExecuteNonQuery();
                    }
                
                }
                con.FecharConexao();
                MessageBox.Show("Documento " + v.codigo.ToString() + " gravado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool Validações(double preco, double quantidade) {
            if (preco <= 0) { 
                MessageBox.Show("Não é permitido inserir um produto sem valor ou com valor negativo");
                return false;
            }if (quantidade <= 0) { 
                MessageBox.Show("Não é permitido inserir um produto sem quantidade ou com quantidade negativa");
                return false;
            }
            return true;
        }

        public DataTable ConsultaSaidas(string c)
        {
            DataTable dt = new DataTable();
            try
            {
                con.AbrirConexao();
                using (MySqlCommand command = new MySqlCommand(c, con.ObterConexao()))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }
                }
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;

        }

       public String Criterios(string documento, string cliente, string data1, string data2) {

            string a = "";

            if (!string.IsNullOrEmpty(documento))
            {
                a += " and documento = " + documento;
            }

            if (!string.IsNullOrEmpty(data1) && !string.IsNullOrEmpty(data2)) { 
                a += " and dataSaida between" + "'"+data1+"'" + " and "+ "'"+data2+"'";
            }

            if (!string.IsNullOrEmpty(cliente)) {
                a += " and clienteNome like '%" + cliente + "%'";
            }

            if (!string.IsNullOrEmpty(data1) && string.IsNullOrEmpty(data2)) { 
                a += " and dataSaida >= '" +data1+ "'";
            }

            if (string.IsNullOrEmpty(data1) && !string.IsNullOrEmpty(data2)) {
                a += " and dataSaida <= '" + data2 + "'";
            }

            return a;
        }

        public string Criterios(string documento) {
            string a = "";

            if (!string.IsNullOrEmpty(documento)) {
                a += " and documento = " + documento;
            }

            return a;
        }
    }

}
