using System.Security.Permissions;

namespace WebApp30102023.Models
{
	public class Aluno
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string telefone { get; set; }
		public string Endereco { get; set; }
		public string NomeDoPai { get; set; }
		public string NomeDaMae { get; set; }
		public double Nota1 { get; set; }
		public double Nota2 { get; set; }
		public double Nota3 { get; set; }
		public double Nota4 { get; set; }
		public double Media(double media)
		{
			media = ( 1 * (Nota1 + Nota2 + Nota3 + Nota4) / 2 );
			return media;
		}

	}
}
