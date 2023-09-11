namespace ProjControleEstoqueAPI.Models
{
	public class Estoque
	{
		public int Id { get; set; }
		public string Descricao { get; set; }
		public int Quantidade { get; set; }
		public Produto Produto { get; set; }
	}
}
