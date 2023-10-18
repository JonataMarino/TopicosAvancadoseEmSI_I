using System.Security;

namespace TestUnitXSL.Models
{
	public class Remédio
	{
		public int Id { get; set; }
		public string Descricao { get; set; }
		public decimal valor {  get; set; }
		//var today = DateOnly.FromDateTime(DateTime.Now);
		public string dataCadastro {  get; set; }
		public string dataValidade { get; set; }
	}
}
