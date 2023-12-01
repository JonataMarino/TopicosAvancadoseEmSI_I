using System.ComponentModel.DataAnnotations;

namespace P2_MVC_.Models
{
    public class ComprasCliente
    {
        [Key]
        public int CompraId { get; set; }
        Cliente Cliente { get; set; }
        VendaProduto VendaProduto { get; set; }

    }
}
