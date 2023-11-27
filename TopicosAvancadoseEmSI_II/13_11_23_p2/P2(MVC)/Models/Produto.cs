namespace P2_MVC_.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public EspecProdutos EspecProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Fabricante { get; set; }   
    }
}
