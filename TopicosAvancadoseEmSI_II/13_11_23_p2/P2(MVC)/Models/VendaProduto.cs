using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P2_MVC_.Models
{
    public class VendaProduto
    {
        [Key]
        public int IdVenda { get; set; }
        public Produto produto { get; set; }
        public decimal ValorTotalVenda { get; set; }
        public int quantidadeVendida { get; set; }
    }
}
