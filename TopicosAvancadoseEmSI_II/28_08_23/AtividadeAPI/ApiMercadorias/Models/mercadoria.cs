namespace ApiMercadorias.Models
{
	public class mercadoria
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public decimal Price {  get; set; }
		public DateTime Date_Update { get; set; } //current date (Atualizável)
		public int NumberOfProducts { get; set; }
	}
}
