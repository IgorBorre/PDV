using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV
{
    public class Produtos
    {
        public int codigo { get; set; }
        public string referencia { get; set; }
        public string descricao { get; set; }
        public string grupo { get; set; }
        public int idGrupo { get; set; }
        public double estoque { get; set; }
        public double preco { get; set; }

        public double quantidade { get; set; }

    }
}
