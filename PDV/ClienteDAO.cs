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
            //codigo de insert no banco passando como parametro os atributos da classe
            string comando = "INSERT INTO clientes (nome, identificacao, telefone, nascimento, situacao, logradouro, rua, numero, complemento, bairro, cidade, estado, cep, " +
                "referencia) values (@nome, @identificacao, @telefone, @nascimento, @situacao, @logradouro, @rua, @numero, @complemento, @bairro, @cidade, @estado, @cep, " +
                "@referencia)";


            try
            {
                conexao.AbrirConexao();

                using (MySqlCommand command = new MySqlCommand(comando, conexao.ObterConexao()))
                {
                    //passando os atributos da classe para o insert no banco
                    command.Parameters.AddWithValue("@nome", c.nome);
                    command.Parameters.AddWithValue("@identificacao", c.identificacao);
                    command.Parameters.AddWithValue("@telefone", c.telefone);

                    //se o valor da string for vazio ou apenas espaços em branco, salva no banco como null, se não for, faz a conversão para DateTime e salva no banco a data convertida
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

                    /*após fazer o insert, faz um select no campo que possui a primary key (codigo) no 
                     banco e atribui o valor no atributo codigo da classe*/
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
            /*codigo para fazer o update no banco de acordo com o codigo do cliente e passando como 
            parametro os atributos da classe*/
            string comando = "UPDATE clientes SET nome = @nome, identificacao = @identificacao, telefone = @telefone, " +
                "nascimento = @nascimento, situacao = @situacao, logradouro = @logradouro, rua = @rua, numero = @numero, " +
                "complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado, cep = @cep, " +
                "referencia = @referencia WHERE codigo = @codigo";
            try
            {
                conexao.AbrirConexao();
                using (MySqlCommand command = new MySqlCommand(comando, conexao.ObterConexao()))
                {

                    //passando os atributos da classe para o update no banco
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

            //validação para verificar se os campos obrigatórios estão preenchidos
            if (string.IsNullOrEmpty(c.nome) || string.IsNullOrEmpty(c.identificacao))
            {
                MessageBox.Show("Preencha o nome e o documento do cliente");
                return true;
            }
               return false;
            
        }


        public DataTable ListarClientes(string c)
        {
            //funcao para fazer o select no banco, que vai ser chamada em outras partes do codigo
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



        public DataTable ClienteByID(string id) {

            //funcao para fazer o select de todos os campos da tabela cliente de acordo com o codigo
            DataTable dt = new DataTable();
            string comando = "SELECT * from Clientes where codigo = " + id;

            //chamando a função de cima que executa o comando passado e armazena os valores em uma DataTable
            return ListarClientes(comando);

        }

        public string Criterios(string codigo, string nome, string telefone, string identificacao) {
            string a = "";

            /*funcao que verifica se os campos de filtro estão preenchidos, para adicionar na variavel a
            e adicionar no select*/
            if (!string.IsNullOrEmpty(codigo))
            {
                a += " and codigo = " + codigo;
            }
            if (!string.IsNullOrEmpty(nome))
            {
                a += " and nome like '%" + nome + "%'";
            }
            if (!string.IsNullOrEmpty(telefone))
            {
                a += " and telefone like '%" + telefone + "%'";
            }
            if (!string.IsNullOrEmpty(identificacao)) { 
                a += " and identificacao like '%" + identificacao + "%'";
            }

            return a;
        }

    }
}
