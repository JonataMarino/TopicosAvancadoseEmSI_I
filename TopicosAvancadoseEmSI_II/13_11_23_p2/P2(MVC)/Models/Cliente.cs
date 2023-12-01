using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P2_MVC_.Models
{
    public class Cliente
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Contato { get; set; }

        public string Documento { get; set; }
    }
}
