namespace ApiMercadorias.Models
{
	public class cliente
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Telephone { get; set;}
		public DateTime Date_Persist { get; set; } //Data da inclusão -> fixa
	}
}
