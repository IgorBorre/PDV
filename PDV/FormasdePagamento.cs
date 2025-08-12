using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV
{
    internal class FormasdePagamento
    {
        public FormasdePagamento()
        {
        }

        public int id { get; set; }
        public string descricao { get; set; }
        public string ativa { get; set; }
        public string avista { get; set; }

    }
}
