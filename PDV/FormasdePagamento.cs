using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV
{
    public class FormasdePagamento
    {
        public FormasdePagamento(string descricao, string ativa, string avista)
        {
            this.descricao = descricao;
            this.ativa = ativa;
            this.avista = avista;
        }

        public FormasdePagamento(int id, string descricao, int parcelas, double valor) { 

            this.id = id;
            this.descricao = descricao;
            this.parcelas = parcelas;
            this.valor = valor;
        }

        public FormasdePagamento() { }

        public int id { get; set; }
        public string descricao { get; set; }
        public string ativa { get; set; }
        public string avista { get; set; }
        public int parcelas { get; set; }
        public double valor { get; set; }



    }
}
