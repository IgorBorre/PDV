using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV
{
    public class ClienteDAO
    {

        private Conexao conexao;

        public ClienteDAO() { 
        conexao = new Conexao();
        }
        public void InserirCliente(Clientes c) {
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
                    command.Parameters.AddWithValue("@telefone", c.telefone);
                    command.Parameters.AddWithValue("@nascimento", Convert.ToDateTime(c.nascimento));
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
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
