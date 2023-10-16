namespace ControleCompraEVendas.Models
{
	public class Produtos
	{
		public int Id { get; set; }
		public string descricaoProduto { get; set; }
		public int estoque { get; set; }
		public decimal valor { get; set; }


		public void BaixarEstoque(int vendidos)
		{
			this.estoque -= vendidos;
		}
	}
}
