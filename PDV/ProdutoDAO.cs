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

        public string CriteriosConsulta(string documento, string fornecedor, string data1, string data2) { 
            string a = "";

            if (!string.IsNullOrEmpty(documento)) { 
                a += " and documento = " + documento;
            }

            if (!string.IsNullOrEmpty(fornecedor)) { 
                a += " and nomefornecedor like '%" + fornecedor +"%'";
            }

            if (!string.IsNullOrEmpty(data1) && !string.IsNullOrEmpty(data2)) { 
                a += " and dataentrada between" + "'"+data1+"'" + " and " + "'"+data2+"'";
            }

            if (!string.IsNullOrEmpty(data1) && string.IsNullOrEmpty(data2)) { 
                a += " and dataentrada >=" + "'" + data1 + "'";
            }

            if (string.IsNullOrEmpty(data1) && !string.IsNullOrEmpty(data2)) { 
                a += " and dataentrada <=" + "'" + data2 + "'";
            }
            return a;

        }

        public void Entrada(Entrada e, Clientes c, List<Produtos> produtos) {
            string comando = "insert into entrada (idfornecedor, nomefornecedor, dataentrada) values (@idfornecedor, @nomefornecedor, @dataentrada)";
            string comandoEntrada = "insert into entradadados (docentrada, idproduto, descproduto, quantidade) values (@docentrada, @idproduto, @descproduto, @quantidade)";
            string atualizaEstoque = "update produtos set estoque = estoque + @quantidade where codigo = @codigo";
            e.data = DateTime.Now.Date;

            try
            {
                conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand(comando, conexao.ObterConexao())) {
                    cmd.Parameters.AddWithValue("@idfornecedor", c.codigo);
                    cmd.Parameters.AddWithValue("@nomefornecedor", c.nome);
                    cmd.Parameters.AddWithValue("@dataentrada", e.data);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT @@IDENTITY";
                    e.documento = Convert.ToInt32(cmd.ExecuteScalar());
                }

                foreach (Produtos p in produtos) {
                    using (MySqlCommand cmd = new MySqlCommand(comandoEntrada, conexao.ObterConexao())) {
                        cmd.Parameters.AddWithValue("@docentrada", e.documento);
                        cmd.Parameters.AddWithValue("@idproduto", p.codigo);
                        cmd.Parameters.AddWithValue("@descproduto", p.descricao);
                        cmd.Parameters.AddWithValue("@quantidade", p.quantidade);

                        cmd.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(atualizaEstoque, conexao.ObterConexao())) {
                        cmd.Parameters.AddWithValue("@quantidade", p.quantidade);
                        cmd.Parameters.AddWithValue("@codigo", p.codigo);

                        cmd.ExecuteNonQuery();
                    }
                }
                conexao.FecharConexao();
                MessageBox.Show("Documento " + e.documento.ToString() + " gravado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void Entrada(Entrada e, List<Produtos> produtos)
        {
            string comando = "insert into entrada (dataentrada) values (@dataentrada)";
            string comandoEntrada = "insert into entradadados (docentrada, idproduto, descproduto, quantidade) values (@docentrada, @idproduto, @descproduto, @quantidade)";
            string atualizaEstoque = "update produtos set estoque = estoque + @quantidade where codigo = @codigo";
            e.data = DateTime.Now.Date;

            try
            {
                conexao.AbrirConexao();
                using (MySqlCommand cmd = new MySqlCommand(comando, conexao.ObterConexao()))
                {
                    cmd.Parameters.AddWithValue("@dataentrada", e.data);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT @@IDENTITY";
                    e.documento = Convert.ToInt32(cmd.ExecuteScalar());
                }

                foreach (Produtos p in produtos)
                {
                    using (MySqlCommand cmd = new MySqlCommand(comandoEntrada, conexao.ObterConexao()))
                    {
                        cmd.Parameters.AddWithValue("@docentrada", e.documento);
                        cmd.Parameters.AddWithValue("@idproduto", p.codigo);
                        cmd.Parameters.AddWithValue("@descproduto", p.descricao);
                        cmd.Parameters.AddWithValue("@quantidade", p.quantidade);

                        cmd.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(atualizaEstoque, conexao.ObterConexao()))
                    {
                        cmd.Parameters.AddWithValue("@quantidade", p.quantidade);
                        cmd.Parameters.AddWithValue("@codigo", p.codigo);

                        cmd.ExecuteNonQuery();
                    }
                }
                conexao.FecharConexao();
                MessageBox.Show("Documento " + e.documento.ToString() + " gravado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CancelarEntrada(string documento, string motivo) {
            string comando = "update entrada set cancelada = 'S' where documento = @documento";
            string selectEntrada = "select idproduto, quantidade from entradadados where docentrada = " + documento;
            string atualizaEstoque = "update produtos p set estoque = estoque - @quantidade where codigo = @codigo";
            string cancelamentoentradalog = "insert into cancelamentoentradalog (documento, motivo , dataCancelamento) values (@documento, @motivo ,@dataCancelamento)";
            DataTable dt = ListarProdutos(selectEntrada);

            try
            {
                conexao.AbrirConexao();

                foreach (DataRow row in dt.Rows) { 
                    Produtos p = new Produtos();
                    p.codigo = Convert.ToInt32(row["idproduto"]);
                    p.quantidade = Convert.ToDouble(row["quantidade"]);

                    using (MySqlCommand cmd = new MySqlCommand(atualizaEstoque, conexao.ObterConexao())) { 
                        cmd.Parameters.AddWithValue("@quantidade", p.quantidade);
                        cmd.Parameters.AddWithValue("@codigo", p.codigo);
                        cmd.ExecuteNonQuery();
                    }
                }

                using (MySqlCommand cmd = new MySqlCommand(comando, conexao.ObterConexao())) {
                    cmd.Parameters.AddWithValue("@documento", documento);
                    cmd.ExecuteNonQuery();
                }

                using (MySqlCommand cmd = new MySqlCommand(cancelamentoentradalog, conexao.ObterConexao()))
                {
                    cmd.Parameters.AddWithValue("@documento", documento);
                    cmd.Parameters.AddWithValue("@motivo", motivo);
                    cmd.Parameters.AddWithValue("@dataCancelamento", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
                conexao.FecharConexao();
                MessageBox.Show("Entrada cancelada com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao cancelar entrada: " + e);
            }
        }

        public String CriteriosConsultaCancelamentoEntrada(string documento, string data1, string data2) { 
            string a = "";

            if (!string.IsNullOrEmpty(documento)) { 
                a += " and documento = " + documento;
            }

            if (!string.IsNullOrEmpty(data1) && !string.IsNullOrEmpty(data2)) {
                a += " and dataCancelamento between" + "'" + data1 + "'" + " and " + "'" + data2 + "'";
            }

            if (!string.IsNullOrEmpty(data1) && string.IsNullOrEmpty(data2))
            {
                a += " and dataCancelamento >=" + "'" + data1 + "'";
            }

            if (string.IsNullOrEmpty(data1) && !string.IsNullOrEmpty(data2))
            {
                a += " and dataCancelamento <=" + "'" + data2 + "'";
            }

            return a;
        }

    }
}
