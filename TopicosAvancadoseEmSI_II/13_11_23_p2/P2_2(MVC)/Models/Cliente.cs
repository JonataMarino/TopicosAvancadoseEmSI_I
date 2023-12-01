using System.ComponentModel.DataAnnotations;


namespace P2_2_MVC_.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        public string Telefone { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
