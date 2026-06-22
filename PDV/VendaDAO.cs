using MySql.Data.MySqlClient;
using System.Data;

namespace PDV
{
    public class VendaDAO
    {
        private readonly Conexao con;
        private readonly string comandoSaida = "insert into saida (dataSaida, valortotal, desconto, acrescimo, subtotal, clienteId, clienteNome, doc_original, tipo) " +
            "values (@dataSaida, @valortotal, @desconto, @acrescimo, @subtotal, @clienteId, @clienteNome, @docDevolucao, @tipo)";

        private readonly string comandoSaidaDados = "insert into saidadados (documento, produto, produtoNome, quantidade, valor) " +
            "values (@documento, @produto, @produtoNome, @quantidade, @valor)";

        private readonly string remProdutos = "update produtos set estoque = estoque - @quantidade where codigo = @codigo";
        private readonly string comandoPagsaida = "insert into pagsaida (documento, idpagamento, descpagamento, valor, parcelas) " +
            "values (@documento, @idpagamento, @descpagamento, @valor, @parcelas)";

        private readonly string comando = "update saida set cancelada = 'S' where documento = @documento";
        private readonly string selectSaidadados = "select produto, quantidade from saidadados where documento = @documento";
        private readonly string addProdutos = "update produtos set estoque = estoque + @quantidade where codigo = @codigo";
        private readonly string cancelamentoLog = "insert into cancelamentoLog(documento, motivo, dataCancelamento) values(@documento, @motivo, @dataCancelamento)";

        public VendaDAO() { 
            con = new Conexao();
        }

        public void Venda(Venda v, List<Produtos> produtos, Clientes? c, List<FormasdePagamento>? formaspag, string? docDevolucao) { 
            
            con.AbrirConexao();

            try
            {
                AddVenda(v, c, docDevolucao);

                if (produtos.Count > 0) 
                    AddProdutos(v, produtos);

                if (formaspag != null && formaspag.Count > 0)
                    AddPagamento(v, formaspag);

                con.FecharConexao();
                MessageBox.Show("Documento " + v.codigo + " gravado com sucesso!");
            }
            catch (Exception ex)
            {
                throw new(ex.Message);
            }
            finally
            {
                con.FecharConexao();
            }

        }

        private void AddVenda(Venda v, Clientes? c, string? docDevolucao) {
            v.dataVenda = DateTime.Now.Date;

            using MySqlCommand cmd = new(comandoSaida, con.ObterConexao());
            cmd.Parameters.AddWithValue("@dataSaida", v.dataVenda);
            cmd.Parameters.AddWithValue("@valortotal", v.valorTotal);
            cmd.Parameters.AddWithValue("@desconto", v.desconto);
            cmd.Parameters.AddWithValue("@acrescimo", v.acrescimo);
            cmd.Parameters.AddWithValue("@subtotal", v.subtotal);

            cmd.Parameters.AddWithValue("@clienteId",
                c?.codigo > 0 ? c.codigo : DBNull.Value);

            cmd.Parameters.AddWithValue("@clienteNome",
                !string.IsNullOrEmpty(c?.nome) ? c.nome : DBNull.Value);

            cmd.Parameters.AddWithValue("@docDevolucao",
                !string.IsNullOrEmpty(docDevolucao) ? docDevolucao : DBNull.Value);

            cmd.Parameters.AddWithValue("@tipo",
                !string.IsNullOrEmpty(docDevolucao) ? "T" : "N");

            cmd.ExecuteNonQuery();
            v.codigo = (int)cmd.LastInsertedId;
        }

        private void AddProdutos(Venda v, List<Produtos> produtos) {
           
            foreach (Produtos p in produtos)
            {
                using (MySqlCommand cmd = new(comandoSaidaDados, con.ObterConexao()))
                {
                    cmd.Parameters.AddWithValue("@documento", v.codigo);
                    cmd.Parameters.AddWithValue("@produto", p.codigo);
                    cmd.Parameters.AddWithValue("@produtoNome", p.descricao);
                    cmd.Parameters.AddWithValue("@quantidade", p.quantidade);
                    cmd.Parameters.AddWithValue("@valor", p.preco);

                    cmd.ExecuteNonQuery();

                }

                using (MySqlCommand cmd = new(remProdutos, con.ObterConexao()))
                {
                    cmd.Parameters.AddWithValue("@quantidade", p.quantidade);
                    cmd.Parameters.AddWithValue("@codigo", p.codigo);

                    cmd.ExecuteNonQuery();
                }
            }

        }

        private void AddPagamento(Venda v, List<FormasdePagamento> formaspag) {
            foreach (FormasdePagamento f in formaspag)
            {
                using MySqlCommand cmd = new(comandoPagsaida, con.ObterConexao());
                cmd.Parameters.AddWithValue("@documento", v.codigo);
                cmd.Parameters.AddWithValue("@idpagamento", f.id);
                cmd.Parameters.AddWithValue("@descpagamento", f.descricao);
                cmd.Parameters.AddWithValue("@valor", f.valor);
                cmd.Parameters.AddWithValue("@parcelas", f.parcelas);
                cmd.ExecuteNonQuery();

            }
        }
                          
