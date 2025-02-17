using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV
{
    public class ClienteDAO
    {

        private Conexao conexao;

        public ClienteDAO()
        {
            conexao = new Conexao();
        }
        public void InserirCliente(Clientes c)
        {
            string comando = "INSERT INTO clientes (nome, identificacao, telefone, nascimento, situacao, logradouro, rua, numero, complemento, bairro, cidade, estado, cep, " +
                "referencia) values (@nome, @identificacao, @telefone, @nascimento, @situacao, @logradouro, @rua, @numero, @complemento, @bairro, @cidade, @estado, @cep, " +
                "@referencia)";


            try
            {
                conexao.AbrirConexao();

                using (MySqlCommand command = new MySqlCommand(comando, conexao.ObterConexao()))
                {
                    command.Parameters.AddWithValue("@nome", c.nome);
                    command.Parameters.AddWithValue("@identificacao", c.identificacao);
                    command.Parameters.AddWithValue("@telefone",string.IsNullOrWhiteSpace(c.telefone) ? (object)DBNull.Value : c.telefone);
                    command.Parameters.AddWithValue("@nascimento", string.IsNullOrWhiteSpace(c.nascimento) ? (object)DBNull.Value : Convert.ToDateTime(c.nascimento));
                    command.Parameters.AddWithValue("@situacao", c.situacao);
                    command.Parameters.AddWithValue("@logradouro", c.logradouro);
                    command.Parameters.AddWithValue("@rua", c.rua);
                    command.Parameters.AddWithValue("@numero", c.numero);
                    command.Parameters.AddWithValue("@complemento", c.complemento);
                    command.Parameters.AddWithValue("@bairro", c.bairro);
                    command.Parameters.AddWithValue("@cidade", c.cidade);
                    command.Parameters.AddWithValue("@estado", c.estado);
                    command.Parameters.AddWithValue("@cep", c.cep);
                    command.Parameters.AddWithValue("@referencia", c.referencia);

                    command.ExecuteNonQuery();

                    command.CommandText = "Select @@IDENTITY";
                    c.codigo = Convert.ToInt32(command.ExecuteScalar());





                }
                conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void AtualizarCliente(Clientes c)
        {
            string comando = "UPDATE clientes SET nome = @nome, identificacao = @identificacao, telefone = @telefone, " +
                "nascimento = @nascimento, situacao = @situacao, logradouro = @logradouro, rua = @rua, numero = @numero, " +
                "complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado, cep = @cep, " +
                "referencia = @referencia WHERE codigo = @codigo";
            try
            {
                conexao.AbrirConexao();
                using (MySqlCommand command = new MySqlCommand(comando, conexao.ObterConexao()))
                {
                    command.Parameters.AddWithValue("@nome", c.nome);
                    command.Parameters.AddWithValue("@identificacao", c.identificacao);
                    command.Parameters.AddWithValue("@telefone", string.IsNullOrWhiteSpace(c.telefone) ? (object)DBNull.Value : c.telefone);
                    command.Parameters.AddWithValue("@nascimento", string.IsNullOrWhiteSpace(c.nascimento) ? (object)DBNull.Value : Convert.ToDateTime(c.nascimento));
                    command.Parameters.AddWithValue("@situacao", c.situacao);
                    command.Parameters.AddWithValue("@logradouro", c.logradouro);
                    command.Parameters.AddWithValue("@rua", c.rua);
                    command.Parameters.AddWithValue("@numero", c.numero);
                    command.Parameters.AddWithValue("@complemento", c.complemento);
                    command.Parameters.AddWithValue("@bairro", c.bairro);
                    command.Parameters.AddWithValue("@cidade", c.cidade);
                    command.Parameters.AddWithValue("@estado", c.estado);
                    command.Parameters.AddWithValue("@cep", c.cep);
                    command.Parameters.AddWithValue("@referencia", c.referencia);
                    command.Parameters.AddWithValue("@codigo", c.codigo);
                    command.ExecuteNonQuery();
                }
                conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool Validacoes(Clientes c) {
            if (string.IsNullOrEmpty(c.nome) || string.IsNullOrEmpty(c.identificacao))
            {
                MessageBox.Show("Preencha o nome e o documento do cliente");
                return true;
            }
               return false;
            
        }


        public DataTable ListarClientes()
        {
            DataTable dt = new DataTable();
            string comando = "SELECT codigo, nome, identificacao, telefone FROM clientes";
            try
            {
                conexao.AbrirConexao();
                using (MySqlCommand command = new MySqlCommand(comando, conexao.ObterConexao()))
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



        public DataTable ClienteByID(string id) {

            DataTable dt = new DataTable();
            string comando = "SELECT * from Clientes where codigo = @id";
            try
            {
                conexao.AbrirConexao();
                using (MySqlCommand command = new MySqlCommand(comando, conexao.ObterConexao()))
                {
                    command.Parameters.AddWithValue("id", id);

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

    }
}
