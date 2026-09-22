
namespace PDV.Classes
{
    public class Produtos
    {
        public int codigo { get; set; }
        public string? referencia { get; set; }
        public string? descricao { get; set; }
        public string? grupo { get; set; }
        public int? idGrupo { get; set; }
        public double estoque { get; set; }
        public double preco { get; set; }
        public double quantidade { get; set; }
        public DateTime movimentacao { get; set; }

    }
}
