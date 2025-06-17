using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV
{
    public class Clientes
    {
        public Clientes(int codigo, string nome) { 
            this.codigo = codigo;
            this.nome = nome;
        }

        public Clientes() { }
      public int codigo { get; set;}
      public  string nome { get; set;}
      public string identificacao { get; set; }
      public string telefone { get; set; }
      public string nascimento { get; set; }
      public string situacao { get; set; }
      public string logradouro { get; set; }
      public string rua { get; set; }
      public string numero { get; set; }
      public string complemento { get; set; }
      public string bairro { get; set; }
      public string cidade { get; set; }
      public string estado { get; set; }
      public  string cep { get; set; }
      public string referencia { get; set; }
    }
}
