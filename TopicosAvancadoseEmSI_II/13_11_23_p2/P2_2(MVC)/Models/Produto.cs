using System.ComponentModel.DataAnnotations;


namespace P2_2_MVC_.Models
{

    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Required]
        public decimal Preco { get; set; }

        public int Estoque { get; set; }
    }
}
