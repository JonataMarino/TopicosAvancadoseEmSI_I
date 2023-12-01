using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P2_MVC_.Models
{
    public class EspecProdutos
    {
        [Key]
        public int IdEspec { get; set; }
        [DisplayName("Produto")]
        public string NomeProduto { get; set; }
        [DisplayName("Setor")]
        public string setorProduto { get; set; }

    }
}
