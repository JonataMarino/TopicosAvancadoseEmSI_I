namespace ControleCompraEVendas.Models
{
	public class Estoque
	{
        public int Id { get; set; }
		public string Nome { get; set; }
		public Produtos Produto { get; set; }
		public int Quantidade { get; set; }

		public void DecrementarQuantidade(int quantia)
		{
			this.Quantidade -= quantia;
		}
}
	}
