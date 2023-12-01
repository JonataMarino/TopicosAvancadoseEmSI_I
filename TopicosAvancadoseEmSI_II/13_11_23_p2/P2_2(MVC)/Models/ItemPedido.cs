using System.ComponentModel.DataAnnotations;

namespace P2_2_MVC_.Models
{
    public class ItemPedido
    {
        [Key]
        public int ItemPedidoId { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        public decimal PrecoUnitario { get; set; }
    }
}
