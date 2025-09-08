using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PDV
{
    internal class FormasdePagamentoDAO
    {
       private Conexao conexao;
        public FormasdePagamentoDAO()
        {
            conexao = new Conexao();
        }

         public void incluirFormadePagamento(FormasdePagamento f) {
            string comando = "INSERT INTO formas_pagamento (descricao, ativa, avista) values (@descricao, @ativa, @avista)";
            try
            {
                conexao.AbrirConexao();
                using (MySqlCommand command = new MySqlCommand(comando, conexao.ObterConexao()))
                {
                    command.Parameters.AddWithValue("@descricao", f.descricao.ToUpper());
                    command.Parameters.AddWithValue("@ativa", f.ativa);
                    command.Parameters.AddWithValue("@avista", f.avista);
                    command.ExecuteNonQuery();


                    command.CommandText = "Select @@IDENTITY";
                    f.id = Convert.ToInt32(command.ExecuteScalar());



                }
                conexao.FecharConexao();
            }
            catch (Exception e) { 
                MessageBox.Show(e.Message);
            }

            

        }

        public void atualizarFormadePagamento(FormasdePagamento f) {
            string comando = "UPDATE formas_pagamento set descricao = @descricao, ativa = @ativa, avista = @avista where id = @id";


            try
            {
                conexao.AbrirConexao();

                using (MySqlCommand command = new MySqlCommand(comando, conexao.ObterConexao()))
                {
                    command.Parameters.AddWithValue("@descricao", f.descricao.ToUpper());
                    command.Parameters.AddWithValue("@ativa", f.ativa);
                    command.Parameters.AddWithValue("@avista", f.avista);
                    command.Parameters.AddWithValue("@id", f.id);
                    command.ExecuteNonQuery();
                }
                conexao.FecharConexao();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public bool validacoes(FormasdePagamento f) {
            if (string.IsNullOrEmpty(f.avista) || string.IsNullOrEmpty(f.ativa) || string.IsNullOrEmpty(f.descricao))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
                return false;
            }
            return true;
        }

        public DataTable ListarFormasdePagamento(string c) {
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

        public DataTable ListarFormasdePagamentoPorId(int id) {
            string c = "SELECT * FROM formas_pagamento where id = @id";

            DataTable dt = new DataTable();
            try
            {
                conexao.AbrirConexao();
                using (MySqlCommand command = new MySqlCommand(c, conexao.ObterConexao()))
                {
                    command.Parameters.AddWithValue("@id", id);
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

        public DataTable ListarAvista(int id)
        {
            string c = "SELECT avista FROM formas_pagamento where id = @id";

            DataTable dt = new DataTable();
            try
            {
                conexao.AbrirConexao();
                using (MySqlCommand command = new MySqlCommand(c, conexao.ObterConexao()))
                {
                    command.Parameters.AddWithValue("@id", id);
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
