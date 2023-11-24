namespace P2_MVC_.Models
{
    public class EspecProdutos
    {
        public int IdEspec { get; set; }
        public decimal PrecoProduto { get; set; }
        public EstoqueProduto ProdutoEmEstoque { get; set; }
    }
}
