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
		public double Media(double N1, double N2, double N3, double N4)
		{
			double media = (1 * (N1 + N2 + N3 + N4) / 4);
			return media;
		}
 
	}
}
