using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV
{
    public class Venda
    {
        public int codigo { get; set; }
        public DateTime dataVenda { get; set; }
        public double valorTotal { get; set; }
        public double desconto { get; set; }
        public double acrescimo { get; set; }
        public double subtotal { get; set; }
    }
}
