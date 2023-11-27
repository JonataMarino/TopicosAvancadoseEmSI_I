namespace P2_MVC_.Models
{
    public class EstoqueProduto
    {
        public int IdEstoque { get; set; }
        Produto produto { get; set; }
        public float QuantidadeEstoque { get; set; }

    }
}
