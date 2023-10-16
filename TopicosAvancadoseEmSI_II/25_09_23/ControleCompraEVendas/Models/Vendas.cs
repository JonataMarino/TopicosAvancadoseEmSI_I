namespace ControleCompraEVendas.Models
{
	public class Vendas
	{
		public int Id { get; set; }
		public Funcionarios funcionario {  get; set; }
		public Clientes cliente { get; set; }
		public Produtos produto { get; set; }
		public int vendidos { get; set; }

	}
}
