using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P2_2_MVC_.Models
{
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [Required]
        public DateTime DataPedido { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
