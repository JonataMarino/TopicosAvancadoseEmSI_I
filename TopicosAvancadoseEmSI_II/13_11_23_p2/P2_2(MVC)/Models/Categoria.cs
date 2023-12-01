using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P2_2_MVC_.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required]
        public string Nome { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}
