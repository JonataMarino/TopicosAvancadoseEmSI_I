using System.ComponentModel;

namespace ProjAPIP2.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [DisplayName("Produto")]
        public string NomeProduto { get; set; }

        [DisplayName("Fabricante")]
        public string Fabricante { get; set; }

        [DisplayName("Fornecedor")]
        public string Fornecedor { get; set; }

        [DisplayName("Data da Compra")]
        public string DataCompra { get; set; }

        [DisplayName("Validade")]
        public string DataVencimento { get; set; }
    }
}
