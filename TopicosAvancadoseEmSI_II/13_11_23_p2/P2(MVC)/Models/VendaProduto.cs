namespace P2_MVC_.Models
{
    public class VendaProduto
    {
        public int IdVenda { get; set; }
        public Produto produto { get; set; }
        public decimal ValorVenda { get; set; }
        public int quantidadeVendida { get; set; }
    }
}