        public void CancelarVenda(string documento, string motivo)
        {

            try
            {
                DataTable dt = ConsultaSaidas(selectSaidadados);
                con.AbrirConexao();

                foreach (DataRow row in dt.Rows)
                {
                    Produtos p = new()
                    {
                        codigo = (int)row["produto"],
                        quantidade = (double)row["quantidade"]
                    };

                    using MySqlCommand cmd = new(addProdutos, con.ObterConexao());
                    cmd.Parameters.AddWithValue("@quantidade", p.quantidade);
                    cmd.Parameters.AddWithValue("@codigo", p.codigo);
                    cmd.ExecuteNonQuery();
                }

                using (MySqlCommand cmd = new(comando, con.ObterConexao()))
                {
                    cmd.Parameters.AddWithValue("@documento", documento);

                    cmd.ExecuteNonQuery();
                }

                using (MySqlCommand cmd = new(cancelamentoLog, con.ObterConexao()))
                {
                    cmd.Parameters.AddWithValue("@documento", documento);
                    cmd.Parameters.AddWithValue("@motivo", motivo);
                    cmd.Parameters.AddWithValue("@dataCancelamento", DateTime.Now.Date);

                    cmd.ExecuteNonQuery();
                }
                con.FecharConexao();
                MessageBox.Show("Documento " + documento + " cancelado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                
        public DataTable ConsultaSaidas(string c)
        {
            DataTable dt = new();
            try
            {
                con.AbrirConexao();
                using (MySqlCommand command = new(c, con.ObterConexao()))
                {
                    using MySqlDataAdapter da = new(command);
                    da.Fill(dt);
                }
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;

        }

        public bool Validações(double preco, double quantidade)
        {
            if (preco <= 0)
            {
                MessageBox.Show("Não é permitido inserir um produto sem valor ou com valor negativo");
                return false;
            }
            if (quantidade <= 0)
            {
                MessageBox.Show("Não é permitido inserir um produto sem quantidade ou com quantidade negativa");
                return false;
            }
            return true;
        }

        public string Criterios(string documento, bool devolucao, string? cliente = null , string? data1 = null, string? data2 = null) {

            string a = "";

            if (!string.IsNullOrEmpty(documento))
            {
                a += " and documento = " + documento;
            }
                       
            if (devolucao) {
                a += Devolucao(cliente, data1, data2);
            }
            else
            {
               a += Saida(cliente, data1, data2);

            }

            return a;
        }


        private static string Devolucao(string? cliente, string? data1, string? data2) {
            string a = "";

            if (!string.IsNullOrEmpty(data1) && !string.IsNullOrEmpty(data2))
            {
                a += " and dataDevolucao between" + "'" + data1 + "'" + " and " + "'" + data2 + "'";
            }

            if (!string.IsNullOrEmpty(cliente))
            {
                a += " and idCliente = " + cliente;
            }

            if (!string.IsNullOrEmpty(data1) && string.IsNullOrEmpty(data2))
            {
                a += " and dataDevolucao >= '" + data1 + "'";
            }

            if (string.IsNullOrEmpty(data1) && !string.IsNullOrEmpty(data2))
            {
                a += " and dataDevolucao <= '" + data2 + "'";
            }

            return a;
        }


        private static string Saida(string? cliente, string? data1, string? data2)
        {
            string a = "";

            if (!string.IsNullOrEmpty(data1) && !string.IsNullOrEmpty(data2))
            {
                a += " and dataSaida between" + "'" + data1 + "'" + " and " + "'" + data2 + "'";
            }

            if (!string.IsNullOrEmpty(cliente))
            {
                a += " and clienteNome like '%" + cliente + "%'";
            }

            if (!string.IsNullOrEmpty(data1) && string.IsNullOrEmpty(data2))
            {
                a += " and dataSaida >= '" + data1 + "'";
            }

            if (string.IsNullOrEmpty(data1) && !string.IsNullOrEmpty(data2))
            {
                a += " and dataSaida <= '" + data2 + "'";
            }

            return a;
        }

        
        public string Validacoes(string documento, string? data1 = null, string? data2 = null) { 
            string a = "";

            if (!string.IsNullOrEmpty(documento)) { 
                a += " and documento = "+documento;
            }
            if (!string.IsNullOrEmpty(data1) && !string.IsNullOrEmpty(data2)) { 
                a += " and dataCancelamento between" + "'" + data1 + "'" + " and " + "'" + data2 + "'";
            }
            if (!string.IsNullOrEmpty(data1) && string.IsNullOrEmpty(data2)) { 
                a += " and dataCancelamento >= '" + data1 + "'";
            }
            if (string.IsNullOrEmpty(data1) && !string.IsNullOrEmpty(data2)) { 
                a += " and dataCancelamento <= '" + data2 + "'";
            }

            return a;
        }
    }

}
